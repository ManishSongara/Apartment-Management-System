<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_Info
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
        Me.components = New System.ComponentModel.Container()
        Me.Back = New System.Windows.Forms.Button()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EventhallBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApartDataSet = New Apartment_Management_System.apartDataSet()
        Me.EventhallTableAdapter = New Apartment_Management_System.apartDataSetTableAdapters.eventhallTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EventhallBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurposeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenantIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlatNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.EventhallBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventhallBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(25, 441)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(121, 39)
        Me.Back.TabIndex = 2
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1019, 31)
        Me.FillByToolStrip.TabIndex = 4
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 24)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'EventhallBindingSource
        '
        Me.EventhallBindingSource.DataMember = "eventhall"
        Me.EventhallBindingSource.DataSource = Me.ApartDataSet
        '
        'ApartDataSet
        '
        Me.ApartDataSet.DataSetName = "apartDataSet"
        Me.ApartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventhallTableAdapter
        '
        Me.EventhallTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.PurposeDataGridViewTextBoxColumn, Me.TenantIDDataGridViewTextBoxColumn, Me.BlockNoDataGridViewTextBoxColumn, Me.FlatNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EventhallBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(165, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(714, 313)
        Me.DataGridView1.TabIndex = 5
        '
        'EventhallBindingSource1
        '
        Me.EventhallBindingSource1.DataMember = "eventhall"
        Me.EventhallBindingSource1.DataSource = Me.ApartDataSet
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.MinimumWidth = 3
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'PurposeDataGridViewTextBoxColumn
        '
        Me.PurposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose"
        Me.PurposeDataGridViewTextBoxColumn.HeaderText = "Purpose"
        Me.PurposeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PurposeDataGridViewTextBoxColumn.Name = "PurposeDataGridViewTextBoxColumn"
        Me.PurposeDataGridViewTextBoxColumn.Width = 200
        '
        'TenantIDDataGridViewTextBoxColumn
        '
        Me.TenantIDDataGridViewTextBoxColumn.DataPropertyName = "TenantID"
        Me.TenantIDDataGridViewTextBoxColumn.HeaderText = "TenantID"
        Me.TenantIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenantIDDataGridViewTextBoxColumn.Name = "TenantIDDataGridViewTextBoxColumn"
        Me.TenantIDDataGridViewTextBoxColumn.Width = 75
        '
        'BlockNoDataGridViewTextBoxColumn
        '
        Me.BlockNoDataGridViewTextBoxColumn.DataPropertyName = "BlockNo"
        Me.BlockNoDataGridViewTextBoxColumn.HeaderText = "BlockNo"
        Me.BlockNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BlockNoDataGridViewTextBoxColumn.Name = "BlockNoDataGridViewTextBoxColumn"
        Me.BlockNoDataGridViewTextBoxColumn.Width = 50
        '
        'FlatNoDataGridViewTextBoxColumn
        '
        Me.FlatNoDataGridViewTextBoxColumn.DataPropertyName = "FlatNo"
        Me.FlatNoDataGridViewTextBoxColumn.HeaderText = "FlatNo"
        Me.FlatNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FlatNoDataGridViewTextBoxColumn.Name = "FlatNoDataGridViewTextBoxColumn"
        Me.FlatNoDataGridViewTextBoxColumn.Width = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hall Booking Details"
        '
        'Booking_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 651)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Back)
        Me.Name = "Booking_Info"
        Me.Text = "Booking_Info"
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.EventhallBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventhallBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As Button
    Friend WithEvents ApartDataSet As apartDataSet
    Friend WithEvents EventhallBindingSource As BindingSource
    Friend WithEvents EventhallTableAdapter As apartDataSetTableAdapters.eventhallTableAdapter
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EventhallBindingSource1 As BindingSource
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurposeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenantIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlockNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlatNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
