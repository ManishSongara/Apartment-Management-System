<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pay_eletricity
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Date1 = New System.Windows.Forms.Label()
        Me.PreviousReading = New System.Windows.Forms.Label()
        Me.CurrentReading = New System.Windows.Forms.Label()
        Me.ThisMonthReading = New System.Windows.Forms.Label()
        Me.t_id = New System.Windows.Forms.MaskedTextBox()
        Me.flatNo = New System.Windows.Forms.MaskedTextBox()
        Me.flatType = New System.Windows.Forms.MaskedTextBox()
        Me.blockNo = New System.Windows.Forms.MaskedTextBox()
        Me.date2 = New System.Windows.Forms.MaskedTextBox()
        Me.p_reading = New System.Windows.Forms.MaskedTextBox()
        Me.current_reading = New System.Windows.Forms.MaskedTextBox()
        Me.this_m_reading = New System.Windows.Forms.MaskedTextBox()
        Me.AmounttoPay = New System.Windows.Forms.Label()
        Me.CalculateReading = New System.Windows.Forms.Button()
        Me.amount_to_pay = New System.Windows.Forms.MaskedTextBox()
        Me.CalculateAmount = New System.Windows.Forms.Button()
        Me.CardNumber = New System.Windows.Forms.Label()
        Me.PINNumber = New System.Windows.Forms.Label()
        Me.cardNo = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox11 = New System.Windows.Forms.MaskedTextBox()
        Me.PAY = New System.Windows.Forms.Button()
        Me.BACK = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tenant ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Flat Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Flat Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Block Name"
        '
        'Date1
        '
        Me.Date1.AutoSize = True
        Me.Date1.Location = New System.Drawing.Point(77, 336)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(38, 17)
        Me.Date1.TabIndex = 4
        Me.Date1.Text = "Date"
        '
        'PreviousReading
        '
        Me.PreviousReading.AutoSize = True
        Me.PreviousReading.Location = New System.Drawing.Point(449, 128)
        Me.PreviousReading.Name = "PreviousReading"
        Me.PreviousReading.Size = New System.Drawing.Size(120, 17)
        Me.PreviousReading.TabIndex = 5
        Me.PreviousReading.Text = "Previous Reading"
        '
        'CurrentReading
        '
        Me.CurrentReading.AutoSize = True
        Me.CurrentReading.Location = New System.Drawing.Point(449, 180)
        Me.CurrentReading.Name = "CurrentReading"
        Me.CurrentReading.Size = New System.Drawing.Size(112, 17)
        Me.CurrentReading.TabIndex = 6
        Me.CurrentReading.Text = "Current Reading"
        '
        'ThisMonthReading
        '
        Me.ThisMonthReading.AutoSize = True
        Me.ThisMonthReading.Location = New System.Drawing.Point(449, 233)
        Me.ThisMonthReading.Name = "ThisMonthReading"
        Me.ThisMonthReading.Size = New System.Drawing.Size(135, 17)
        Me.ThisMonthReading.TabIndex = 7
        Me.ThisMonthReading.Text = "This Month Reading"
        '
        't_id
        '
        Me.t_id.Location = New System.Drawing.Point(190, 128)
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(175, 22)
        Me.t_id.TabIndex = 8
        '
        'flatNo
        '
        Me.flatNo.Location = New System.Drawing.Point(190, 180)
        Me.flatNo.Name = "flatNo"
        Me.flatNo.Size = New System.Drawing.Size(175, 22)
        Me.flatNo.TabIndex = 9
        '
        'flatType
        '
        Me.flatType.Location = New System.Drawing.Point(190, 233)
        Me.flatType.Name = "flatType"
        Me.flatType.Size = New System.Drawing.Size(175, 22)
        Me.flatType.TabIndex = 10
        '
        'blockNo
        '
        Me.blockNo.Location = New System.Drawing.Point(190, 282)
        Me.blockNo.Name = "blockNo"
        Me.blockNo.Size = New System.Drawing.Size(175, 22)
        Me.blockNo.TabIndex = 11
        '
        'date2
        '
        Me.date2.Location = New System.Drawing.Point(190, 336)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(175, 22)
        Me.date2.TabIndex = 12
        '
        'p_reading
        '
        Me.p_reading.Location = New System.Drawing.Point(613, 128)
        Me.p_reading.Name = "p_reading"
        Me.p_reading.Size = New System.Drawing.Size(175, 22)
        Me.p_reading.TabIndex = 13
        '
        'current_reading
        '
        Me.current_reading.Location = New System.Drawing.Point(613, 180)
        Me.current_reading.Name = "current_reading"
        Me.current_reading.Size = New System.Drawing.Size(175, 22)
        Me.current_reading.TabIndex = 14
        '
        'this_m_reading
        '
        Me.this_m_reading.Location = New System.Drawing.Point(613, 233)
        Me.this_m_reading.Name = "this_m_reading"
        Me.this_m_reading.Size = New System.Drawing.Size(175, 22)
        Me.this_m_reading.TabIndex = 15
        '
        'AmounttoPay
        '
        Me.AmounttoPay.AutoSize = True
        Me.AmounttoPay.Location = New System.Drawing.Point(449, 399)
        Me.AmounttoPay.Name = "AmounttoPay"
        Me.AmounttoPay.Size = New System.Drawing.Size(100, 17)
        Me.AmounttoPay.TabIndex = 9
        Me.AmounttoPay.Text = "Amount to Pay"
        '
        'CalculateReading
        '
        Me.CalculateReading.Location = New System.Drawing.Point(622, 304)
        Me.CalculateReading.Name = "CalculateReading"
        Me.CalculateReading.Size = New System.Drawing.Size(166, 37)
        Me.CalculateReading.TabIndex = 8
        Me.CalculateReading.Text = "Calculate Reading"
        Me.CalculateReading.UseVisualStyleBackColor = True
        '
        'amount_to_pay
        '
        Me.amount_to_pay.Location = New System.Drawing.Point(613, 394)
        Me.amount_to_pay.Name = "amount_to_pay"
        Me.amount_to_pay.Size = New System.Drawing.Size(175, 22)
        Me.amount_to_pay.TabIndex = 18
        '
        'CalculateAmount
        '
        Me.CalculateAmount.Location = New System.Drawing.Point(622, 454)
        Me.CalculateAmount.Name = "CalculateAmount"
        Me.CalculateAmount.Size = New System.Drawing.Size(166, 37)
        Me.CalculateAmount.TabIndex = 10
        Me.CalculateAmount.Text = "Calculate Amount"
        Me.CalculateAmount.UseVisualStyleBackColor = True
        '
        'CardNumber
        '
        Me.CardNumber.AutoSize = True
        Me.CardNumber.Location = New System.Drawing.Point(449, 527)
        Me.CardNumber.Name = "CardNumber"
        Me.CardNumber.Size = New System.Drawing.Size(92, 17)
        Me.CardNumber.TabIndex = 11
        Me.CardNumber.Text = "Card Number"
        '
        'PINNumber
        '
        Me.PINNumber.AutoSize = True
        Me.PINNumber.Location = New System.Drawing.Point(449, 594)
        Me.PINNumber.Name = "PINNumber"
        Me.PINNumber.Size = New System.Drawing.Size(84, 17)
        Me.PINNumber.TabIndex = 12
        Me.PINNumber.Text = "PIN Number"
        '
        'cardNo
        '
        Me.cardNo.Location = New System.Drawing.Point(613, 527)
        Me.cardNo.Name = "cardNo"
        Me.cardNo.Size = New System.Drawing.Size(175, 22)
        Me.cardNo.TabIndex = 22
        '
        'MaskedTextBox11
        '
        Me.MaskedTextBox11.Location = New System.Drawing.Point(613, 594)
        Me.MaskedTextBox11.Name = "MaskedTextBox11"
        Me.MaskedTextBox11.Size = New System.Drawing.Size(175, 22)
        Me.MaskedTextBox11.TabIndex = 23
        '
        'PAY
        '
        Me.PAY.Location = New System.Drawing.Point(452, 664)
        Me.PAY.Name = "PAY"
        Me.PAY.Size = New System.Drawing.Size(119, 43)
        Me.PAY.TabIndex = 13
        Me.PAY.Text = "PAY"
        Me.PAY.UseVisualStyleBackColor = True
        '
        'BACK
        '
        Me.BACK.Location = New System.Drawing.Point(632, 664)
        Me.BACK.Name = "BACK"
        Me.BACK.Size = New System.Drawing.Size(119, 43)
        Me.BACK.TabIndex = 14
        Me.BACK.Text = "BACK"
        Me.BACK.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(103, 399)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 24
        '
        'Pay_eletricity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 775)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.BACK)
        Me.Controls.Add(Me.PAY)
        Me.Controls.Add(Me.MaskedTextBox11)
        Me.Controls.Add(Me.cardNo)
        Me.Controls.Add(Me.PINNumber)
        Me.Controls.Add(Me.CardNumber)
        Me.Controls.Add(Me.CalculateAmount)
        Me.Controls.Add(Me.amount_to_pay)
        Me.Controls.Add(Me.CalculateReading)
        Me.Controls.Add(Me.AmounttoPay)
        Me.Controls.Add(Me.this_m_reading)
        Me.Controls.Add(Me.current_reading)
        Me.Controls.Add(Me.p_reading)
        Me.Controls.Add(Me.date2)
        Me.Controls.Add(Me.blockNo)
        Me.Controls.Add(Me.flatType)
        Me.Controls.Add(Me.flatNo)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.ThisMonthReading)
        Me.Controls.Add(Me.CurrentReading)
        Me.Controls.Add(Me.PreviousReading)
        Me.Controls.Add(Me.Date1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pay_eletricity"
        Me.Text = "Pay_eletricity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Date1 As Label
    Friend WithEvents PreviousReading As Label
    Friend WithEvents CurrentReading As Label
    Friend WithEvents ThisMonthReading As Label
    Friend WithEvents t_id As MaskedTextBox
    Friend WithEvents flatNo As MaskedTextBox
    Friend WithEvents flatType As MaskedTextBox
    Friend WithEvents blockNo As MaskedTextBox
    Friend WithEvents date2 As MaskedTextBox
    Friend WithEvents p_reading As MaskedTextBox
    Friend WithEvents current_reading As MaskedTextBox
    Friend WithEvents this_m_reading As MaskedTextBox
    Friend WithEvents AmounttoPay As Label
    Friend WithEvents CalculateReading As Button
    Friend WithEvents amount_to_pay As MaskedTextBox
    Friend WithEvents CalculateAmount As Button
    Friend WithEvents CardNumber As Label
    Friend WithEvents PINNumber As Label
    Friend WithEvents cardNo As MaskedTextBox
    Friend WithEvents MaskedTextBox11 As MaskedTextBox
    Friend WithEvents PAY As Button
    Friend WithEvents BACK As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
