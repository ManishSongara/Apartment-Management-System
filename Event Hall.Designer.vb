<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_Hall
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
        Me.TenantID = New System.Windows.Forms.Label()
        Me.FlatNumber = New System.Windows.Forms.Label()
        Me.BlockNumber = New System.Windows.Forms.Label()
        Me.Datee = New System.Windows.Forms.Label()
        Me.Purpose = New System.Windows.Forms.Label()
        Me.t_id = New System.Windows.Forms.MaskedTextBox()
        Me.flatn = New System.Windows.Forms.MaskedTextBox()
        Me.blockno = New System.Windows.Forms.MaskedTextBox()
        Me.purpose1 = New System.Windows.Forms.MaskedTextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'TenantID
        '
        Me.TenantID.AutoSize = True
        Me.TenantID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenantID.Location = New System.Drawing.Point(55, 93)
        Me.TenantID.Name = "TenantID"
        Me.TenantID.Size = New System.Drawing.Size(82, 20)
        Me.TenantID.TabIndex = 0
        Me.TenantID.Text = "Tenant ID"
        '
        'FlatNumber
        '
        Me.FlatNumber.AutoSize = True
        Me.FlatNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatNumber.Location = New System.Drawing.Point(55, 213)
        Me.FlatNumber.Name = "FlatNumber"
        Me.FlatNumber.Size = New System.Drawing.Size(101, 20)
        Me.FlatNumber.TabIndex = 1
        Me.FlatNumber.Text = "Flat Number"
        '
        'BlockNumber
        '
        Me.BlockNumber.AutoSize = True
        Me.BlockNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlockNumber.Location = New System.Drawing.Point(55, 155)
        Me.BlockNumber.Name = "BlockNumber"
        Me.BlockNumber.Size = New System.Drawing.Size(115, 20)
        Me.BlockNumber.TabIndex = 3
        Me.BlockNumber.Text = "Block Number"
        '
        'Datee
        '
        Me.Datee.AutoSize = True
        Me.Datee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datee.Location = New System.Drawing.Point(55, 257)
        Me.Datee.Name = "Datee"
        Me.Datee.Size = New System.Drawing.Size(45, 20)
        Me.Datee.TabIndex = 4
        Me.Datee.Text = "Date"
        '
        'Purpose
        '
        Me.Purpose.AutoSize = True
        Me.Purpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purpose.Location = New System.Drawing.Point(55, 304)
        Me.Purpose.Name = "Purpose"
        Me.Purpose.Size = New System.Drawing.Size(71, 20)
        Me.Purpose.TabIndex = 5
        Me.Purpose.Text = "Purpose"
        '
        't_id
        '
        Me.t_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_id.Location = New System.Drawing.Point(176, 93)
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(169, 27)
        Me.t_id.TabIndex = 6
        '
        'flatn
        '
        Me.flatn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flatn.Location = New System.Drawing.Point(176, 210)
        Me.flatn.Name = "flatn"
        Me.flatn.Size = New System.Drawing.Size(169, 27)
        Me.flatn.TabIndex = 7
        '
        'blockno
        '
        Me.blockno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blockno.Location = New System.Drawing.Point(176, 155)
        Me.blockno.Name = "blockno"
        Me.blockno.Size = New System.Drawing.Size(169, 27)
        Me.blockno.TabIndex = 9
        '
        'purpose1
        '
        Me.purpose1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purpose1.Location = New System.Drawing.Point(176, 304)
        Me.purpose1.Name = "purpose1"
        Me.purpose1.Size = New System.Drawing.Size(169, 27)
        Me.purpose1.TabIndex = 11
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Back.Location = New System.Drawing.Point(451, 81)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(129, 46)
        Me.Back.TabIndex = 12
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Logout.Location = New System.Drawing.Point(631, 83)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(129, 46)
        Me.Logout.TabIndex = 13
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 57)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 254)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Event_Hall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 685)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.purpose1)
        Me.Controls.Add(Me.blockno)
        Me.Controls.Add(Me.flatn)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.Purpose)
        Me.Controls.Add(Me.Datee)
        Me.Controls.Add(Me.BlockNumber)
        Me.Controls.Add(Me.FlatNumber)
        Me.Controls.Add(Me.TenantID)
        Me.Name = "Event_Hall"
        Me.Text = "Event_Hall"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TenantID As Label
    Friend WithEvents FlatNumber As Label
    Friend WithEvents BlockNumber As Label
    Friend WithEvents Datee As Label
    Friend WithEvents Purpose As Label
    Friend WithEvents t_id As MaskedTextBox
    Friend WithEvents flatn As MaskedTextBox
    Friend WithEvents blockno As MaskedTextBox
    Friend WithEvents purpose1 As MaskedTextBox
    Friend WithEvents Back As Button
    Friend WithEvents Logout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
