<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLOYEE_ALL_WITHCODE_FORM
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
        Me.UPLOAD_IMAGE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrialProjectDataSet = New TRIAL_PROJECT.TrialProjectDataSet()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.NO_OF_RECORDS = New System.Windows.Forms.TextBox()
        Me.NEXT_BUTTON = New System.Windows.Forms.Button()
        Me.PREVIOUS_BUTTON = New System.Windows.Forms.Button()
        Me.FILTER = New System.Windows.Forms.Button()
        Me.SEARCH_VALUE = New System.Windows.Forms.TextBox()
        Me.CRITERIA = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EGENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDEPARTMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EPHOTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ENAME = New System.Windows.Forms.TextBox()
        Me.ESAL = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EID = New System.Windows.Forms.TextBox()
        Me.EMPLOYEETableAdapter = New TRIAL_PROJECT.TrialProjectDataSetTableAdapters.EMPLOYEETableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrialProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UPLOAD_IMAGE
        '
        Me.UPLOAD_IMAGE.Location = New System.Drawing.Point(242, 255)
        Me.UPLOAD_IMAGE.Name = "UPLOAD_IMAGE"
        Me.UPLOAD_IMAGE.Size = New System.Drawing.Size(75, 23)
        Me.UPLOAD_IMAGE.TabIndex = 39
        Me.UPLOAD_IMAGE.Text = "UPLOAD"
        Me.UPLOAD_IMAGE.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(94, 255)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 105)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.TrialProjectDataSet
        '
        'TrialProjectDataSet
        '
        Me.TrialProjectDataSet.DataSetName = "TrialProjectDataSet"
        Me.TrialProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(675, 336)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(140, 36)
        Me.ExportButton.TabIndex = 37
        Me.ExportButton.Text = "EXPORT TO EXCEL"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'NO_OF_RECORDS
        '
        Me.NO_OF_RECORDS.Location = New System.Drawing.Point(603, 255)
        Me.NO_OF_RECORDS.Name = "NO_OF_RECORDS"
        Me.NO_OF_RECORDS.Size = New System.Drawing.Size(42, 20)
        Me.NO_OF_RECORDS.TabIndex = 36
        '
        'NEXT_BUTTON
        '
        Me.NEXT_BUTTON.Location = New System.Drawing.Point(675, 252)
        Me.NEXT_BUTTON.Name = "NEXT_BUTTON"
        Me.NEXT_BUTTON.Size = New System.Drawing.Size(38, 24)
        Me.NEXT_BUTTON.TabIndex = 35
        Me.NEXT_BUTTON.Text = ">>"
        Me.NEXT_BUTTON.UseVisualStyleBackColor = True
        '
        'PREVIOUS_BUTTON
        '
        Me.PREVIOUS_BUTTON.Location = New System.Drawing.Point(536, 252)
        Me.PREVIOUS_BUTTON.Name = "PREVIOUS_BUTTON"
        Me.PREVIOUS_BUTTON.Size = New System.Drawing.Size(38, 24)
        Me.PREVIOUS_BUTTON.TabIndex = 34
        Me.PREVIOUS_BUTTON.Text = "<<"
        Me.PREVIOUS_BUTTON.UseVisualStyleBackColor = True
        '
        'FILTER
        '
        Me.FILTER.Location = New System.Drawing.Point(764, 40)
        Me.FILTER.Name = "FILTER"
        Me.FILTER.Size = New System.Drawing.Size(97, 36)
        Me.FILTER.TabIndex = 33
        Me.FILTER.Text = "FILTER"
        Me.FILTER.UseVisualStyleBackColor = True
        '
        'SEARCH_VALUE
        '
        Me.SEARCH_VALUE.Location = New System.Drawing.Point(580, 49)
        Me.SEARCH_VALUE.Name = "SEARCH_VALUE"
        Me.SEARCH_VALUE.Size = New System.Drawing.Size(178, 20)
        Me.SEARCH_VALUE.TabIndex = 32
        '
        'CRITERIA
        '
        Me.CRITERIA.FormattingEnabled = True
        Me.CRITERIA.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.CRITERIA.Location = New System.Drawing.Point(405, 49)
        Me.CRITERIA.Name = "CRITERIA"
        Me.CRITERIA.Size = New System.Drawing.Size(169, 21)
        Me.CRITERIA.TabIndex = 31
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(434, 336)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 36)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EIDDataGridViewTextBoxColumn, Me.ENAMEDataGridViewTextBoxColumn, Me.EGENDERDataGridViewTextBoxColumn, Me.EDEPARTMENTDataGridViewTextBoxColumn, Me.ESALDataGridViewTextBoxColumn, Me.EPHOTODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPLOYEEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(405, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 143)
        Me.DataGridView1.TabIndex = 29
        '
        'EIDDataGridViewTextBoxColumn
        '
        Me.EIDDataGridViewTextBoxColumn.DataPropertyName = "EID"
        Me.EIDDataGridViewTextBoxColumn.HeaderText = "EID"
        Me.EIDDataGridViewTextBoxColumn.Name = "EIDDataGridViewTextBoxColumn"
        '
        'ENAMEDataGridViewTextBoxColumn
        '
        Me.ENAMEDataGridViewTextBoxColumn.DataPropertyName = "ENAME"
        Me.ENAMEDataGridViewTextBoxColumn.HeaderText = "ENAME"
        Me.ENAMEDataGridViewTextBoxColumn.Name = "ENAMEDataGridViewTextBoxColumn"
        '
        'EGENDERDataGridViewTextBoxColumn
        '
        Me.EGENDERDataGridViewTextBoxColumn.DataPropertyName = "EGENDER"
        Me.EGENDERDataGridViewTextBoxColumn.HeaderText = "EGENDER"
        Me.EGENDERDataGridViewTextBoxColumn.Name = "EGENDERDataGridViewTextBoxColumn"
        '
        'EDEPARTMENTDataGridViewTextBoxColumn
        '
        Me.EDEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "EDEPARTMENT"
        Me.EDEPARTMENTDataGridViewTextBoxColumn.HeaderText = "EDEPARTMENT"
        Me.EDEPARTMENTDataGridViewTextBoxColumn.Name = "EDEPARTMENTDataGridViewTextBoxColumn"
        '
        'ESALDataGridViewTextBoxColumn
        '
        Me.ESALDataGridViewTextBoxColumn.DataPropertyName = "ESAL"
        Me.ESALDataGridViewTextBoxColumn.HeaderText = "ESAL"
        Me.ESALDataGridViewTextBoxColumn.Name = "ESALDataGridViewTextBoxColumn"
        '
        'EPHOTODataGridViewTextBoxColumn
        '
        Me.EPHOTODataGridViewTextBoxColumn.DataPropertyName = "EPHOTO"
        Me.EPHOTODataGridViewTextBoxColumn.HeaderText = "EPHOTO"
        Me.EPHOTODataGridViewTextBoxColumn.Name = "EPHOTODataGridViewTextBoxColumn"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(675, 294)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 36)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(434, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 36)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 36)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ENAME
        '
        Me.ENAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "ENAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ENAME.Location = New System.Drawing.Point(142, 103)
        Me.ENAME.Name = "ENAME"
        Me.ENAME.Size = New System.Drawing.Size(225, 20)
        Me.ENAME.TabIndex = 25
        '
        'ESAL
        '
        Me.ESAL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "ESAL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ESAL.Location = New System.Drawing.Point(143, 226)
        Me.ESAL.Name = "ESAL"
        Me.ESAL.Size = New System.Drawing.Size(225, 20)
        Me.ESAL.TabIndex = 24
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "EDEPARTMENT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CS", "IT", "HR"})
        Me.ComboBox2.Location = New System.Drawing.Point(142, 184)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox2.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "EGENDER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.ComboBox1.Location = New System.Drawing.Point(143, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'EID
        '
        Me.EID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "EID", True))
        Me.EID.Location = New System.Drawing.Point(142, 66)
        Me.EID.Name = "EID"
        Me.EID.Size = New System.Drawing.Size(225, 20)
        Me.EID.TabIndex = 21
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(288, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 36)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "ADD_NEW"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EMPLOYEE_ALL_WITHCODE_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 412)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.UPLOAD_IMAGE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.NO_OF_RECORDS)
        Me.Controls.Add(Me.NEXT_BUTTON)
        Me.Controls.Add(Me.PREVIOUS_BUTTON)
        Me.Controls.Add(Me.FILTER)
        Me.Controls.Add(Me.SEARCH_VALUE)
        Me.Controls.Add(Me.CRITERIA)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ENAME)
        Me.Controls.Add(Me.ESAL)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.EID)
        Me.Name = "EMPLOYEE_ALL_WITHCODE_FORM"
        Me.Text = "EMPLOYEE_ALL_WITHCODE_FORM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrialProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UPLOAD_IMAGE As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents NO_OF_RECORDS As System.Windows.Forms.TextBox
    Friend WithEvents NEXT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents PREVIOUS_BUTTON As System.Windows.Forms.Button
    Friend WithEvents FILTER As System.Windows.Forms.Button
    Friend WithEvents SEARCH_VALUE As System.Windows.Forms.TextBox
    Friend WithEvents CRITERIA As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ENAME As System.Windows.Forms.TextBox
    Friend WithEvents ESAL As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents EID As System.Windows.Forms.TextBox
    Friend WithEvents TrialProjectDataSet As TRIAL_PROJECT.TrialProjectDataSet
    Friend WithEvents EMPLOYEEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLOYEETableAdapter As TRIAL_PROJECT.TrialProjectDataSetTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents EIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EGENDERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EDEPARTMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EPHOTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
