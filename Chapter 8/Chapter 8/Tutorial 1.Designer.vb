<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorial_1
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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblFifth = New System.Windows.Forms.Label()
        Me.lblFourth = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lottery Numbers"
        '
        'lblFirst
        '
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirst.Location = New System.Drawing.Point(12, 36)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(50, 50)
        Me.lblFirst.TabIndex = 1
        '
        'lblSecond
        '
        Me.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecond.Location = New System.Drawing.Point(68, 36)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(50, 50)
        Me.lblSecond.TabIndex = 2
        '
        'lblThird
        '
        Me.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThird.Location = New System.Drawing.Point(124, 36)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(50, 50)
        Me.lblThird.TabIndex = 3
        '
        'lblFifth
        '
        Me.lblFifth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFifth.Location = New System.Drawing.Point(236, 36)
        Me.lblFifth.Name = "lblFifth"
        Me.lblFifth.Size = New System.Drawing.Size(50, 50)
        Me.lblFifth.TabIndex = 4
        '
        'lblFourth
        '
        Me.lblFourth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFourth.Location = New System.Drawing.Point(180, 36)
        Me.lblFourth.Name = "lblFourth"
        Me.lblFourth.Size = New System.Drawing.Size(50, 50)
        Me.lblFourth.TabIndex = 5
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(43, 109)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 40)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(180, 109)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Tutorial_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 158)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblFourth)
        Me.Controls.Add(Me.lblFifth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tutorial_1"
        Me.Text = "Tutorial 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents lblFifth As System.Windows.Forms.Label
    Friend WithEvents lblFourth As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
