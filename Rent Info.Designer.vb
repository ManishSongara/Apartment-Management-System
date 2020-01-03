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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PaidPartially = New System.Windows.Forms.RadioButton()
        Me.PaidFully = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ApartDataSet = New Apartment_Management_System.apartDataSet()
        Me.RentDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentDetailsTableAdapter = New Apartment_Management_System.apartDataSetTableAdapters.RentDetailsTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HouseentryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HouseentryTableAdapter = New Apartment_Management_System.apartDataSetTableAdapters.houseentryTableAdapter()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenantIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoofPersoninFamilyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlatnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlattypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseentryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ApartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseentryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseentryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ApartDataSet
        '
        Me.ApartDataSet.DataSetName = "apartDataSet"
        Me.ApartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentDetailsBindingSource
        '
        Me.RentDetailsBindingSource.DataMember = "RentDetails"
        Me.RentDetailsBindingSource.DataSource = Me.ApartDataSet
        '
        'RentDetailsTableAdapter
        '
        Me.RentDetailsTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PhoneDataGridViewTextBoxColumn, Me.TenantIDDataGridViewTextBoxColumn, Me.NoofPersoninFamilyDataGridViewTextBoxColumn, Me.BlockNoDataGridViewTextBoxColumn, Me.FlatnoDataGridViewTextBoxColumn, Me.FlattypeDataGridViewTextBoxColumn, Me.RentAmountDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HouseentryBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(25, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1053, 176)
        Me.DataGridView1.TabIndex = 3
        '
        'HouseentryBindingSource
        '
        Me.HouseentryBindingSource.DataMember = "houseentry"
        Me.HouseentryBindingSource.DataSource = Me.ApartDataSet
        '
        'HouseentryTableAdapter
        '
        Me.HouseentryTableAdapter.ClearBeforeFill = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.Width = 125
        '
        'TenantIDDataGridViewTextBoxColumn
        '
        Me.TenantIDDataGridViewTextBoxColumn.DataPropertyName = "TenantID"
        Me.TenantIDDataGridViewTextBoxColumn.HeaderText = "TenantID"
        Me.TenantIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenantIDDataGridViewTextBoxColumn.Name = "TenantIDDataGridViewTextBoxColumn"
        Me.TenantIDDataGridViewTextBoxColumn.Width = 125
        '
        'NoofPersoninFamilyDataGridViewTextBoxColumn
        '
        Me.NoofPersoninFamilyDataGridViewTextBoxColumn.DataPropertyName = "NoofPersoninFamily"
        Me.NoofPersoninFamilyDataGridViewTextBoxColumn.HeaderText = "NoofPersoninFamily"
        Me.NoofPersoninFamilyDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoofPersoninFamilyDataGridViewTextBoxColumn.Name = "NoofPersoninFamilyDataGridViewTextBoxColumn"
        Me.NoofPersoninFamilyDataGridViewTextBoxColumn.Width = 125
        '
        'BlockNoDataGridViewTextBoxColumn
        '
        Me.BlockNoDataGridViewTextBoxColumn.DataPropertyName = "BlockNo"
        Me.BlockNoDataGridViewTextBoxColumn.HeaderText = "BlockNo"
        Me.BlockNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BlockNoDataGridViewTextBoxColumn.Name = "BlockNoDataGridViewTextBoxColumn"
        Me.BlockNoDataGridViewTextBoxColumn.Width = 125
        '
        'FlatnoDataGridViewTextBoxColumn
        '
        Me.FlatnoDataGridViewTextBoxColumn.DataPropertyName = "Flatno"
        Me.FlatnoDataGridViewTextBoxColumn.HeaderText = "Flatno"
        Me.FlatnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FlatnoDataGridViewTextBoxColumn.Name = "FlatnoDataGridViewTextBoxColumn"
        Me.FlatnoDataGridViewTextBoxColumn.Width = 125
        '
        'FlattypeDataGridViewTextBoxColumn
        '
        Me.FlattypeDataGridViewTextBoxColumn.DataPropertyName = "Flattype"
        Me.FlattypeDataGridViewTextBoxColumn.HeaderText = "Flattype"
        Me.FlattypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FlattypeDataGridViewTextBoxColumn.Name = "FlattypeDataGridViewTextBoxColumn"
        Me.FlattypeDataGridViewTextBoxColumn.Width = 125
        '
        'RentAmountDataGridViewTextBoxColumn
        '
        Me.RentAmountDataGridViewTextBoxColumn.DataPropertyName = "RentAmount"
        Me.RentAmountDataGridViewTextBoxColumn.HeaderText = "RentAmount"
        Me.RentAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RentAmountDataGridViewTextBoxColumn.Name = "RentAmountDataGridViewTextBoxColumn"
        Me.RentAmountDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentStatusDataGridViewTextBoxColumn
        '
        Me.PaymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaymentStatusDataGridViewTextBoxColumn.Name = "PaymentStatusDataGridViewTextBoxColumn"
        Me.PaymentStatusDataGridViewTextBoxColumn.Width = 125
        '
        'HouseentryBindingSource1
        '
        Me.HouseentryBindingSource1.DataMember = "houseentry"
        Me.HouseentryBindingSource1.DataSource = Me.ApartDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 64)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rent Information"
        '
        'Rent_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 537)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Rent_Info"
        Me.Text = "Rent_Info"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ApartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseentryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseentryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PaidFully As RadioButton
    Friend WithEvents PaidPartially As RadioButton
    Friend WithEvents ApartDataSet As apartDataSet
    Friend WithEvents RentDetailsBindingSource As BindingSource
    Friend WithEvents RentDetailsTableAdapter As apartDataSetTableAdapters.RentDetailsTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HouseentryBindingSource As BindingSource
    Friend WithEvents HouseentryTableAdapter As apartDataSetTableAdapters.houseentryTableAdapter
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenantIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoofPersoninFamilyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlockNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlatnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlattypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseentryBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
End Class
