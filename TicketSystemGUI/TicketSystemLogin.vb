Public Class TicketSystemLogin
    'Login
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userNameDropDown.SelectedIndexChanged

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check Database against username and password input.
        ' If correct, and user is a USER, then go to createTicket
        ' Else If correct and user is TECH, then go to viewTickets
        ' Else show dialogue box message
        '
        '       If 
        '           Dim createTicket As TicketSystemCreate
        '           createTicket = New TicketSystemCreate()
        '           createTicket.Show()
        '           Me.Hide()
        '       ElseIf
        '           Dim viewTickets As TicketSystemView
        '           viewTickets = New TicketSystemView
        '           viewTickets.Show()
        '           Me.Hide()
        '       Else
        '           MessageBox.Show("Wrong username or password. PLease try again.")
        '       End If
    End Sub

    'Clears password
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtbPassword.Clear()
    End Sub
End Class
