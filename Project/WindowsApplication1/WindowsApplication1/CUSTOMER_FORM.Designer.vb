<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUSTOMER_FORM
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GrooupBox3 = New System.Windows.Forms.GroupBox
        Me.Filter = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SEARCH_VALUE = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CADDRESS = New System.Windows.Forms.TextBox
        Me.CNAME = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CEMAIL = New System.Windows.Forms.TextBox
        Me.CCTYPE = New System.Windows.Forms.TextBox
        Me.CCONTACT = New System.Windows.Forms.TextBox
        Me.CID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrooupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(429, -2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(307, 27)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "GreenLeaf Management System"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.photo_1459156212016_c812468e2115
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GrooupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(631, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(718, 690)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LavenderBlush
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(29, 259)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(668, 368)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(582, 229)
        Me.DataGridView1.TabIndex = 16
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(472, 290)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(165, 57)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "CANCEL"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(243, 290)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 57)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(36, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 57)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "EXPORT AS EXCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GrooupBox3
        '
        Me.GrooupBox3.BackColor = System.Drawing.Color.LavenderBlush
        Me.GrooupBox3.Controls.Add(Me.Filter)
        Me.GrooupBox3.Controls.Add(Me.ComboBox1)
        Me.GrooupBox3.Controls.Add(Me.Label7)
        Me.GrooupBox3.Controls.Add(Me.SEARCH_VALUE)
        Me.GrooupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrooupBox3.Location = New System.Drawing.Point(29, 48)
        Me.GrooupBox3.Name = "GrooupBox3"
        Me.GrooupBox3.Size = New System.Drawing.Size(654, 141)
        Me.GrooupBox3.TabIndex = 3
        Me.GrooupBox3.TabStop = False
        '
        'Filter
        '
        Me.Filter.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filter.Location = New System.Drawing.Point(49, 76)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(141, 46)
        Me.Filter.TabIndex = 15
        Me.Filter.Text = "SEARCH"
        Me.Filter.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Select a Search Criteria", "Customer Id", "Customer Name"})
        Me.ComboBox1.Location = New System.Drawing.Point(243, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(360, 27)
        Me.ComboBox1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "SELECT CRITERIA"
        '
        'SEARCH_VALUE
        '
        Me.SEARCH_VALUE.Location = New System.Drawing.Point(270, 88)
        Me.SEARCH_VALUE.Name = "SEARCH_VALUE"
        Me.SEARCH_VALUE.Size = New System.Drawing.Size(297, 26)
        Me.SEARCH_VALUE.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.photo_1459156212016_c812468e2115
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.CADDRESS)
        Me.GroupBox1.Controls.Add(Me.CNAME)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CEMAIL)
        Me.GroupBox1.Controls.Add(Me.CCTYPE)
        Me.GroupBox1.Controls.Add(Me.CCONTACT)
        Me.GroupBox1.Controls.Add(Me.CID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 690)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(139, 577)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(234, 86)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "report"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(303, 475)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 83)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CADDRESS
        '
        Me.CADDRESS.Location = New System.Drawing.Point(273, 405)
        Me.CADDRESS.Name = "CADDRESS"
        Me.CADDRESS.Size = New System.Drawing.Size(209, 26)
        Me.CADDRESS.TabIndex = 17
        '
        'CNAME
        '
        Me.CNAME.Location = New System.Drawing.Point(273, 113)
        Me.CNAME.Name = "CNAME"
        Me.CNAME.Size = New System.Drawing.Size(209, 26)
        Me.CNAME.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 475)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 83)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CEMAIL
        '
        Me.CEMAIL.Location = New System.Drawing.Point(273, 335)
        Me.CEMAIL.Name = "CEMAIL"
        Me.CEMAIL.Size = New System.Drawing.Size(209, 26)
        Me.CEMAIL.TabIndex = 10
        '
        'CCTYPE
        '
        Me.CCTYPE.Location = New System.Drawing.Point(273, 259)
        Me.CCTYPE.Name = "CCTYPE"
        Me.CCTYPE.Size = New System.Drawing.Size(209, 26)
        Me.CCTYPE.TabIndex = 9
        '
        'CCONTACT
        '
        Me.CCONTACT.Location = New System.Drawing.Point(273, 184)
        Me.CCONTACT.Name = "CCONTACT"
        Me.CCONTACT.Size = New System.Drawing.Size(209, 26)
        Me.CCONTACT.TabIndex = 8
        '
        'CID
        '
        Me.CID.Location = New System.Drawing.Point(273, 46)
        Me.CID.Name = "CID"
        Me.CID.Size = New System.Drawing.Size(209, 26)
        Me.CID.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(99, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EMAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CONTACT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'CUSTOMER_FORM
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(1366, 745)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CUSTOMER_FORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrooupBox3.ResumeLayout(False)
        Me.GrooupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents CNAME As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents CCTYPE As System.Windows.Forms.TextBox
    Friend WithEvents CCONTACT As System.Windows.Forms.TextBox
    Friend WithEvents CID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GrooupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SEARCH_VALUE As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Filter As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
