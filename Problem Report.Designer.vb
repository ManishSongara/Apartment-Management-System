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

    Private Const V1 As String = "Problem_Report"
    Private Const V As String = V1

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.TenantID = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.Label()
        Me.FlatNumber = New System.Windows.Forms.Label()
        Me.Complaint = New System.Windows.Forms.Label()
        Me.Date2 = New System.Windows.Forms.Label()
        Me.t_id = New System.Windows.Forms.MaskedTextBox()
        Me.tname = New System.Windows.Forms.MaskedTextBox()
        Me.f_no = New System.Windows.Forms.MaskedTextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.t_date = New System.Windows.Forms.MaskedTextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.complain = New System.Windows.Forms.ComboBox()
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
        't_id
        '
        Me.t_id.Location = New System.Drawing.Point(191, 126)
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(183, 22)
        Me.t_id.TabIndex = 15
        '
        'tname
        '
        Me.tname.Location = New System.Drawing.Point(191, 193)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(183, 22)
        Me.tname.TabIndex = 16
        '
        'f_no
        '
        Me.f_no.Location = New System.Drawing.Point(191, 244)
        Me.f_no.Name = "f_no"
        Me.f_no.Size = New System.Drawing.Size(183, 22)
        Me.f_no.TabIndex = 17
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(112, 399)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 18
        '
        't_date
        '
        Me.t_date.Location = New System.Drawing.Point(191, 365)
        Me.t_date.Name = "t_date"
        Me.t_date.Size = New System.Drawing.Size(183, 22)
        Me.t_date.TabIndex = 19
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
        'complain
        '
        Me.complain.FormattingEnabled = True
        Me.complain.Items.AddRange(New Object() {"Insufficiency of Water", "Road Damage", "Parking Camera Not Working"})
        Me.complain.Location = New System.Drawing.Point(191, 295)
        Me.complain.Name = "complain"
        Me.complain.Size = New System.Drawing.Size(183, 24)
        Me.complain.TabIndex = 22
        '
        'Problem_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 642)
        Me.Controls.Add(Me.complain)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.t_date)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.f_no)
        Me.Controls.Add(Me.tname)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.Date2)
        Me.Controls.Add(Me.Complaint)
        Me.Controls.Add(Me.FlatNumber)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.TenantID)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Back)
        'Me.Name = "Problem_Report"
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
    Friend WithEvents t_id As MaskedTextBox
    Friend WithEvents tname As MaskedTextBox
    Friend WithEvents f_no As MaskedTextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents t_date As MaskedTextBox
    Friend WithEvents Submit As Button
    Friend WithEvents complain As ComboBox
    Private Shared ReadOnly [to] As Label
End Class
