<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAnimals = New System.Windows.Forms.ListBox()
        Me.cmdOrderByTime = New System.Windows.Forms.Button()
        Me.cmbKind = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.gbxNewAnimal = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxAnimals = New System.Windows.Forms.GroupBox()
        Me.cmdOrderByLegs = New System.Windows.Forms.Button()
        Me.cmdTalk = New System.Windows.Forms.Button()
        Me.cmdNewAnimal = New System.Windows.Forms.Button()
        Me.gbxNewAnimal.SuspendLayout()
        Me.gbxAnimals.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'lstAnimals
        '
        Me.lstAnimals.FormattingEnabled = True
        Me.lstAnimals.Location = New System.Drawing.Point(6, 19)
        Me.lstAnimals.Name = "lstAnimals"
        Me.lstAnimals.Size = New System.Drawing.Size(120, 212)
        Me.lstAnimals.TabIndex = 0
        '
        'cmdOrderByTime
        '
        Me.cmdOrderByTime.Location = New System.Drawing.Point(132, 19)
        Me.cmdOrderByTime.Name = "cmdOrderByTime"
        Me.cmdOrderByTime.Size = New System.Drawing.Size(115, 23)
        Me.cmdOrderByTime.TabIndex = 1
        Me.cmdOrderByTime.Text = "Order by time added"
        Me.cmdOrderByTime.UseVisualStyleBackColor = True
        '
        'cmbKind
        '
        Me.cmbKind.FormattingEnabled = True
        Me.cmbKind.Items.AddRange(New Object() {"Snake", "Parrot", "Dog"})
        Me.cmbKind.Location = New System.Drawing.Point(50, 45)
        Me.cmbKind.Name = "cmbKind"
        Me.cmbKind.Size = New System.Drawing.Size(109, 21)
        Me.cmbKind.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(50, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(109, 20)
        Me.txtName.TabIndex = 1
        '
        'gbxNewAnimal
        '
        Me.gbxNewAnimal.Controls.Add(Me.cmdNewAnimal)
        Me.gbxNewAnimal.Controls.Add(Me.Label2)
        Me.gbxNewAnimal.Controls.Add(Me.Label1)
        Me.gbxNewAnimal.Controls.Add(Me.txtName)
        Me.gbxNewAnimal.Controls.Add(Me.cmbKind)
        Me.gbxNewAnimal.Location = New System.Drawing.Point(12, 12)
        Me.gbxNewAnimal.Name = "gbxNewAnimal"
        Me.gbxNewAnimal.Size = New System.Drawing.Size(165, 105)
        Me.gbxNewAnimal.TabIndex = 0
        Me.gbxNewAnimal.TabStop = False
        Me.gbxNewAnimal.Text = "New animal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kind:"
        '
        'gbxAnimals
        '
        Me.gbxAnimals.Controls.Add(Me.cmdTalk)
        Me.gbxAnimals.Controls.Add(Me.cmdOrderByLegs)
        Me.gbxAnimals.Controls.Add(Me.lstAnimals)
        Me.gbxAnimals.Controls.Add(Me.cmdOrderByTime)
        Me.gbxAnimals.Location = New System.Drawing.Point(183, 12)
        Me.gbxAnimals.Name = "gbxAnimals"
        Me.gbxAnimals.Size = New System.Drawing.Size(255, 237)
        Me.gbxAnimals.TabIndex = 1
        Me.gbxAnimals.TabStop = False
        Me.gbxAnimals.Text = "Animal"
        '
        'cmdOrderByLegs
        '
        Me.cmdOrderByLegs.Location = New System.Drawing.Point(132, 48)
        Me.cmdOrderByLegs.Name = "cmdOrderByLegs"
        Me.cmdOrderByLegs.Size = New System.Drawing.Size(115, 23)
        Me.cmdOrderByLegs.TabIndex = 2
        Me.cmdOrderByLegs.Text = "Order by leg count"
        Me.cmdOrderByLegs.UseVisualStyleBackColor = True
        '
        'cmdTalk
        '
        Me.cmdTalk.Location = New System.Drawing.Point(132, 77)
        Me.cmdTalk.Name = "cmdTalk"
        Me.cmdTalk.Size = New System.Drawing.Size(115, 23)
        Me.cmdTalk.TabIndex = 3
        Me.cmdTalk.Text = "Talk to animal"
        Me.cmdTalk.UseVisualStyleBackColor = True
        '
        'cmdNewAnimal
        '
        Me.cmdNewAnimal.Location = New System.Drawing.Point(50, 72)
        Me.cmdNewAnimal.Name = "cmdNewAnimal"
        Me.cmdNewAnimal.Size = New System.Drawing.Size(109, 23)
        Me.cmdNewAnimal.TabIndex = 4
        Me.cmdNewAnimal.Text = "Add"
        Me.cmdNewAnimal.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 261)
        Me.Controls.Add(Me.gbxAnimals)
        Me.Controls.Add(Me.gbxNewAnimal)
        Me.Name = "frmMain"
        Me.Text = "Zverimex"
        Me.gbxNewAnimal.ResumeLayout(False)
        Me.gbxNewAnimal.PerformLayout()
        Me.gbxAnimals.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstAnimals As ListBox
    Friend WithEvents cmdOrderByTime As Button
    Friend WithEvents cmbKind As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents gbxNewAnimal As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbxAnimals As GroupBox
    Friend WithEvents cmdTalk As Button
    Friend WithEvents cmdOrderByLegs As Button
    Friend WithEvents cmdNewAnimal As Button
End Class
