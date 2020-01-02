<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apartment_Details
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BlockC = New System.Windows.Forms.Button()
        Me.BlockB = New System.Windows.Forms.Button()
        Me.BlockA = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BlockC)
        Me.Panel1.Controls.Add(Me.BlockB)
        Me.Panel1.Controls.Add(Me.BlockA)
        Me.Panel1.Location = New System.Drawing.Point(78, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 375)
        Me.Panel1.TabIndex = 0
        '
        'BlockC
        '
        Me.BlockC.Location = New System.Drawing.Point(53, 279)
        Me.BlockC.Name = "BlockC"
        Me.BlockC.Size = New System.Drawing.Size(138, 52)
        Me.BlockC.TabIndex = 2
        Me.BlockC.Text = "Block C"
        Me.BlockC.UseVisualStyleBackColor = True
        '
        'BlockB
        '
        Me.BlockB.Location = New System.Drawing.Point(53, 173)
        Me.BlockB.Name = "BlockB"
        Me.BlockB.Size = New System.Drawing.Size(138, 52)
        Me.BlockB.TabIndex = 1
        Me.BlockB.Text = "Block B"
        Me.BlockB.UseVisualStyleBackColor = True
        '
        'BlockA
        '
        Me.BlockA.Location = New System.Drawing.Point(53, 54)
        Me.BlockA.Name = "BlockA"
        Me.BlockA.Size = New System.Drawing.Size(138, 52)
        Me.BlockA.TabIndex = 0
        Me.BlockA.Text = "Block A"
        Me.BlockA.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(426, 339)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 52)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Show Details"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(627, 339)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(138, 52)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Back"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Apartment_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 659)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Apartment_Details"
        Me.Text = "Apartment_Details"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BlockC As Button
    Friend WithEvents BlockB As Button
    Friend WithEvents BlockA As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
