'---------------------------------------------------------------------------------------------------------------
'Programer: Brandon Redman
'Program Name: GradeBook Program
'Program Date Created: October 22 2019
'Program Date Modified: October 24 2019
'Program Version: 1.1.0.1
'Program Description: This program calculates the total grade percentage based on assignment grade and exam grade
'
'
'------------------------------------------------------------------------------------------------------------------
Public Class Form1
    Dim Assignment As Double = 0 'Assignment grade
    Dim Exam As Double = 0 'Exam grade
    Dim APercentage As Double 'Assignment prercentage
    Dim EPercentage As Double 'Exam percentage
    Dim Total As Double ' Total grade percentage
    Dim sTotal As String 'Total grade percentage as string
    Private Sub BTNCalculate_Click(sender As Object, e As EventArgs) Handles BTNCalculate.Click



        If Not IsNumeric(TXTAssignmentInput.Text) Or String.IsNullOrEmpty(TXTAssignmentInput.Text) Then 'Non numbers will not be accepted...program will not crash

            MsgBox("Invalid Assigment grade...", MsgBoxStyle.Critical) 'Message displayed if what is in textbox is not a number
            LBLOutputGrade.Text = "PERCENTAGE COULD NOT BE CALCULATED!"

        ElseIf Not IsNumeric(TXTExamInput.Text) Or String.IsNullOrEmpty(TXTExamInput.Text) Then 'Non numbers will not be accepted...program will not crash

            MsgBox("Invalid Exam grade...", MsgBoxStyle.Critical) 'Message displayed if what is in textbox is not a number
            LBLOutputGrade.Text = "PERCENTAGE COULD NOT BE CALCULATED!"

        Else 'Only numbers will be accepted

            Assignment = TXTAssignmentInput.Text 'Sets the value of Assignment
            Exam = TXTExamInput.Text 'Sets the value of Exam



            If Not (Assignment >= 0 And Assignment <= 100) Then 'Numbers not between 0 and 100 will not be accepted or null/empty values

                MsgBox("Assignment Grade is not between 0 and 100 ", MsgBoxStyle.Critical) 'Messaged displayed if Assignment grade value is not between 0 and 100 or null/empty value
                LBLOutputGrade.Text = "PERCENTAGE COULD NOT BE CALCULATED!" 'Output label displays secondary message

            ElseIf Not (Exam >= 0 And Exam <= 100) Then 'Numbers not between 0 and 100 will not be accepted or null/empty values

                MsgBox("Exam Grade is not between 0 and 100 ", MsgBoxStyle.Critical) 'Messaged displayed if Exam grade value is not between 0 and 100 or null/empty value
                LBLOutputGrade.Text = "PERCENTAGE COULD NOT BE CALCULATED!" 'Output label displays secondary message

            Else 'Only numbers between 0 and 100 will be accepted

                APercentage = (Assignment * 0.4) 'Calculates assignment percentage
                EPercentage = (Exam * 0.6) 'Calculates exam percentage
                Total = APercentage + EPercentage 'Adds both percentages to give total
                'sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" 'Converts numeric value to equivalent string representation
                'LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total



                If Total >= 94 Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is A" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf (Total <= 93 And Total >= 90) Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is A-" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf (Total <= 89 And Total >= 87) Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is B+" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf (Total <= 86 And Total >= 84) Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is B" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf (Total <= 83 And Total >= 80) Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is B-" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf (Total <= 79 And Total >= 77) Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is C+" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf (Total <= 76 And Total >= 74) Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is C" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf (Total <= 73 And Total >= 70) Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is C-" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf (Total <= 69 And Total >= 60) Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is D" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                ElseIf Total <= 59 Then

                    sTotal = "Your Total Grade Percentage is " & Total.ToString & "%" & " Your Total Letter Grade is F" 'Converts numeric value to equivalent string representation
                    LBLOutputGrade.Text = sTotal 'Sets value of label output grade to string equivalent of total

                End If
            End If
        End If



    End Sub
End Class
