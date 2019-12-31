<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alert_Notification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alert_Notification))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.Button()
        Me.Send = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AlertMessage = New System.Windows.Forms.Label()
        Me.FlatNumber = New System.Windows.Forms.Label()
        Me.BlockNumber = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Back)
        Me.Panel1.Controls.Add(Me.Send)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.AlertMessage)
        Me.Panel1.Controls.Add(Me.FlatNumber)
        Me.Panel1.Controls.Add(Me.BlockNumber)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(100, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 483)
        Me.Panel1.TabIndex = 0
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(322, 414)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(129, 41)
        Me.Back.TabIndex = 8
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(128, 414)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(129, 41)
        Me.Send.TabIndex = 7
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(260, 328)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(147, 34)
        Me.MaskedTextBox1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(260, 270)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(147, 24)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(260, 212)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'AlertMessage
        '
        Me.AlertMessage.AutoSize = True
        Me.AlertMessage.Location = New System.Drawing.Point(100, 328)
        Me.AlertMessage.Name = "AlertMessage"
        Me.AlertMessage.Size = New System.Drawing.Size(98, 17)
        Me.AlertMessage.TabIndex = 3
        Me.AlertMessage.Text = "Alert Message"
        '
        'FlatNumber
        '
        Me.FlatNumber.AutoSize = True
        Me.FlatNumber.Location = New System.Drawing.Point(100, 273)
        Me.FlatNumber.Name = "FlatNumber"
        Me.FlatNumber.Size = New System.Drawing.Size(85, 17)
        Me.FlatNumber.TabIndex = 2
        Me.FlatNumber.Text = "Flat Number"
        '
        'BlockNumber
        '
        Me.BlockNumber.AutoSize = True
        Me.BlockNumber.Location = New System.Drawing.Point(100, 212)
        Me.BlockNumber.Name = "BlockNumber"
        Me.BlockNumber.Size = New System.Drawing.Size(96, 17)
        Me.BlockNumber.TabIndex = 1
        Me.BlockNumber.Text = "Block Number"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(116, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 146)
        Me.Panel2.TabIndex = 0
        '
        'Alert_Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 622)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Alert_Notification"
        Me.Text = "Alert_Notification"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Back As Button
    Friend WithEvents Send As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AlertMessage As Label
    Friend WithEvents FlatNumber As Label
    Friend WithEvents BlockNumber As Label
    Friend WithEvents Panel2 As Panel
End Class
