<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_PhoneNumber = New System.Windows.Forms.Label()
        Me.lbl_Firstname = New System.Windows.Forms.Label()
        Me.lbl_Lastname = New System.Windows.Forms.Label()
        Me.txtBx_Lastname = New System.Windows.Forms.TextBox()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.btn_Create = New System.Windows.Forms.Button()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Retreive = New System.Windows.Forms.Button()
        Me.lbl_ValueID = New System.Windows.Forms.Label()
        Me.MainListView = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Firstname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lastname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Phone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.txtBx_PhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtBx_Email = New System.Windows.Forms.TextBox()
        Me.txtBx_Firstname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage your phone book"
        '
        'lbl_PhoneNumber
        '
        Me.lbl_PhoneNumber.AutoSize = True
        Me.lbl_PhoneNumber.Location = New System.Drawing.Point(367, 425)
        Me.lbl_PhoneNumber.Name = "lbl_PhoneNumber"
        Me.lbl_PhoneNumber.Size = New System.Drawing.Size(107, 17)
        Me.lbl_PhoneNumber.TabIndex = 2
        Me.lbl_PhoneNumber.Text = "Phone Number:"
        '
        'lbl_Firstname
        '
        Me.lbl_Firstname.AutoSize = True
        Me.lbl_Firstname.Location = New System.Drawing.Point(36, 430)
        Me.lbl_Firstname.Name = "lbl_Firstname"
        Me.lbl_Firstname.Size = New System.Drawing.Size(74, 17)
        Me.lbl_Firstname.TabIndex = 4
        Me.lbl_Firstname.Text = "Firstname:"
        '
        'lbl_Lastname
        '
        Me.lbl_Lastname.AutoSize = True
        Me.lbl_Lastname.Location = New System.Drawing.Point(198, 432)
        Me.lbl_Lastname.Name = "lbl_Lastname"
        Me.lbl_Lastname.Size = New System.Drawing.Size(74, 17)
        Me.lbl_Lastname.TabIndex = 5
        Me.lbl_Lastname.Text = "Lastname:"
        '
        'txtBx_Lastname
        '
        Me.txtBx_Lastname.Location = New System.Drawing.Point(201, 452)
        Me.txtBx_Lastname.Name = "txtBx_Lastname"
        Me.txtBx_Lastname.Size = New System.Drawing.Size(142, 22)
        Me.txtBx_Lastname.TabIndex = 6
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Location = New System.Drawing.Point(538, 432)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(46, 17)
        Me.lbl_Email.TabIndex = 9
        Me.lbl_Email.Text = "Email:"
        '
        'btn_Create
        '
        Me.btn_Create.Location = New System.Drawing.Point(358, 535)
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.Size = New System.Drawing.Size(75, 39)
        Me.btn_Create.TabIndex = 10
        Me.btn_Create.Text = "Create"
        Me.btn_Create.UseVisualStyleBackColor = True
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(36, 402)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(25, 17)
        Me.lbl_ID.TabIndex = 11
        Me.lbl_ID.Text = "ID:"
        '
        'btn_Delete
        '
        Me.btn_Delete.Enabled = False
        Me.btn_Delete.Location = New System.Drawing.Point(459, 535)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(75, 39)
        Me.btn_Delete.TabIndex = 13
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(562, 534)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 40)
        Me.btn_Clear.TabIndex = 14
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.Enabled = False
        Me.btn_Update.Location = New System.Drawing.Point(262, 534)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(75, 39)
        Me.btn_Update.TabIndex = 15
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'btn_Retreive
        '
        Me.btn_Retreive.Location = New System.Drawing.Point(160, 534)
        Me.btn_Retreive.Name = "btn_Retreive"
        Me.btn_Retreive.Size = New System.Drawing.Size(75, 39)
        Me.btn_Retreive.TabIndex = 16
        Me.btn_Retreive.Text = "Retreive"
        Me.btn_Retreive.UseVisualStyleBackColor = True
        '
        'lbl_ValueID
        '
        Me.lbl_ValueID.AutoSize = True
        Me.lbl_ValueID.Location = New System.Drawing.Point(68, 402)
        Me.lbl_ValueID.Name = "lbl_ValueID"
        Me.lbl_ValueID.Size = New System.Drawing.Size(0, 17)
        Me.lbl_ValueID.TabIndex = 18
        '
        'MainListView
        '
        Me.MainListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Firstname, Me.Lastname, Me.Phone, Me.Email})
        Me.MainListView.FullRowSelect = True
        Me.MainListView.GridLines = True
        Me.MainListView.Location = New System.Drawing.Point(31, 61)
        Me.MainListView.MultiSelect = False
        Me.MainListView.Name = "MainListView"
        Me.MainListView.Size = New System.Drawing.Size(726, 264)
        Me.MainListView.TabIndex = 15
        Me.MainListView.UseCompatibleStateImageBehavior = False
        Me.MainListView.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Firstname
        '
        Me.Firstname.Text = "Frirstname"
        Me.Firstname.Width = 100
        '
        'Lastname
        '
        Me.Lastname.Text = "Lastname"
        Me.Lastname.Width = 100
        '
        'Phone
        '
        Me.Phone.Text = "Phone"
        Me.Phone.Width = 100
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.Width = 200
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(201, 360)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(0, 17)
        Me.lbl_Status.TabIndex = 19
        '
        'txtBx_PhoneNumber
        '
        Me.txtBx_PhoneNumber.Location = New System.Drawing.Point(370, 452)
        Me.txtBx_PhoneNumber.Mask = "(999) 000-0000"
        Me.txtBx_PhoneNumber.Name = "txtBx_PhoneNumber"
        Me.txtBx_PhoneNumber.Size = New System.Drawing.Size(142, 22)
        Me.txtBx_PhoneNumber.TabIndex = 20
        '
        'txtBx_Email
        '
        Me.txtBx_Email.Location = New System.Drawing.Point(541, 452)
        Me.txtBx_Email.Name = "txtBx_Email"
        Me.txtBx_Email.Size = New System.Drawing.Size(218, 22)
        Me.txtBx_Email.TabIndex = 7
        '
        'txtBx_Firstname
        '
        Me.txtBx_Firstname.Location = New System.Drawing.Point(39, 452)
        Me.txtBx_Firstname.Name = "txtBx_Firstname"
        Me.txtBx_Firstname.Size = New System.Drawing.Size(142, 22)
        Me.txtBx_Firstname.TabIndex = 3
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 646)
        Me.Controls.Add(Me.txtBx_PhoneNumber)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.MainListView)
        Me.Controls.Add(Me.lbl_ValueID)
        Me.Controls.Add(Me.btn_Retreive)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.btn_Create)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.txtBx_Email)
        Me.Controls.Add(Me.txtBx_Lastname)
        Me.Controls.Add(Me.lbl_Lastname)
        Me.Controls.Add(Me.lbl_Firstname)
        Me.Controls.Add(Me.txtBx_Firstname)
        Me.Controls.Add(Me.lbl_PhoneNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form"
        Me.Text = "Phone Book "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_PhoneNumber As Label
    Friend WithEvents lbl_Firstname As Label
    Friend WithEvents lbl_Lastname As Label
    Friend WithEvents txtBx_Lastname As TextBox
    Friend WithEvents lbl_Email As Label
    Friend WithEvents btn_Create As Button
    Friend WithEvents lbl_ID As Label
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Retreive As Button
    Friend WithEvents lbl_ValueID As Label
    Friend WithEvents MainListView As ListView
    Friend WithEvents lbl_Status As Label
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Firstname As ColumnHeader
    Friend WithEvents Lastname As ColumnHeader
    Friend WithEvents Phone As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents txtBx_PhoneNumber As MaskedTextBox
    Friend WithEvents txtBx_Email As TextBox
    Friend WithEvents txtBx_Firstname As TextBox
End Class
