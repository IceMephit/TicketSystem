Imports System.Data.SqlClient

Public Class TicketSystemCreate
        Dim rbTier As RadioButton
        Private Sub CreateLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim sqlConn As SqlConnection
            Dim sqlCMD As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim dataTable As DataTable
            sqlConn = New SqlConnection()
            sqlConn.ConnectionString = "Data Source=SERVER\\SQL;Initial Catalog=COMPUTERS;Integrated Security=True"
            sqlConn.Open()
        sqlCMD = New SqlCommand("'tier='" + rbTier.Checked + "'description='" + txtDescIssue.Text, sqlConn)
        sqlDataAdapter = New SqlDataAdapter(sqlCMD)
        dataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
        End Sub

        Public Sub InitializeRadioButtons()
            Tier1 = New System.Windows.Forms.RadioButton()
            Tier2 = New System.Windows.Forms.RadioButton()
            Tier3 = New System.Windows.Forms.RadioButton()
        End Sub

        Private Sub T3RBSelected(sender As Object, e As EventArgs) Handles Tier3.CheckedChanged
        If txtDescIssue.TextChanged Then
            rbTier.Checked = Tier3
            DescriptionBox()
        Else MessageBox.Show("Please select a Tier.")
        End If
        End Sub

        Private Sub T2RBSelected(sender As Object, e As EventArgs) Handles Tier2.CheckedChanged
        If txtDescIssue.TextChanged Then
            rbTier.Checked = Tier2
            DescriptionBox()
        Else MessageBox.Show("Please select a Tier.")
        End If
    End Sub

        Private Sub T1RBSelected(sender As Object, e As EventArgs) Handles Tier1.CheckedChanged
        If txtDescIssue.TextChanged Then
            rbTier.Checked = Tier1
            DescriptionBox()
        Else MessageBox.Show("Please select a Tier.")
        End If
    End Sub

    Private Sub DescriptionBox(sender As Object, e As EventArgs) Handles txtDescIssue.TextChanged, txtDescIssue.MultilineChanged

    End Sub
End Class