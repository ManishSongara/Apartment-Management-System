<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class first_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(first_page))
        Me.AdminLogin = New System.Windows.Forms.Button()
        Me.TenantLogin = New System.Windows.Forms.Button()
        Me.ApartmentDetails = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'AdminLogin
        '
        Me.AdminLogin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AdminLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLogin.Location = New System.Drawing.Point(652, 121)
        Me.AdminLogin.Name = "AdminLogin"
        Me.AdminLogin.Size = New System.Drawing.Size(168, 50)
        Me.AdminLogin.TabIndex = 0
        Me.AdminLogin.Text = "Admin Login"
        Me.AdminLogin.UseVisualStyleBackColor = False
        '
        'TenantLogin
        '
        Me.TenantLogin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TenantLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenantLogin.Location = New System.Drawing.Point(652, 222)
        Me.TenantLogin.Name = "TenantLogin"
        Me.TenantLogin.Size = New System.Drawing.Size(168, 47)
        Me.TenantLogin.TabIndex = 1
        Me.TenantLogin.Text = "Tenant Login"
        Me.TenantLogin.UseVisualStyleBackColor = False
        '
        'ApartmentDetails
        '
        Me.ApartmentDetails.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ApartmentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApartmentDetails.Location = New System.Drawing.Point(652, 331)
        Me.ApartmentDetails.Name = "ApartmentDetails"
        Me.ApartmentDetails.Size = New System.Drawing.Size(168, 51)
        Me.ApartmentDetails.TabIndex = 2
        Me.ApartmentDetails.Text = "Apartment Details"
        Me.ApartmentDetails.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 501)
        Me.Panel1.TabIndex = 3
        '
        'first_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(893, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ApartmentDetails)
        Me.Controls.Add(Me.TenantLogin)
        Me.Controls.Add(Me.AdminLogin)
        Me.Name = "first_page"
        Me.Text = "first_page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminLogin As Button
    Friend WithEvents TenantLogin As Button
    Friend WithEvents ApartmentDetails As Button
    Friend WithEvents Panel1 As Panel
End Class
