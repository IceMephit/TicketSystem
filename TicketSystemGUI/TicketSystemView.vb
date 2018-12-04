Imports System.Data.SqlClient

Public Class TicketSystemView
    Private Sub CreateLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlConn As SqlConnection
        sqlConn = New SqlConnection()
        sqlConn.ConnectionString = "Data Source=SERVER\\SQL;Initial Catalog=TICKET;Integrated Security=True"
        sqlConn.Open()
    End Sub

    Private Sub ViewLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ' table: ticket
    End Sub

    Private Sub AllOpenChecked(sender As Object, e As EventArgs) Handles rbOpen.Click
        ' table: ticket
        ' completed: FALSE
    End Sub

    Private Sub T1OpenChecked(sender As Object, e As EventArgs) Handles rbT1O.CheckedChanged
        ' table: ticket
        ' tier
    End Sub

    Private Sub T2OpenChecked(sender As Object, e As EventArgs) Handles rbT2O.CheckedChanged
        ' table: ticket
        ' tier
    End Sub

    Private Sub T3OpenChecked(sender As Object, e As EventArgs) Handles rbT3O.CheckedChanged
        ' table: ticket
        ' tier
    End Sub

    Private Sub AllClosedChecked(sender As Object, e As EventArgs) Handles rbClosed.CheckedChanged
        ' table: ticket
        ' completed: TRUE
    End Sub
End Class