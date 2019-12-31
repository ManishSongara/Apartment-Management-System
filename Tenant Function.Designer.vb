<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tenant_Function
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PayElectricity = New System.Windows.Forms.Button()
        Me.BookEventHall = New System.Windows.Forms.Button()
        Me.FlatRent = New System.Windows.Forms.Button()
        Me.ProblemReport = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(507, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Notification"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tenant ID"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(610, 161)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(132, 27)
        Me.MaskedTextBox1.TabIndex = 2
        '
        'PayElectricity
        '
        Me.PayElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PayElectricity.Location = New System.Drawing.Point(89, 284)
        Me.PayElectricity.Name = "PayElectricity"
        Me.PayElectricity.Size = New System.Drawing.Size(181, 55)
        Me.PayElectricity.TabIndex = 1
        Me.PayElectricity.Text = "Pay Electricity"
        Me.PayElectricity.UseVisualStyleBackColor = True
        '
        'BookEventHall
        '
        Me.BookEventHall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BookEventHall.Location = New System.Drawing.Point(89, 408)
        Me.BookEventHall.Name = "BookEventHall"
        Me.BookEventHall.Size = New System.Drawing.Size(181, 55)
        Me.BookEventHall.TabIndex = 2
        Me.BookEventHall.Text = "Book Event Hall"
        Me.BookEventHall.UseVisualStyleBackColor = True
        '
        'FlatRent
        '
        Me.FlatRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FlatRent.Location = New System.Drawing.Point(89, 147)
        Me.FlatRent.Name = "FlatRent"
        Me.FlatRent.Size = New System.Drawing.Size(181, 55)
        Me.FlatRent.TabIndex = 0
        Me.FlatRent.Text = "Flat Rent"
        Me.FlatRent.UseVisualStyleBackColor = True
        '
        'ProblemReport
        '
        Me.ProblemReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ProblemReport.Location = New System.Drawing.Point(89, 530)
        Me.ProblemReport.Name = "ProblemReport"
        Me.ProblemReport.Size = New System.Drawing.Size(181, 55)
        Me.ProblemReport.TabIndex = 3
        Me.ProblemReport.Text = "Problem Report"
        Me.ProblemReport.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Back.Location = New System.Drawing.Point(462, 381)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(151, 51)
        Me.Back.TabIndex = 4
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Logout.Location = New System.Drawing.Point(662, 381)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(151, 51)
        Me.Logout.TabIndex = 5
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Tenant_Function
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 758)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.ProblemReport)
        Me.Controls.Add(Me.FlatRent)
        Me.Controls.Add(Me.BookEventHall)
        Me.Controls.Add(Me.PayElectricity)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tenant_Function"
        Me.Text = "Tenant_Function"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents PayElectricity As Button
    Friend WithEvents BookEventHall As Button
    Friend WithEvents FlatRent As Button
    Friend WithEvents ProblemReport As Button
    Friend WithEvents Back As Button
    Friend WithEvents Logout As Button
End Class
