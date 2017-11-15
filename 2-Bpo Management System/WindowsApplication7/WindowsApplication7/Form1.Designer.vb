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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(267, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(292, 33)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Bpo Employee login"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Clarendon Blk BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Login"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(-2, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(860, 321)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(232, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(354, 189)
        Me.Panel4.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(131, 140)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Login"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(198, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(198, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Password :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Username :"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(309, 267)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 31)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "New emp? Register"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 457)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
