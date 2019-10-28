<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LBLTitle = New System.Windows.Forms.Label()
        Me.LBLAssignment = New System.Windows.Forms.Label()
        Me.LBLExam = New System.Windows.Forms.Label()
        Me.TXTAssignmentInput = New System.Windows.Forms.TextBox()
        Me.TXTExamInput = New System.Windows.Forms.TextBox()
        Me.LBLOutputGrade = New System.Windows.Forms.Label()
        Me.BTNCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = True
        Me.LBLTitle.Location = New System.Drawing.Point(69, 9)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(64, 13)
        Me.LBLTitle.TabIndex = 0
        Me.LBLTitle.Text = "Grade Book"
        '
        'LBLAssignment
        '
        Me.LBLAssignment.AutoSize = True
        Me.LBLAssignment.Location = New System.Drawing.Point(69, 89)
        Me.LBLAssignment.Name = "LBLAssignment"
        Me.LBLAssignment.Size = New System.Drawing.Size(116, 13)
        Me.LBLAssignment.TabIndex = 1
        Me.LBLAssignment.Text = "Enter Assignment Mark"
        '
        'LBLExam
        '
        Me.LBLExam.AutoSize = True
        Me.LBLExam.Location = New System.Drawing.Point(69, 117)
        Me.LBLExam.Name = "LBLExam"
        Me.LBLExam.Size = New System.Drawing.Size(88, 13)
        Me.LBLExam.TabIndex = 2
        Me.LBLExam.Text = "Enter Exam Mark"
        '
        'TXTAssignmentInput
        '
        Me.TXTAssignmentInput.Location = New System.Drawing.Point(191, 86)
        Me.TXTAssignmentInput.Name = "TXTAssignmentInput"
        Me.TXTAssignmentInput.Size = New System.Drawing.Size(100, 20)
        Me.TXTAssignmentInput.TabIndex = 3
        '
        'TXTExamInput
        '
        Me.TXTExamInput.Location = New System.Drawing.Point(191, 117)
        Me.TXTExamInput.Name = "TXTExamInput"
        Me.TXTExamInput.Size = New System.Drawing.Size(100, 20)
        Me.TXTExamInput.TabIndex = 4
        '
        'LBLOutputGrade
        '
        Me.LBLOutputGrade.AutoSize = True
        Me.LBLOutputGrade.Location = New System.Drawing.Point(188, 177)
        Me.LBLOutputGrade.Name = "LBLOutputGrade"
        Me.LBLOutputGrade.Size = New System.Drawing.Size(39, 13)
        Me.LBLOutputGrade.TabIndex = 5
        Me.LBLOutputGrade.Text = "Label4"
        '
        'BTNCalculate
        '
        Me.BTNCalculate.Location = New System.Drawing.Point(191, 144)
        Me.BTNCalculate.Name = "BTNCalculate"
        Me.BTNCalculate.Size = New System.Drawing.Size(100, 23)
        Me.BTNCalculate.TabIndex = 6
        Me.BTNCalculate.Text = "Submit"
        Me.BTNCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNCalculate)
        Me.Controls.Add(Me.LBLOutputGrade)
        Me.Controls.Add(Me.TXTExamInput)
        Me.Controls.Add(Me.TXTAssignmentInput)
        Me.Controls.Add(Me.LBLExam)
        Me.Controls.Add(Me.LBLAssignment)
        Me.Controls.Add(Me.LBLTitle)
        Me.Name = "Form1"
        Me.Text = "Grade Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLTitle As Label
    Friend WithEvents LBLAssignment As Label
    Friend WithEvents LBLExam As Label
    Friend WithEvents TXTAssignmentInput As TextBox
    Friend WithEvents TXTExamInput As TextBox
    Friend WithEvents LBLOutputGrade As Label
    Friend WithEvents BTNCalculate As Button
End Class
