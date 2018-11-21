Imports System.Data.SqlClient

Public Class TicketSystemLogin
    'Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click, txtbUserName.TextChanged, txtbPassword.TextChanged
        Dim sqlConn As SqlConnection
        Dim sqlCMD As SqlCommand
        Dim sqlDataAdapter As SqlDataAdapter
        Dim dataTable As DataTable
        Dim user_id As String
        Dim password As String
        sqlConn = New SqlConnection()
        sqlConn.ConnectionString = "Data Source=SERVER\\SQL;Initial Catalog=USERS;Integrated Security=True"
        sqlConn.Open()
        user_id = txtbUserName.Text
        password = txtbPassword.Text
        sqlCMD = New SqlCommand("'user_id='" + txtbUserName.Text + "'password='" + txtbPassword.Text, sqlConn);   
        sqlDataAdapter = New SqlDataAdapter(sqlCMD)
        dataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)

        ' if user, elseif tech
        If (dataTable.Rows.Count > 0) Then
            Dim createTicket As TicketSystemCreate
            createTicket = New TicketSystemCreate()
            createTicket.Show()
            Me.Hide()
        ElseIf () Then
            Dim viewTickets As TicketSystemView
            viewTickets = New TicketSystemView
            viewTickets.Show()
            Me.Hide()
        Else MessageBox.Show("Invalid Login please check username and password and try again.")
        End If
        sqlConn.Close()
    End Sub

    'Clears password
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtbPassword.Clear()
        txtbUserName.Clear()
    End Sub
End Class