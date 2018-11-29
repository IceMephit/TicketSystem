Imports System.Data.SqlClient

Public Class TicketSystemCreate
    Dim rbTier As RadioButton
    Private Sub CreateLoad(sender As Object, e As EventArgs) Handles MyBase.Load, txtDescIssue.TextChanged, Tier3.CheckedChanged, Tier2.CheckedChanged, Tier1.CheckedChanged
        Dim sqlConn As SqlConnection
        Dim sqlCMD As SqlCommand
        Dim sqlDataAdapter As SqlDataAdapter
        Dim dataTable As DataTable
        sqlConn = New SqlConnection()
        sqlConn.ConnectionString = "Data Source=SERVER\\SQL;Initial Catalog=COMPUTERS;Integrated Security=True"
        sqlConn.Open()
        sqlCMD = New SqlCommand("'tier='" + rbTier.Checked + "'description='" + txtDescIssue.Text, sqlConn);   
        sqlDataAdapter = New SqlDataAdapter(sqlCMD)
        dataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
    End Sub

    Public Sub InitializeRadioButtons()
        Tier1 = New System.Windows.Forms.RadioButton()
        Tier2 = New System.Windows.Forms.RadioButton()
        Tier3 = New System.Windows.Forms.RadioButton()
    End Sub

    Private Sub RB_CheckedChanged(sender As Object, e As EventArgs)
        If (rbTier Is null) Then
            MessageBox.Show("Please select a tier. Use Tier 1 if unsure.")
            Return
        ElseIf (rbTier.Checked) Then
            If Tier1.CheckedChanged Is True Then
                ' Ticket is flagged as Tier 1 in DB
            ElseIf Tier2.CheckedChanged Is True Then
                ' Ticket is flagged as Tier 2 in DB
            ElseIf Tier3.CheckedChanged Is True Then
                ' Ticket is flagged as Tier 3 in DB
            Else
                MessageBox.Show("Please select a Tier.")
            End If
        End If
    End Sub
End Class