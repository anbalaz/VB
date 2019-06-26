<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCounter
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
        Me.cmdEvaluate = New System.Windows.Forms.Button()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.lstLetters = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdEvaluate
        '
        Me.cmdEvaluate.Location = New System.Drawing.Point(12, 412)
        Me.cmdEvaluate.Name = "cmdEvaluate"
        Me.cmdEvaluate.Size = New System.Drawing.Size(75, 23)
        Me.cmdEvaluate.TabIndex = 3
        Me.cmdEvaluate.Text = "Evaluate"
        Me.cmdEvaluate.UseVisualStyleBackColor = True
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(12, 12)
        Me.txtText.MaxLength = 1000000
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(366, 394)
        Me.txtText.TabIndex = 0
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(384, 12)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(213, 394)
        Me.lstWords.TabIndex = 1
        '
        'lstLetters
        '
        Me.lstLetters.FormattingEnabled = True
        Me.lstLetters.Location = New System.Drawing.Point(603, 12)
        Me.lstLetters.Name = "lstLetters"
        Me.lstLetters.Size = New System.Drawing.Size(149, 394)
        Me.lstLetters.TabIndex = 2
        '
        'frmCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 441)
        Me.Controls.Add(Me.lstLetters)
        Me.Controls.Add(Me.lstWords)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.cmdEvaluate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCounter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdEvaluate As Button
    Friend WithEvents txtText As TextBox
    Friend WithEvents lstWords As ListBox
    Friend WithEvents lstLetters As ListBox
End Class
