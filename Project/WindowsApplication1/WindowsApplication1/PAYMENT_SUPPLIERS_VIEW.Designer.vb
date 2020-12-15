<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAYMENT_SUPPLIERS_VIEW
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
        Me.CLOSE_BUTTON = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.sname = New System.Windows.Forms.TextBox
        Me.pdate = New System.Windows.Forms.DateTimePicker
        Me.upbal = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ppaid = New System.Windows.Forms.TextBox
        Me.currbal = New System.Windows.Forms.TextBox
        Me.piid = New System.Windows.Forms.TextBox
        Me.sid = New System.Windows.Forms.TextBox
        Me.pid = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CRITERIA = New System.Windows.Forms.ComboBox
        Me.FILTER_BUTTON = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SEARCH_VALUE = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PREVIOUS_BUTTON = New System.Windows.Forms.Button
        Me.EXIT_BUTTON = New System.Windows.Forms.Button
        Me.NO_OF_RECORDS = New System.Windows.Forms.TextBox
        Me.NEXT_BUTTON = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLOSE_BUTTON
        '
        Me.CLOSE_BUTTON.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CLOSE_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLOSE_BUTTON.Location = New System.Drawing.Point(152, 430)
        Me.CLOSE_BUTTON.Name = "CLOSE_BUTTON"
        Me.CLOSE_BUTTON.Size = New System.Drawing.Size(118, 30)
        Me.CLOSE_BUTTON.TabIndex = 125
        Me.CLOSE_BUTTON.Text = "CLOSE"
        Me.CLOSE_BUTTON.UseVisualStyleBackColor = True
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
        'sname
        '
        Me.sname.Location = New System.Drawing.Point(196, 105)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(168, 20)
        Me.sname.TabIndex = 119
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.CLOSE_BUTTON)
        Me.GroupBox1.Controls.Add(Me.sname)
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
        Me.GroupBox1.Location = New System.Drawing.Point(816, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 510)
        Me.GroupBox1.TabIndex = 174
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BILL DETAILS"
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
        'CRITERIA
        '
        Me.CRITERIA.FormattingEnabled = True
        Me.CRITERIA.Items.AddRange(New Object() {"Select a Criteria", "Payment ID", "Supplier's ID", "Supplier's Name", "Purchase Invoice ID", "Date", "Balance"})
        Me.CRITERIA.Location = New System.Drawing.Point(206, 19)
        Me.CRITERIA.Name = "CRITERIA"
        Me.CRITERIA.Size = New System.Drawing.Size(221, 21)
        Me.CRITERIA.TabIndex = 99
        '
        'FILTER_BUTTON
        '
        Me.FILTER_BUTTON.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.FILTER_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILTER_BUTTON.Location = New System.Drawing.Point(464, 19)
        Me.FILTER_BUTTON.Name = "FILTER_BUTTON"
        Me.FILTER_BUTTON.Size = New System.Drawing.Size(118, 30)
        Me.FILTER_BUTTON.TabIndex = 100
        Me.FILTER_BUTTON.Text = "FILTER"
        Me.FILTER_BUTTON.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label15.Location = New System.Drawing.Point(55, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 13)
        Me.Label15.TabIndex = 168
        Me.Label15.Text = "* Click on the record to edit it"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.SEARCH_VALUE)
        Me.GroupBox2.Controls.Add(Me.FILTER_BUTTON)
        Me.GroupBox2.Controls.Add(Me.CRITERIA)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(85, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(633, 111)
        Me.GroupBox2.TabIndex = 167
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEARCH"
        '
        'SEARCH_VALUE
        '
        Me.SEARCH_VALUE.Location = New System.Drawing.Point(206, 66)
        Me.SEARCH_VALUE.MaxLength = 20
        Me.SEARCH_VALUE.Name = "SEARCH_VALUE"
        Me.SEARCH_VALUE.Size = New System.Drawing.Size(221, 20)
        Me.SEARCH_VALUE.TabIndex = 111
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(76, 263)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(711, 371)
        Me.DataGridView1.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(609, 42)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "VIEW PAYMENT OF SUPPLIERS"
        '
        'PREVIOUS_BUTTON
        '
        Me.PREVIOUS_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PREVIOUS_BUTTON.Location = New System.Drawing.Point(348, 658)
        Me.PREVIOUS_BUTTON.Name = "PREVIOUS_BUTTON"
        Me.PREVIOUS_BUTTON.Size = New System.Drawing.Size(39, 30)
        Me.PREVIOUS_BUTTON.TabIndex = 172
        Me.PREVIOUS_BUTTON.Text = "<"
        Me.PREVIOUS_BUTTON.UseVisualStyleBackColor = True
        '
        'EXIT_BUTTON
        '
        Me.EXIT_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXIT_BUTTON.Location = New System.Drawing.Point(380, 704)
        Me.EXIT_BUTTON.Name = "EXIT_BUTTON"
        Me.EXIT_BUTTON.Size = New System.Drawing.Size(118, 30)
        Me.EXIT_BUTTON.TabIndex = 173
        Me.EXIT_BUTTON.Text = "EXIT"
        Me.EXIT_BUTTON.UseVisualStyleBackColor = True
        '
        'NO_OF_RECORDS
        '
        Me.NO_OF_RECORDS.Location = New System.Drawing.Point(412, 664)
        Me.NO_OF_RECORDS.MaxLength = 2
        Me.NO_OF_RECORDS.Name = "NO_OF_RECORDS"
        Me.NO_OF_RECORDS.Size = New System.Drawing.Size(50, 20)
        Me.NO_OF_RECORDS.TabIndex = 170
        '
        'NEXT_BUTTON
        '
        Me.NEXT_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NEXT_BUTTON.Location = New System.Drawing.Point(485, 658)
        Me.NEXT_BUTTON.Name = "NEXT_BUTTON"
        Me.NEXT_BUTTON.Size = New System.Drawing.Size(37, 30)
        Me.NEXT_BUTTON.TabIndex = 171
        Me.NEXT_BUTTON.Text = ">"
        Me.NEXT_BUTTON.UseVisualStyleBackColor = True
        '
        'PAYMENT_SUPPLIERS_VIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.CLOSE_BUTTON
        Me.ClientSize = New System.Drawing.Size(1303, 745)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PREVIOUS_BUTTON)
        Me.Controls.Add(Me.EXIT_BUTTON)
        Me.Controls.Add(Me.NO_OF_RECORDS)
        Me.Controls.Add(Me.NEXT_BUTTON)
        Me.Name = "PAYMENT_SUPPLIERS_VIEW"
        Me.Text = "PAYMENT_SUPPLIERS_VIEW"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CLOSE_BUTTON As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents sname As System.Windows.Forms.TextBox
    Friend WithEvents pdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents upbal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ppaid As System.Windows.Forms.TextBox
    Friend WithEvents currbal As System.Windows.Forms.TextBox
    Friend WithEvents piid As System.Windows.Forms.TextBox
    Friend WithEvents sid As System.Windows.Forms.TextBox
    Friend WithEvents pid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CRITERIA As System.Windows.Forms.ComboBox
    Friend WithEvents FILTER_BUTTON As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SEARCH_VALUE As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PREVIOUS_BUTTON As System.Windows.Forms.Button
    Friend WithEvents EXIT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents NO_OF_RECORDS As System.Windows.Forms.TextBox
    Friend WithEvents NEXT_BUTTON As System.Windows.Forms.Button
End Class
