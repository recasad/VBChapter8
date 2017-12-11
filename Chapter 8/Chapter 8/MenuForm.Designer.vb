<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.btnTutorial1 = New System.Windows.Forms.Button()
        Me.btnTutorial2 = New System.Windows.Forms.Button()
        Me.btnTutorial6 = New System.Windows.Forms.Button()
        Me.btnTutorial10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTutorial1
        '
        Me.btnTutorial1.Location = New System.Drawing.Point(85, 12)
        Me.btnTutorial1.Name = "btnTutorial1"
        Me.btnTutorial1.Size = New System.Drawing.Size(79, 34)
        Me.btnTutorial1.TabIndex = 0
        Me.btnTutorial1.Text = "Tutorial 1"
        Me.btnTutorial1.UseVisualStyleBackColor = True
        '
        'btnTutorial2
        '
        Me.btnTutorial2.Location = New System.Drawing.Point(85, 52)
        Me.btnTutorial2.Name = "btnTutorial2"
        Me.btnTutorial2.Size = New System.Drawing.Size(79, 34)
        Me.btnTutorial2.TabIndex = 1
        Me.btnTutorial2.Text = "Tutorial 2"
        Me.btnTutorial2.UseVisualStyleBackColor = True
        '
        'btnTutorial6
        '
        Me.btnTutorial6.Location = New System.Drawing.Point(85, 92)
        Me.btnTutorial6.Name = "btnTutorial6"
        Me.btnTutorial6.Size = New System.Drawing.Size(79, 34)
        Me.btnTutorial6.TabIndex = 2
        Me.btnTutorial6.Text = "Tutorial 6"
        Me.btnTutorial6.UseVisualStyleBackColor = True
        '
        'btnTutorial10
        '
        Me.btnTutorial10.Location = New System.Drawing.Point(85, 132)
        Me.btnTutorial10.Name = "btnTutorial10"
        Me.btnTutorial10.Size = New System.Drawing.Size(79, 34)
        Me.btnTutorial10.TabIndex = 3
        Me.btnTutorial10.Text = "Tutorial 10"
        Me.btnTutorial10.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 182)
        Me.Controls.Add(Me.btnTutorial10)
        Me.Controls.Add(Me.btnTutorial6)
        Me.Controls.Add(Me.btnTutorial2)
        Me.Controls.Add(Me.btnTutorial1)
        Me.Name = "MenuForm"
        Me.Text = "Chapter 8 Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTutorial1 As System.Windows.Forms.Button
    Friend WithEvents btnTutorial2 As System.Windows.Forms.Button
    Friend WithEvents btnTutorial6 As System.Windows.Forms.Button
    Friend WithEvents btnTutorial10 As System.Windows.Forms.Button

End Class
