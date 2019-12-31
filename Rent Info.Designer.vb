<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rent_Info
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
        Me.PaidPartially = New System.Windows.Forms.RadioButton()
        Me.PaidFully = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PaidPartially)
        Me.Panel1.Controls.Add(Me.PaidFully)
        Me.Panel1.Location = New System.Drawing.Point(47, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 116)
        Me.Panel1.TabIndex = 0
        '
        'PaidPartially
        '
        Me.PaidPartially.AutoSize = True
        Me.PaidPartially.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PaidPartially.Location = New System.Drawing.Point(13, 67)
        Me.PaidPartially.Name = "PaidPartially"
        Me.PaidPartially.Size = New System.Drawing.Size(111, 21)
        Me.PaidPartially.TabIndex = 24
        Me.PaidPartially.TabStop = True
        Me.PaidPartially.Text = "Paid Partially"
        Me.PaidPartially.UseVisualStyleBackColor = True
        '
        'PaidFully
        '
        Me.PaidFully.AutoSize = True
        Me.PaidFully.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PaidFully.Location = New System.Drawing.Point(13, 18)
        Me.PaidFully.Name = "PaidFully"
        Me.PaidFully.Size = New System.Drawing.Size(90, 21)
        Me.PaidFully.TabIndex = 23
        Me.PaidFully.TabStop = True
        Me.PaidFully.Text = "Paid Fully"
        Me.PaidFully.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(442, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(47, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(644, 184)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tenant ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Block Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Flat Number"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Flat Type"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Rent Amount"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Payment Status"
        Me.Column6.Name = "Column6"
        '
        'Rent_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Rent_Info"
        Me.Text = "Rent_Info"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents PaidFully As RadioButton
    Friend WithEvents PaidPartially As RadioButton
End Class
