<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problem_Report
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
        Me.Logout = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.TenantID = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.Label()
        Me.FlatNumber = New System.Windows.Forms.Label()
        Me.Complaint = New System.Windows.Forms.Label()
        Me.Date2 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Logout
        '
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Logout.Location = New System.Drawing.Point(696, 131)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(122, 37)
        Me.Logout.TabIndex = 17
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Back.Location = New System.Drawing.Point(496, 131)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(122, 37)
        Me.Back.TabIndex = 16
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'TenantID
        '
        Me.TenantID.AutoSize = True
        Me.TenantID.Location = New System.Drawing.Point(61, 131)
        Me.TenantID.Name = "TenantID"
        Me.TenantID.Size = New System.Drawing.Size(70, 17)
        Me.TenantID.TabIndex = 0
        Me.TenantID.Text = "Tenant ID"
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(61, 198)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(45, 17)
        Me.Name.TabIndex = 1
        Me.Name.Text = "Name"
        '
        'FlatNumber
        '
        Me.FlatNumber.AutoSize = True
        Me.FlatNumber.Location = New System.Drawing.Point(61, 247)
        Me.FlatNumber.Name = "FlatNumber"
        Me.FlatNumber.Size = New System.Drawing.Size(85, 17)
        Me.FlatNumber.TabIndex = 2
        Me.FlatNumber.Text = "Flat Number"
        '
        'Complaint
        '
        Me.Complaint.AutoSize = True
        Me.Complaint.Location = New System.Drawing.Point(61, 298)
        Me.Complaint.Name = "Complaint"
        Me.Complaint.Size = New System.Drawing.Size(70, 17)
        Me.Complaint.TabIndex = 3
        Me.Complaint.Text = "Complaint"
        '
        'Date2
        '
        Me.Date2.AutoSize = True
        Me.Date2.Location = New System.Drawing.Point(61, 352)
        Me.Date2.Name = "Date2"
        Me.Date2.Size = New System.Drawing.Size(38, 17)
        Me.Date2.TabIndex = 4
        Me.Date2.Text = "Date"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(191, 126)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(183, 22)
        Me.MaskedTextBox1.TabIndex = 15
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(191, 193)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(183, 22)
        Me.MaskedTextBox2.TabIndex = 16
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(191, 244)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(183, 22)
        Me.MaskedTextBox3.TabIndex = 17
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(112, 399)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 18
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(191, 365)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(183, 22)
        Me.MaskedTextBox4.TabIndex = 19
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Submit.Location = New System.Drawing.Point(585, 488)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(127, 42)
        Me.Submit.TabIndex = 15
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Insufficiency of Water", "Road Damage", "Parking Camera Not Working"})
        Me.ComboBox1.Location = New System.Drawing.Point(191, 295)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 24)
        Me.ComboBox1.TabIndex = 22
        '
        'Problem_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 642)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Date2)
        Me.Controls.Add(Me.Complaint)
        Me.Controls.Add(Me.FlatNumber)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.TenantID)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Back)
        Me.Name = "Problem_Report"
        Me.Text = "Problem_Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logout As Button
    Friend WithEvents Back As Button
    Friend WithEvents TenantID As Label
    Friend WithEvents Name As Label
    Friend WithEvents FlatNumber As Label
    Friend WithEvents Complaint As Label
    Friend WithEvents Date2 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents Submit As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
