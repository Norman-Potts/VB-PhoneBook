Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Module MainModule
    Dim connectionSQL As String = "Server=.\SQLEXPRESS;Database=PhoneBookDatabase;Trusted_Connection=True;"
    Dim connect As New SqlConnection(connectionSQL)

    Public Function ChangeToFristLetterUpper(Input) As String
        Dim Output As String = ""
        Dim pattern As String = "[A-Za-z]+"
        Dim replacement As String = ""
        Dim myRegExp As Regex = New Regex(pattern)
        Dim replaced As String = myRegExp.Replace(Input, replacement)
        If (replaced.Length > 0) Then
            Dim r() As Char = replaced.ToCharArray
            r(0) = Char.ToUpper(r(0))
            Output = Input
        Else
            Output = ""
        End If
        Return Output
    End Function

    Sub PopulateListView()
        Console.WriteLine("Populate List View")
        Try
            Dim listview As ListViewItem
            connect.Open()
            Dim SQL As String = "SELECT * FROM PhoneBook"
            Dim Command As New SqlCommand
            Command.CommandText = SQL
            Command.Connection = connect
            Dim DataRead As SqlDataReader
            DataRead = Command.ExecuteReader()
            Form.MainListView.Items.Clear()
            While DataRead.Read() = True
                listview = New ListViewItem(Convert.ToString(DataRead("ID")))
                For i As Integer = 1 To 4
                    Dim inputstr As String = Convert.ToString(DataRead.GetValue(i))
                    listview.SubItems.Add(inputstr)
                Next i
                Form.MainListView.Items.Add(listview)
            End While
            DataRead.Close()
            connect.Close()
        Catch ex As Exception
            Console.WriteLine("Error in PopulateListView: ex " & ex.Message)
            Form.lbl_Status.Text = "Computer error. Problem with loading from database."
            Form.lbl_Status.ForeColor = Color.Red
        End Try
    End Sub


    Sub CreateRecord()
        Dim intRows As Integer = 0
        If TestData() = True Then
            Try
                connect.Open()
                Dim SQL As String = "INSERT INTO PhoneBook ( lastname, firstname, phone, email) VALUES(  @LastName , @FirstName , @Phone, @Email )"
                Dim Command As New SqlCommand
                Command.CommandText = SQL
                Command.Connection = connect
                Command.Parameters.Add("@LastName", SqlDbType.VarChar)
                Command.Parameters("@LastName").Value = Form.txtBx_Lastname.Text
                Command.Parameters.Add("@FirstName", SqlDbType.VarChar)
                Command.Parameters("@FirstName").Value = Form.txtBx_Firstname.Text
                Command.Parameters.Add("@Phone", SqlDbType.VarChar)
                Command.Parameters("@Phone").Value = Form.txtBx_PhoneNumber.Text
                Command.Parameters.Add("@Email", SqlDbType.VarChar)
                Command.Parameters("@Email").Value = Form.txtBx_Email.Text
                Console.WriteLine("command")
                intRows = Command.ExecuteNonQuery
                If intRows = 1 Then
                    Form.lbl_Status.Text = "Recored was succeful inserted into database."
                    Form.lbl_Status.ForeColor = Color.Black
                Else
                    Form.lbl_Status.Text = "Record was not inserted into database."
                    Form.lbl_Status.ForeColor = Color.Red
                End If
            Catch ex As Exception
                Console.WriteLine("Error on CreateRecord() function" & ex.Message)
                Form.lbl_Status.Text = "Computer error when creating input"
                Form.lbl_Status.ForeColor = Color.Red
            Finally
                connect.Close()
            End Try
        End If
    End Sub


    Sub UpdateRecord()
        Dim intRows As Integer
        If TestData() = True Then
            Try
                Dim ID As String = Form.lbl_ValueID.Text
                Dim Firstname As String = Form.txtBx_Firstname.Text.Replace("'", "''")
                Dim Lastname As String = Form.txtBx_Lastname.Text.Replace("'", "''")
                Dim Phone As String = Form.txtBx_PhoneNumber.Text
                Dim Email As String = Form.txtBx_Email.Text.Replace("'", "''")

                connect.Open()
                Dim Command As New SqlCommand
                Command.CommandText = "UPDATE PhoneBook Set lastname ='" & Lastname & "', firstname = '" & Firstname & "', phone = '" & Phone & "', email = '" & Email & "' WHERE ID = " & ID
                Command.Connection = connect
                intRows = Command.ExecuteNonQuery

                If intRows = 1 Then
                    Form.lbl_Status.Text = "Phonebook record " & ID & " updated"
                    Form.lbl_Status.ForeColor = Color.Black
                Else
                    Form.lbl_Status.Text = "Phonebook not updated."
                    Form.lbl_Status.ForeColor = Color.Red
                End If
            Catch ex As Exception
                Console.WriteLine("Exception in Update Record" & ex.Message)
                Form.lbl_Status.Text = "Computer error when updating record. "
                Form.lbl_Status.ForeColor = Color.Red
            Finally
                connect.Close()
            End Try
        End If
    End Sub


    Sub RetreiveRecord()
        Dim ID As String = DetermineSelection()
        ResetStatus()
        Try
            Console.WriteLine("ID: " + ID)
            If ID = -1 Then
                Form.lbl_Status.Text = "No record has been selected to retrive."
                Form.lbl_Status.ForeColor = Color.Red
            Else
                connect.Open()
                Dim Command As New SqlCommand
                Command.CommandText = "SELECT ID, lastname, firstname, phone, email FROM PhoneBook WHERE ID =" & ID
                Command.Connection = connect
                Dim DataRead As SqlDataReader = Command.ExecuteReader()
                If DataRead.Read Then
                    Form.lbl_ValueID.Text = ID
                    Form.txtBx_Firstname.Text = DataRead("firstname").ToString
                    Form.txtBx_Lastname.Text = DataRead("lastname").ToString
                    Form.txtBx_PhoneNumber.Text = DataRead("phone").ToString
                    Form.txtBx_Email.Text = DataRead("email").ToString
                    Form.btn_Create.Enabled = False
                    Form.btn_Update.Enabled = True
                    Form.btn_Delete.Enabled = True
                Else
                    Form.txtBx_Firstname.Text = ""
                    Form.txtBx_Lastname.Text = ""
                    Form.txtBx_Email.Text = ""
                    Form.txtBx_PhoneNumber.Text = ""
                    Form.lbl_Status.Text = "That record is actually not in the database."
                    Form.lbl_Status.ForeColor = Color.Red
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("error on RetreiveRecord() function" & ex.Message)
        Finally
            connect.Close()
        End Try
    End Sub



    Sub DeleteRecord()
        Dim intRows As Integer
        ResetStatus()
        Dim ID As Integer = DetermineSelection()
        Try
            connect.Open()
            Dim Command As New SqlCommand
            Command.CommandText = "DELETE FROM PhoneBook WHERE ID =" & ID
            Command.Connection = connect
            intRows = Command.ExecuteNonQuery
            If intRows = 1 Then
                Form.lbl_Status.Text = "Phonebook record " & ID & " deleted."
                Form.lbl_Status.ForeColor = Color.Black
                Form.lbl_ValueID.Text = ""
                Form.txtBx_Firstname.Text = ""
                Form.txtBx_Lastname.Text = ""
                Form.txtBx_PhoneNumber.Text = ""
                Form.txtBx_Email.Text = ""
                Form.btn_Create.Enabled = True
                Form.btn_Update.Enabled = False
                Form.btn_Delete.Enabled = False

            Else
                Form.lbl_Status.Text = "Phonebook record ID " & ID & " not deleted."
                Form.lbl_Status.ForeColor = Color.Red
            End If
        Catch ex As Exception
            Form.lbl_Status.Text = "Computer error when deleting input. Could not delete phonebook ID " & ID & "."
            Form.lbl_Status.ForeColor = Color.Red
        Finally
            connect.Close()
        End Try
    End Sub

    Public Sub ClearRecords()
        Form.lbl_ValueID.Text = ""
        Form.txtBx_Firstname.Text = ""
        Form.txtBx_Lastname.Text = ""
        Form.txtBx_PhoneNumber.Text = ""
        Form.txtBx_Email.Text = ""
        Form.MainListView.SelectedItems.Clear()
        Form.btn_Create.Enabled = True
        Form.btn_Update.Enabled = False
        Form.btn_Delete.Enabled = False
        ResetStatus()
    End Sub

    Private Sub ResetStatus()
        Form.lbl_Status.Text = ""
        Form.lbl_Status.ForeColor = Color.Black
    End Sub


    Private Function DetermineSelection() As String
        Dim SelectedID As String
        If Form.MainListView.SelectedItems.Count() <> 0 Then
            SelectedID = Form.MainListView.SelectedItems(0).SubItems(0).Text
        Else
            Form.lbl_Status.Text = "You did not select a row from the Phonebook."
            Form.lbl_Status.ForeColor = Color.Red
            SelectedID = -1
        End If
        Return SelectedID
    End Function


    Private Function TestData() As Boolean
        Dim FirstName As String
        Dim LastName As String
        Dim Phone As String
        Dim Email As String
        Dim ErrorFlag As Boolean = True
        Dim Empty = Form.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        If Empty.Any Then
            Form.lbl_Status.Text = "Fields cannot be empty."
            ErrorFlag = False
            Form.lbl_Status.ForeColor = Color.Red
        Else
            FirstName = Form.txtBx_Firstname.Text.ToString
            LastName = Form.txtBx_Lastname.Text.ToString
            Phone = Form.txtBx_PhoneNumber.Text
            Email = Form.txtBx_Email.Text
            Dim Emailpattern As String = "^[A-Za-z0-9@._%+-]{6,254}$"
            Dim EmailReg As Regex = New Regex(Emailpattern)
            If (EmailReg.IsMatch(Email) <> True) Then
                Form.lbl_Status.Text = "Email contains invalid characters."
                ErrorFlag = False
                Form.lbl_Status.ForeColor = Color.Red
            Else
                Dim SecondEmailpattern As String = "^[A-Za-z0-9][A-Za-z0-9._%+-]{0,63}@(?:[A-Za-z0-9-]{1,63}\.){1,125}[A-Za-z]{2,63}$"
                Dim SecondEmailReg As Regex = New Regex(SecondEmailpattern)
                If (SecondEmailReg.IsMatch(Email) <> True) Then
                    Form.lbl_Status.Text = "Email is not a valid email format."
                    ErrorFlag = False
                    Form.lbl_Status.ForeColor = Color.Red

                Else
                    Dim pattNames As String = "^[A-Za-z]+$"
                    Dim namesReg As Regex = New Regex(pattNames)
                    If (namesReg.IsMatch(FirstName) <> True) Then
                        Form.lbl_Status.Text = "Firstname must be letters only."
                        ErrorFlag = False
                        Form.lbl_Status.ForeColor = Color.Red
                    Else
                        If (namesReg.IsMatch(LastName) <> True) Then
                            Form.lbl_Status.Text = "Lastname must be letters only."
                            ErrorFlag = False
                            Form.lbl_Status.ForeColor = Color.Red
                        End If
                    End If
                End If
            End If
        End If

        Return ErrorFlag
    End Function



End Module
