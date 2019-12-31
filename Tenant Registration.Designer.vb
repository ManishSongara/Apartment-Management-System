<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tenant_Registration
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
        Me.TenantName = New System.Windows.Forms.Label()
        Me.TenantID = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.Label()
        Me.Block = New System.Windows.Forms.Label()
        Me.FlatNmber = New System.Windows.Forms.Label()
        Me.FlatType = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox8 = New System.Windows.Forms.MaskedTextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TenantName
        '
        Me.TenantName.AutoSize = True
        Me.TenantName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenantName.Location = New System.Drawing.Point(93, 134)
        Me.TenantName.Name = "TenantName"
        Me.TenantName.Size = New System.Drawing.Size(109, 20)
        Me.TenantName.TabIndex = 0
        Me.TenantName.Text = "Tenant Name"
        '
        'TenantID
        '
        Me.TenantID.AutoSize = True
        Me.TenantID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenantID.Location = New System.Drawing.Point(93, 183)
        Me.TenantID.Name = "TenantID"
        Me.TenantID.Size = New System.Drawing.Size(82, 20)
        Me.TenantID.TabIndex = 1
        Me.TenantID.Text = "Tenant ID"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(94, 225)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(83, 20)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(94, 272)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(57, 20)
        Me.Email.TabIndex = 3
        Me.Email.Text = "E-mail"
        '
        'Phone
        '
        Me.Phone.AutoSize = True
        Me.Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.Location = New System.Drawing.Point(94, 313)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(56, 20)
        Me.Phone.TabIndex = 4
        Me.Phone.Text = "Phone"
        '
        'Block
        '
        Me.Block.AutoSize = True
        Me.Block.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Block.Location = New System.Drawing.Point(94, 359)
        Me.Block.Name = "Block"
        Me.Block.Size = New System.Drawing.Size(51, 20)
        Me.Block.TabIndex = 5
        Me.Block.Text = "Block"
        '
        'FlatNmber
        '
        Me.FlatNmber.AutoSize = True
        Me.FlatNmber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatNmber.Location = New System.Drawing.Point(94, 402)
        Me.FlatNmber.Name = "FlatNmber"
        Me.FlatNmber.Size = New System.Drawing.Size(92, 20)
        Me.FlatNmber.TabIndex = 6
        Me.FlatNmber.Text = "Flat Nmber"
        '
        'FlatType
        '
        Me.FlatType.AutoSize = True
        Me.FlatType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatType.Location = New System.Drawing.Point(94, 445)
        Me.FlatType.Name = "FlatType"
        Me.FlatType.Size = New System.Drawing.Size(78, 20)
        Me.FlatType.TabIndex = 7
        Me.FlatType.Text = "Flat Type"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(248, 134)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(157, 27)
        Me.MaskedTextBox1.TabIndex = 8
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(248, 183)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(157, 27)
        Me.MaskedTextBox2.TabIndex = 9
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(248, 225)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(157, 27)
        Me.MaskedTextBox3.TabIndex = 10
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(248, 272)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(157, 27)
        Me.MaskedTextBox4.TabIndex = 11
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox5.Location = New System.Drawing.Point(248, 313)
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(157, 27)
        Me.MaskedTextBox5.TabIndex = 12
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox6.Location = New System.Drawing.Point(248, 359)
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(157, 27)
        Me.MaskedTextBox6.TabIndex = 13
        '
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox7.Location = New System.Drawing.Point(248, 402)
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(157, 27)
        Me.MaskedTextBox7.TabIndex = 14
        '
        'MaskedTextBox8
        '
        Me.MaskedTextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox8.Location = New System.Drawing.Point(248, 445)
        Me.MaskedTextBox8.Name = "MaskedTextBox8"
        Me.MaskedTextBox8.Size = New System.Drawing.Size(157, 27)
        Me.MaskedTextBox8.TabIndex = 15
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(162, 526)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(119, 38)
        Me.Submit.TabIndex = 16
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(309, 526)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(119, 38)
        Me.Reset.TabIndex = 17
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Tenant_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 619)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.MaskedTextBox8)
        Me.Controls.Add(Me.MaskedTextBox7)
        Me.Controls.Add(Me.MaskedTextBox6)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.FlatType)
        Me.Controls.Add(Me.FlatNmber)
        Me.Controls.Add(Me.Block)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.TenantID)
        Me.Controls.Add(Me.TenantName)
        Me.Name = "Tenant_Registration"
        Me.Text = "Tenant_Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TenantName As Label
    Friend WithEvents TenantID As Label
    Friend WithEvents Password As Label
    Friend WithEvents Email As Label
    Friend WithEvents Phone As Label
    Friend WithEvents Block As Label
    Friend WithEvents FlatNmber As Label
    Friend WithEvents FlatType As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents MaskedTextBox7 As MaskedTextBox
    Friend WithEvents MaskedTextBox8 As MaskedTextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Reset As Button
End Class
