







Public Class Form1
    Dim A As Double = 0
    Dim Ex As Double = 0
    Dim AP As Double
    Dim EP As Double
    Dim Total As String
    Private Sub BTNCalculate_Click(sender As Object, e As EventArgs) Handles BTNCalculate.Click

        A = TXTAssignmentInput.Text
        Ex = TXTExamInput.Text
        AP = (A * 0.4)
        EP = (Ex * 0.6)
        Total = (AP + EP) & "%"


        If (A And Ex <= 100) Or (A And Ex >= 0) Then
            LBLOutputGrade.Text = Total


        Else
            LBLOutputGrade.Text = "The Submitted Mark Is Less Than 0 or More Than 100"


        End If
        'change something
        'change something else

    End Sub
End Class
