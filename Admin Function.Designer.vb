<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Function
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
        Me.HouseEntry = New System.Windows.Forms.Button()
        Me.RentInfo = New System.Windows.Forms.Button()
        Me.EBillInfo = New System.Windows.Forms.Button()
        Me.BookingInfo = New System.Windows.Forms.Button()
        Me.AlertNotification = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HouseEntry
        '
        Me.HouseEntry.Location = New System.Drawing.Point(100, 94)
        Me.HouseEntry.Name = "HouseEntry"
        Me.HouseEntry.Size = New System.Drawing.Size(173, 47)
        Me.HouseEntry.TabIndex = 0
        Me.HouseEntry.Text = "House Entry"
        Me.HouseEntry.UseVisualStyleBackColor = True
        '
        'RentInfo
        '
        Me.RentInfo.Location = New System.Drawing.Point(100, 210)
        Me.RentInfo.Name = "RentInfo"
        Me.RentInfo.Size = New System.Drawing.Size(173, 47)
        Me.RentInfo.TabIndex = 1
        Me.RentInfo.Text = "Rent Info"
        Me.RentInfo.UseVisualStyleBackColor = True
        '
        'EBillInfo
        '
        Me.EBillInfo.Location = New System.Drawing.Point(100, 313)
        Me.EBillInfo.Name = "EBillInfo"
        Me.EBillInfo.Size = New System.Drawing.Size(173, 47)
        Me.EBillInfo.TabIndex = 2
        Me.EBillInfo.Text = "E-Bill Info"
        Me.EBillInfo.UseVisualStyleBackColor = True
        '
        'BookingInfo
        '
        Me.BookingInfo.Location = New System.Drawing.Point(100, 421)
        Me.BookingInfo.Name = "BookingInfo"
        Me.BookingInfo.Size = New System.Drawing.Size(173, 47)
        Me.BookingInfo.TabIndex = 3
        Me.BookingInfo.Text = "Booking Info"
        Me.BookingInfo.UseVisualStyleBackColor = True
        '
        'AlertNotification
        '
        Me.AlertNotification.Location = New System.Drawing.Point(100, 541)
        Me.AlertNotification.Name = "AlertNotification"
        Me.AlertNotification.Size = New System.Drawing.Size(173, 47)
        Me.AlertNotification.TabIndex = 4
        Me.AlertNotification.Text = "Alert Notification"
        Me.AlertNotification.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 68)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "<----"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Admin_Function
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 694)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AlertNotification)
        Me.Controls.Add(Me.BookingInfo)
        Me.Controls.Add(Me.EBillInfo)
        Me.Controls.Add(Me.RentInfo)
        Me.Controls.Add(Me.HouseEntry)
        Me.Name = "Admin_Function"
        Me.Text = "Admin_Function"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HouseEntry As Button
    Friend WithEvents RentInfo As Button
    Friend WithEvents EBillInfo As Button
    Friend WithEvents BookingInfo As Button
    Friend WithEvents AlertNotification As Button
    Friend WithEvents Button1 As Button
End Class
