Imports System.Data.SqlClient

Public Class TicketSystemCreate
    Private selectedRB As RadioButton
    Private getSelectedRB As Button

    Private Sub CreateLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlConn As SqlConnection
        sqlConn = New SqlConnection()
        sqlConn.ConnectionString = "Data Source=SERVER\\SQL;Initial Catalog=COMPUTERS;Integrated Security=True"
        sqlConn.Open()
    End Sub

    Public Sub InitializeRadioButtons()
        Tier1 = New System.Windows.Forms.RadioButton()
        Tier2 = New System.Windows.Forms.RadioButton()
        Tier3 = New System.Windows.Forms.RadioButton()
        getSelectedRB = New System.Windows.Forms.Button()
        getSelectedRB.Click += New EventHandler(getSelectedRB_Click)
    End Sub

    Private Sub RB_CheckedChanged(object sender, EventArgs e)
        If [object] Is Nothing Then
            Throw New ArgumentNullException(NameOf([object]))
        End If

        radioBtn = sender As RadioButton
        If (radioBtn Is null) Then
            MessageBox.Show("Please select a tier. Use Tier 1 if unsure.")
            Return
        ElseIf (radioRtn.Checked) Then
            selectedRadioBtn = radioBtn
            'if t1
            ' DB TICKET tier = 1
            'else if t2
            ' DB TICKET tier = 2
            'else if t3
            ' DB TICKET tier = 3
        End If
    End Sub

    Public Sub getSelectedRB_Click(object sender, EventArgs e)
        MessageBox.Show("Radio Button selected.")

    '    Private Sub RbT3_Click(sender As Object, e As EventArgs) Handles Tier3.Click
    '    Throw New NotImplementedException()
    '    End Sub
End Class