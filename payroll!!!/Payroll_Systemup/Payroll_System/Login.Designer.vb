﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserTxt = New System.Windows.Forms.TextBox()
        Me.PassTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'UserTxt
        '
        Me.UserTxt.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTxt.Location = New System.Drawing.Point(203, 71)
        Me.UserTxt.Name = "UserTxt"
        Me.UserTxt.Size = New System.Drawing.Size(114, 24)
        Me.UserTxt.TabIndex = 1
        '
        'PassTxt
        '
        Me.PassTxt.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTxt.Location = New System.Drawing.Point(203, 114)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.Size = New System.Drawing.Size(114, 23)
        Me.PassTxt.TabIndex = 3
        Me.PassTxt.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(130, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Log in"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Leelawadee", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(137, 154)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 19)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.SteelBlue
        Me.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Loginbtn.Font = New System.Drawing.Font("Leelawadee", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.Location = New System.Drawing.Point(109, 191)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(69, 33)
        Me.Loginbtn.TabIndex = 6
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = False
        '
        'Cancelbtn
        '
        Me.Cancelbtn.BackColor = System.Drawing.Color.SteelBlue
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancelbtn.Font = New System.Drawing.Font("Leelawadee", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelbtn.Location = New System.Drawing.Point(203, 191)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(69, 33)
        Me.Cancelbtn.TabIndex = 7
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = Global.PayrollSystem.My.Resources.Resources.call_center
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(391, 255)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Loginbtn)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PassTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserTxt)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll System Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserTxt As System.Windows.Forms.TextBox
    Friend WithEvents PassTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Loginbtn As System.Windows.Forms.Button
    Friend WithEvents Cancelbtn As System.Windows.Forms.Button

End Class
