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
        Me.t_name = New System.Windows.Forms.MaskedTextBox()
        Me.t_id = New System.Windows.Forms.MaskedTextBox()
        Me.t_password = New System.Windows.Forms.MaskedTextBox()
        Me.t_email = New System.Windows.Forms.MaskedTextBox()
        Me.t_phone = New System.Windows.Forms.MaskedTextBox()
        Me.t_block = New System.Windows.Forms.MaskedTextBox()
        Me.flat_no = New System.Windows.Forms.MaskedTextBox()
        Me.flat_type = New System.Windows.Forms.MaskedTextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.user_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TenantName
        '
        Me.TenantName.AutoSize = True
        Me.TenantName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenantName.Location = New System.Drawing.Point(94, 192)
        Me.TenantName.Name = "TenantName"
        Me.TenantName.Size = New System.Drawing.Size(109, 20)
        Me.TenantName.TabIndex = 0
        Me.TenantName.Text = "Tenant Name"
        '
        'TenantID
        '
        Me.TenantID.AutoSize = True
        Me.TenantID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenantID.Location = New System.Drawing.Point(104, 65)
        Me.TenantID.Name = "TenantID"
        Me.TenantID.Size = New System.Drawing.Size(82, 20)
        Me.TenantID.TabIndex = 1
        Me.TenantID.Text = "Tenant ID"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(103, 154)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(83, 20)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(115, 239)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(57, 20)
        Me.Email.TabIndex = 3
        Me.Email.Text = "E-mail"
        '
        'Phone
        '
        Me.Phone.AutoSize = True
        Me.Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.Location = New System.Drawing.Point(116, 290)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(56, 20)
        Me.Phone.TabIndex = 4
        Me.Phone.Text = "Phone"
        '
        'Block
        '
        Me.Block.AutoSize = True
        Me.Block.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Block.Location = New System.Drawing.Point(116, 344)
        Me.Block.Name = "Block"
        Me.Block.Size = New System.Drawing.Size(51, 20)
        Me.Block.TabIndex = 5
        Me.Block.Text = "Block"
        '
        'FlatNmber
        '
        Me.FlatNmber.AutoSize = True
        Me.FlatNmber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatNmber.Location = New System.Drawing.Point(104, 402)
        Me.FlatNmber.Name = "FlatNmber"
        Me.FlatNmber.Size = New System.Drawing.Size(92, 20)
        Me.FlatNmber.TabIndex = 6
        Me.FlatNmber.Text = "Flat Nmber"
        '
        'FlatType
        '
        Me.FlatType.AutoSize = True
        Me.FlatType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatType.Location = New System.Drawing.Point(108, 448)
        Me.FlatType.Name = "FlatType"
        Me.FlatType.Size = New System.Drawing.Size(78, 20)
        Me.FlatType.TabIndex = 7
        Me.FlatType.Text = "Flat Type"
        '
        't_name
        '
        Me.t_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_name.Location = New System.Drawing.Point(248, 192)
        Me.t_name.Name = "t_name"
        Me.t_name.Size = New System.Drawing.Size(157, 27)
        Me.t_name.TabIndex = 8
        '
        't_id
        '
        Me.t_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_id.Location = New System.Drawing.Point(248, 62)
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(157, 27)
        Me.t_id.TabIndex = 9
        '
        't_password
        '
        Me.t_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_password.Location = New System.Drawing.Point(248, 151)
        Me.t_password.Name = "t_password"
        Me.t_password.Size = New System.Drawing.Size(157, 27)
        Me.t_password.TabIndex = 10
        '
        't_email
        '
        Me.t_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_email.Location = New System.Drawing.Point(248, 239)
        Me.t_email.Name = "t_email"
        Me.t_email.Size = New System.Drawing.Size(157, 27)
        Me.t_email.TabIndex = 11
        '
        't_phone
        '
        Me.t_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_phone.Location = New System.Drawing.Point(248, 290)
        Me.t_phone.Name = "t_phone"
        Me.t_phone.Size = New System.Drawing.Size(157, 27)
        Me.t_phone.TabIndex = 12
        '
        't_block
        '
        Me.t_block.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_block.Location = New System.Drawing.Point(248, 344)
        Me.t_block.Name = "t_block"
        Me.t_block.Size = New System.Drawing.Size(157, 27)
        Me.t_block.TabIndex = 13
        '
        'flat_no
        '
        Me.flat_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flat_no.Location = New System.Drawing.Point(248, 402)
        Me.flat_no.Name = "flat_no"
        Me.flat_no.Size = New System.Drawing.Size(157, 27)
        Me.flat_no.TabIndex = 14
        '
        'flat_type
        '
        Me.flat_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flat_type.Location = New System.Drawing.Point(248, 445)
        Me.flat_type.Name = "flat_type"
        Me.flat_type.Size = New System.Drawing.Size(157, 27)
        Me.flat_type.TabIndex = 15
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
        'user_name
        '
        Me.user_name.Location = New System.Drawing.Point(248, 111)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(157, 22)
        Me.user_name.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "user_name"
        '
        'Tenant_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 619)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user_name)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.flat_type)
        Me.Controls.Add(Me.flat_no)
        Me.Controls.Add(Me.t_block)
        Me.Controls.Add(Me.t_phone)
        Me.Controls.Add(Me.t_email)
        Me.Controls.Add(Me.t_password)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.t_name)
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
    Friend WithEvents t_name As MaskedTextBox
    Friend WithEvents t_id As MaskedTextBox
    Friend WithEvents t_password As MaskedTextBox
    Friend WithEvents t_email As MaskedTextBox
    Friend WithEvents t_phone As MaskedTextBox
    Friend WithEvents t_block As MaskedTextBox
    Friend WithEvents flat_no As MaskedTextBox
    Friend WithEvents flat_type As MaskedTextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Reset As Button
    Friend WithEvents user_name As TextBox
    Friend WithEvents Label1 As Label
End Class
