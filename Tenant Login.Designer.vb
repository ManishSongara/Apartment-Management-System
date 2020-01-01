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
        Me.Password2 = New System.Windows.Forms.Label()
        Me.TenantID = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.tenantid1 = New System.Windows.Forms.TextBox()
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
        'Password2
        '
        Me.Password2.AutoSize = True
        Me.Password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password2.Location = New System.Drawing.Point(706, 219)
        Me.Password2.Name = "Password2"
        Me.Password2.Size = New System.Drawing.Size(98, 25)
        Me.Password2.TabIndex = 2
        Me.Password2.Text = "Password"
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
        'password1
        '
        Me.password1.Location = New System.Drawing.Point(864, 219)
        Me.password1.Multiline = True
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(263, 42)
        Me.password1.TabIndex = 1
        '
        'tenantid1
        '
        Me.tenantid1.Location = New System.Drawing.Point(864, 155)
        Me.tenantid1.Multiline = True
        Me.tenantid1.Name = "tenantid1"
        Me.tenantid1.Size = New System.Drawing.Size(263, 41)
        Me.tenantid1.TabIndex = 0
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
        Me.Controls.Add(Me.Password2)
        Me.Controls.Add(Me.TenantID)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.password1)
        Me.Controls.Add(Me.tenantid1)
        Me.Controls.Add(Me.Login)
        Me.Name = "Tenant_Login"
        Me.Text = "Tenant_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewRegistration As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Password2 As Label
    Friend WithEvents TenantID As Label
    Friend WithEvents Reset As Button
    Friend WithEvents password1 As TextBox
    Friend WithEvents tenantid1 As TextBox
    Friend WithEvents Login As Button
End Class
