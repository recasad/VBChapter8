<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorial_10
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
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.Location = New System.Drawing.Point(179, 12)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(217, 160)
        Me.lstFriends.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(252, 178)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Show All"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(60, 94)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(29, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(136, 20)
        Me.txtName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter a friend's name:"
        '
        'Tutorial_10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 213)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lstFriends)
        Me.Name = "Tutorial_10"
        Me.Text = "Tutorial_10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFriends As System.Windows.Forms.ListBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
