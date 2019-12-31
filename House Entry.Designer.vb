<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class House_Entry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.MaskedTextBox3)
        Me.Panel1.Controls.Add(Me.PaidPartially)
        Me.Panel1.Controls.Add(Me.PaidFully)
        Me.Panel1.Controls.Add(Me.MaskedTextBox2)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Back)
        Me.Panel1.Controls.Add(Me.Submit)
        Me.Panel1.Controls.Add(Me.Phone)
        Me.Panel1.Controls.Add(Me.PaymentStatus)
        Me.Panel1.Controls.Add(Me.RentAmount)
        Me.Panel1.Controls.Add(Me.FlatNumber)
        Me.Panel1.Controls.Add(Me.FlatType)
        Me.Panel1.Controls.Add(Me.BlockName)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.NoofPersons)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TenantID)
        Me.Panel1.Location = New System.Drawing.Point(1, 199)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 513)
        Me.Panel1.TabIndex = 0
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(175, 419)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(168, 22)
        Me.MaskedTextBox3.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(184, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Flat Occupier Details"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(175, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(175, 342)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(168, 22)
        Me.MaskedTextBox2.TabIndex = 17
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(175, 298)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox4.TabIndex = 16
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(175, 255)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox3.TabIndex = 15
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(175, 209)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(34, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Flat Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(34, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Flat Number"
        '
        'Phone
        '
        Me.Phone.AutoSize = True
        Me.Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Phone.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Phone.Location = New System.Drawing.Point(34, 419)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(49, 17)
        Me.Phone.TabIndex = 11
        Me.Phone.Text = "Phone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(31, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Payment Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(34, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Phone"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 34)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(175, 209)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox2.TabIndex = 14
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(175, 255)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox3.TabIndex = 15
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(175, 298)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox4.TabIndex = 16
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(175, 342)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(168, 22)
        Me.MaskedTextBox2.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(184, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Paid Fully"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(274, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 17)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Paid Partially"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(175, 419)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(168, 22)
        Me.MaskedTextBox3.TabIndex = 20
        '
        'House_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "House_Entry"
        Me.Text = "House_Entry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents PaidPartially As Label
    Friend WithEvents PaidFully As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Back As Button
    Friend WithEvents Submit As Button
    Friend WithEvents Phone As Label
    Friend WithEvents PaymentStatus As Label
    Friend WithEvents RentAmount As Label
    Friend WithEvents FlatNumber As Label
    Friend WithEvents FlatType As Label
    Friend WithEvents BlockName As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NoofPersons As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
