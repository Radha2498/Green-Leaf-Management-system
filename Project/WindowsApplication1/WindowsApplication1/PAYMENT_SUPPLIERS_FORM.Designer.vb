<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAYMENT_SUPPLIERS_FORM
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
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.VIEW_REPORT = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.EXPORT_BUTTON = New System.Windows.Forms.Button
        Me.CANCEL_BUTTON = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PREVIOUS_BUTTON = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.NEXT_BUTTON = New System.Windows.Forms.Button
        Me.FILTER_BUTTON = New System.Windows.Forms.Button
        Me.NO_OF_RECORDS = New System.Windows.Forms.TextBox
        Me.RESET_BUTTON = New System.Windows.Forms.Button
        Me.CLEAR_BUTTON = New System.Windows.Forms.Button
        Me.sname = New System.Windows.Forms.TextBox
        Me.SEARCH_VALUE = New System.Windows.Forms.TextBox
        Me.SAVE_BUTTON = New System.Windows.Forms.Button
        Me.pdate = New System.Windows.Forms.DateTimePicker
        Me.upbal = New System.Windows.Forms.TextBox
        Me.ppaid = New System.Windows.Forms.TextBox
        Me.currbal = New System.Windows.Forms.TextBox
        Me.piid = New System.Windows.Forms.TextBox
        Me.VIEW_EXCEL = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CRITERIA = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.sid = New System.Windows.Forms.TextBox
        Me.pid = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "PAYMENT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "SUPPLIER NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 16)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "PURCHASE INVOICE ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 269)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(695, 229)
        Me.DataGridView1.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "SUPPLIER ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 16)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "CURRENT BALANCE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(50, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 16)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "SELECT A CRITERIA"
        '
        'VIEW_REPORT
        '
        Me.VIEW_REPORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIEW_REPORT.Location = New System.Drawing.Point(120, 528)
        Me.VIEW_REPORT.Name = "VIEW_REPORT"
        Me.VIEW_REPORT.Size = New System.Drawing.Size(153, 30)
        Me.VIEW_REPORT.TabIndex = 160
        Me.VIEW_REPORT.Text = "VIEW REPORT"
        Me.VIEW_REPORT.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(50, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 16)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "SEARCH A VALUE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "PAID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 42)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "PAYMENT OF SUPPLIERS"
        '
        'EXPORT_BUTTON
        '
        Me.EXPORT_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXPORT_BUTTON.Location = New System.Drawing.Point(309, 528)
        Me.EXPORT_BUTTON.Name = "EXPORT_BUTTON"
        Me.EXPORT_BUTTON.Size = New System.Drawing.Size(153, 30)
        Me.EXPORT_BUTTON.TabIndex = 151
        Me.EXPORT_BUTTON.Text = "EXPORT TO EXCEL"
        Me.EXPORT_BUTTON.UseVisualStyleBackColor = True
        '
        'CANCEL_BUTTON
        '
        Me.CANCEL_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCEL_BUTTON.Location = New System.Drawing.Point(602, 528)
        Me.CANCEL_BUTTON.Name = "CANCEL_BUTTON"
        Me.CANCEL_BUTTON.Size = New System.Drawing.Size(118, 30)
        Me.CANCEL_BUTTON.TabIndex = 150
        Me.CANCEL_BUTTON.Text = "CLOSE"
        Me.CANCEL_BUTTON.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label15.Location = New System.Drawing.Point(64, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 13)
        Me.Label15.TabIndex = 154
        Me.Label15.Text = "* Click on the record to edit it"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PREVIOUS_BUTTON
        '
        Me.PREVIOUS_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PREVIOUS_BUTTON.Location = New System.Drawing.Point(389, 564)
        Me.PREVIOUS_BUTTON.Name = "PREVIOUS_BUTTON"
        Me.PREVIOUS_BUTTON.Size = New System.Drawing.Size(39, 30)
        Me.PREVIOUS_BUTTON.TabIndex = 158
        Me.PREVIOUS_BUTTON.Text = "<"
        Me.PREVIOUS_BUTTON.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 16)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "UPDATED BALANCE"
        '
        'NEXT_BUTTON
        '
        Me.NEXT_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NEXT_BUTTON.Location = New System.Drawing.Point(509, 564)
        Me.NEXT_BUTTON.Name = "NEXT_BUTTON"
        Me.NEXT_BUTTON.Size = New System.Drawing.Size(37, 30)
        Me.NEXT_BUTTON.TabIndex = 157
        Me.NEXT_BUTTON.Text = ">"
        Me.NEXT_BUTTON.UseVisualStyleBackColor = True
        '
        'FILTER_BUTTON
        '
        Me.FILTER_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILTER_BUTTON.Location = New System.Drawing.Point(464, 19)
        Me.FILTER_BUTTON.Name = "FILTER_BUTTON"
        Me.FILTER_BUTTON.Size = New System.Drawing.Size(118, 30)
        Me.FILTER_BUTTON.TabIndex = 100
        Me.FILTER_BUTTON.Text = "FILTER"
        Me.FILTER_BUTTON.UseVisualStyleBackColor = True
        '
        'NO_OF_RECORDS
        '
        Me.NO_OF_RECORDS.Location = New System.Drawing.Point(444, 570)
        Me.NO_OF_RECORDS.Name = "NO_OF_RECORDS"
        Me.NO_OF_RECORDS.Size = New System.Drawing.Size(50, 20)
        Me.NO_OF_RECORDS.TabIndex = 156
        '
        'RESET_BUTTON
        '
        Me.RESET_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESET_BUTTON.Location = New System.Drawing.Point(464, 65)
        Me.RESET_BUTTON.Name = "RESET_BUTTON"
        Me.RESET_BUTTON.Size = New System.Drawing.Size(118, 30)
        Me.RESET_BUTTON.TabIndex = 101
        Me.RESET_BUTTON.Text = "RESET"
        Me.RESET_BUTTON.UseVisualStyleBackColor = True
        '
        'CLEAR_BUTTON
        '
        Me.CLEAR_BUTTON.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CLEAR_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLEAR_BUTTON.Location = New System.Drawing.Point(223, 434)
        Me.CLEAR_BUTTON.Name = "CLEAR_BUTTON"
        Me.CLEAR_BUTTON.Size = New System.Drawing.Size(118, 30)
        Me.CLEAR_BUTTON.TabIndex = 120
        Me.CLEAR_BUTTON.Text = "CLEAR"
        Me.CLEAR_BUTTON.UseVisualStyleBackColor = True
        '
        'sname
        '
        Me.sname.Location = New System.Drawing.Point(196, 105)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(168, 20)
        Me.sname.TabIndex = 119
        '
        'SEARCH_VALUE
        '
        Me.SEARCH_VALUE.Location = New System.Drawing.Point(206, 66)
        Me.SEARCH_VALUE.Name = "SEARCH_VALUE"
        Me.SEARCH_VALUE.Size = New System.Drawing.Size(221, 20)
        Me.SEARCH_VALUE.TabIndex = 111
        '
        'SAVE_BUTTON
        '
        Me.SAVE_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVE_BUTTON.Location = New System.Drawing.Point(67, 434)
        Me.SAVE_BUTTON.Name = "SAVE_BUTTON"
        Me.SAVE_BUTTON.Size = New System.Drawing.Size(118, 30)
        Me.SAVE_BUTTON.TabIndex = 118
        Me.SAVE_BUTTON.Text = "SAVE"
        Me.SAVE_BUTTON.UseVisualStyleBackColor = True
        '
        'pdate
        '
        Me.pdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.pdate.Location = New System.Drawing.Point(196, 241)
        Me.pdate.Name = "pdate"
        Me.pdate.Size = New System.Drawing.Size(168, 20)
        Me.pdate.TabIndex = 117
        '
        'upbal
        '
        Me.upbal.Location = New System.Drawing.Point(196, 374)
        Me.upbal.Name = "upbal"
        Me.upbal.Size = New System.Drawing.Size(168, 20)
        Me.upbal.TabIndex = 114
        '
        'ppaid
        '
        Me.ppaid.Location = New System.Drawing.Point(196, 331)
        Me.ppaid.Name = "ppaid"
        Me.ppaid.Size = New System.Drawing.Size(168, 20)
        Me.ppaid.TabIndex = 113
        '
        'currbal
        '
        Me.currbal.Location = New System.Drawing.Point(196, 284)
        Me.currbal.Name = "currbal"
        Me.currbal.Size = New System.Drawing.Size(168, 20)
        Me.currbal.TabIndex = 112
        '
        'piid
        '
        Me.piid.Location = New System.Drawing.Point(196, 196)
        Me.piid.Name = "piid"
        Me.piid.Size = New System.Drawing.Size(168, 20)
        Me.piid.TabIndex = 111
        '
        'VIEW_EXCEL
        '
        Me.VIEW_EXCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIEW_EXCEL.Location = New System.Drawing.Point(486, 528)
        Me.VIEW_EXCEL.Name = "VIEW_EXCEL"
        Me.VIEW_EXCEL.Size = New System.Drawing.Size(110, 30)
        Me.VIEW_EXCEL.TabIndex = 159
        Me.VIEW_EXCEL.Text = "VIEW EXCEL"
        Me.VIEW_EXCEL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox2.Controls.Add(Me.CRITERIA)
        Me.GroupBox2.Controls.Add(Me.SEARCH_VALUE)
        Me.GroupBox2.Controls.Add(Me.RESET_BUTTON)
        Me.GroupBox2.Controls.Add(Me.FILTER_BUTTON)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 111)
        Me.GroupBox2.TabIndex = 153
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEARCH"
        '
        'CRITERIA
        '
        Me.CRITERIA.FormattingEnabled = True
        Me.CRITERIA.Items.AddRange(New Object() {"PURCHASE_INVOICE_ID", "SUPPLIER NAME"})
        Me.CRITERIA.Location = New System.Drawing.Point(206, 28)
        Me.CRITERIA.Name = "CRITERIA"
        Me.CRITERIA.Size = New System.Drawing.Size(221, 21)
        Me.CRITERIA.TabIndex = 112
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.CLEAR_BUTTON)
        Me.GroupBox1.Controls.Add(Me.sname)
        Me.GroupBox1.Controls.Add(Me.SAVE_BUTTON)
        Me.GroupBox1.Controls.Add(Me.pdate)
        Me.GroupBox1.Controls.Add(Me.upbal)
        Me.GroupBox1.Controls.Add(Me.ppaid)
        Me.GroupBox1.Controls.Add(Me.currbal)
        Me.GroupBox1.Controls.Add(Me.piid)
        Me.GroupBox1.Controls.Add(Me.sid)
        Me.GroupBox1.Controls.Add(Me.pid)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(834, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 510)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BILL DETAILS"
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(196, 151)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(168, 20)
        Me.sid.TabIndex = 110
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(196, 66)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(168, 20)
        Me.pid.TabIndex = 109
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MistyRose
        Me.PictureBox1.Location = New System.Drawing.Point(-43, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1389, 798)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 162
        Me.PictureBox1.TabStop = False
        '
        'PAYMENT_SUPPLIERS_FORM
        '
        Me.AcceptButton = Me.SAVE_BUTTON
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CLEAR_BUTTON
        Me.ClientSize = New System.Drawing.Size(1345, 745)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.VIEW_REPORT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EXPORT_BUTTON)
        Me.Controls.Add(Me.CANCEL_BUTTON)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PREVIOUS_BUTTON)
        Me.Controls.Add(Me.NEXT_BUTTON)
        Me.Controls.Add(Me.NO_OF_RECORDS)
        Me.Controls.Add(Me.VIEW_EXCEL)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PAYMENT_SUPPLIERS_FORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT_SUPPLIERS_FORM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents VIEW_REPORT As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EXPORT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents CANCEL_BUTTON As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PREVIOUS_BUTTON As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NEXT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents FILTER_BUTTON As System.Windows.Forms.Button
    Friend WithEvents NO_OF_RECORDS As System.Windows.Forms.TextBox
    Friend WithEvents RESET_BUTTON As System.Windows.Forms.Button
    Friend WithEvents CLEAR_BUTTON As System.Windows.Forms.Button
    Friend WithEvents sname As System.Windows.Forms.TextBox
    Friend WithEvents SEARCH_VALUE As System.Windows.Forms.TextBox
    Friend WithEvents SAVE_BUTTON As System.Windows.Forms.Button
    Friend WithEvents pdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents upbal As System.Windows.Forms.TextBox
    Friend WithEvents ppaid As System.Windows.Forms.TextBox
    Friend WithEvents currbal As System.Windows.Forms.TextBox
    Friend WithEvents piid As System.Windows.Forms.TextBox
    Friend WithEvents VIEW_EXCEL As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents sid As System.Windows.Forms.TextBox
    Friend WithEvents pid As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CRITERIA As System.Windows.Forms.ComboBox
End Class
