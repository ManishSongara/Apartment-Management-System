<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tenant_Login
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
        Me.NewRegistration = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.TenantID = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewRegistration
        '
        Me.NewRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRegistration.Location = New System.Drawing.Point(864, 360)
        Me.NewRegistration.Name = "NewRegistration"
        Me.NewRegistration.Size = New System.Drawing.Size(263, 58)
        Me.NewRegistration.TabIndex = 4
        Me.NewRegistration.Text = "New Registration"
        Me.NewRegistration.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(858, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tenant Login"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(706, 219)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(98, 25)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        '
        'TenantID
        '
        Me.TenantID.AutoSize = True
        Me.TenantID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenantID.Location = New System.Drawing.Point(706, 155)
        Me.TenantID.Name = "TenantID"
        Me.TenantID.Size = New System.Drawing.Size(98, 25)
        Me.TenantID.TabIndex = 0
        Me.TenantID.Text = "Tenant ID"
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(1012, 288)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(115, 36)
        Me.Reset.TabIndex = 3
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(864, 219)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(263, 42)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(864, 155)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 41)
        Me.TextBox1.TabIndex = 0
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(864, 288)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(108, 36)
        Me.Login.TabIndex = 2
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Tenant_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 769)
        Me.Controls.Add(Me.NewRegistration)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.TenantID)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Login)
        Me.Name = "Tenant_Login"
        Me.Text = "Tenant_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewRegistration As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Password As Label
    Friend WithEvents TenantID As Label
    Friend WithEvents Reset As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Login As Button
End Class
