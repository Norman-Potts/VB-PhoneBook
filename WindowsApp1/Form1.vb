Imports System.Text.RegularExpressions

Public Class Form

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateListView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        'Create Button Click.
        CreateRecord()
        PopulateListView() 'Loads Database into Listview.
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Retreive.Click
        'Retreive Button 
        RetreiveRecord()
    End Sub


    Private Sub MainListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainListView.SelectedIndexChanged
        btn_Retreive.Enabled = True 'Allow Retreive Button
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        'Update Button
        UpdateRecord()
        PopulateListView() 'Loads database into Listview
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        'Delete Button
        DeleteRecord()
        PopulateListView()   'Loads database into Listview.
        'Change accessibility of buttons and textboxes to prevent unwanted functions.
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        btn_Create.Enabled = True
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        'Clear Button 
        ClearRecords()
    End Sub

End Class
