<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAYMENT
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.CRITERIA = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.UPDATED_BALANCE = New System.Windows.Forms.TextBox
        Me.PAID = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PDATE = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.SAMOUNT = New System.Windows.Forms.TextBox
        Me.SNAME = New System.Windows.Forms.TextBox
        Me.SUPPLIER_ID = New System.Windows.Forms.TextBox
        Me.SALES_ID = New System.Windows.Forms.TextBox
        Me.PID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.CRITERIA)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 193)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(300, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 40)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "REFRESH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(44, 132)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(199, 40)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "SHOW"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(226, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(283, 27)
        Me.ComboBox1.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(28, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(159, 23)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "SELECT CRITERIA"
        '
        'CRITERIA
        '
        Me.CRITERIA.Location = New System.Drawing.Point(226, 86)
        Me.CRITERIA.Name = "CRITERIA"
        Me.CRITERIA.Size = New System.Drawing.Size(290, 26)
        Me.CRITERIA.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(633, 497)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(226, 419)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(179, 44)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "SHOW REPORT"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(414, 336)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 71)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "CANCEL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(44, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 73)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "CLEAR "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox3.Controls.Add(Me.UPDATED_BALANCE)
        Me.GroupBox3.Controls.Add(Me.PAID)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.PDATE)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.SAMOUNT)
        Me.GroupBox3.Controls.Add(Me.SNAME)
        Me.GroupBox3.Controls.Add(Me.SUPPLIER_ID)
        Me.GroupBox3.Controls.Add(Me.SALES_ID)
        Me.GroupBox3.Controls.Add(Me.PID)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(688, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(594, 709)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'UPDATED_BALANCE
        '
        Me.UPDATED_BALANCE.Location = New System.Drawing.Point(267, 477)
        Me.UPDATED_BALANCE.Name = "UPDATED_BALANCE"
        Me.UPDATED_BALANCE.Size = New System.Drawing.Size(203, 26)
        Me.UPDATED_BALANCE.TabIndex = 20
        '
        'PAID
        '
        Me.PAID.Location = New System.Drawing.Point(267, 425)
        Me.PAID.Name = "PAID"
        Me.PAID.Size = New System.Drawing.Size(203, 26)
        Me.PAID.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 482)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "UPDATED_BALANCE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(99, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "PAID"
        '
        'PDATE
        '
        Me.PDATE.Location = New System.Drawing.Point(267, 93)
        Me.PDATE.Name = "PDATE"
        Me.PDATE.Size = New System.Drawing.Size(203, 26)
        Me.PDATE.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(384, 563)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 87)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(71, 563)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(157, 87)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "SAVE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'SAMOUNT
        '
        Me.SAMOUNT.Location = New System.Drawing.Point(267, 372)
        Me.SAMOUNT.Name = "SAMOUNT"
        Me.SAMOUNT.Size = New System.Drawing.Size(203, 26)
        Me.SAMOUNT.TabIndex = 11
        '
        'SNAME
        '
        Me.SNAME.Location = New System.Drawing.Point(267, 306)
        Me.SNAME.Name = "SNAME"
        Me.SNAME.Size = New System.Drawing.Size(203, 26)
        Me.SNAME.TabIndex = 10
        '
        'SUPPLIER_ID
        '
        Me.SUPPLIER_ID.Location = New System.Drawing.Point(267, 231)
        Me.SUPPLIER_ID.Name = "SUPPLIER_ID"
        Me.SUPPLIER_ID.Size = New System.Drawing.Size(203, 26)
        Me.SUPPLIER_ID.TabIndex = 9
        '
        'SALES_ID
        '
        Me.SALES_ID.Location = New System.Drawing.Point(267, 161)
        Me.SALES_ID.Name = "SALES_ID"
        Me.SALES_ID.Size = New System.Drawing.Size(203, 26)
        Me.SALES_ID.TabIndex = 8
        '
        'PID
        '
        Me.PID.Location = New System.Drawing.Point(267, 27)
        Me.PID.Name = "PID"
        Me.PID.Size = New System.Drawing.Size(203, 26)
        Me.PID.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "AMOUNT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SUPPLIER_ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SALES_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PDATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(582, 145)
        Me.DataGridView1.TabIndex = 17
        '
        'PAYMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 745)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PAYMENT"
        Me.Text = "PAYMENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CRITERIA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PDATE As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents SAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents SNAME As System.Windows.Forms.TextBox
    Friend WithEvents SUPPLIER_ID As System.Windows.Forms.TextBox
    Friend WithEvents SALES_ID As System.Windows.Forms.TextBox
    Friend WithEvents PID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UPDATED_BALANCE As System.Windows.Forms.TextBox
    Friend WithEvents PAID As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
