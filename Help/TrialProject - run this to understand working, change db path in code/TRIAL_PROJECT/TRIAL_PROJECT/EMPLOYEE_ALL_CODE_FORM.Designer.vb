<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLOYEE_ALL_CODE_FORM
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
        Me.EID = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ESAL = New System.Windows.Forms.TextBox()
        Me.ENAME = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CRITERIA = New System.Windows.Forms.ComboBox()
        Me.SEARCH_VALUE = New System.Windows.Forms.TextBox()
        Me.FILTER = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PREVIOUS_BUTTON = New System.Windows.Forms.Button()
        Me.NEXT_BUTTON = New System.Windows.Forms.Button()
        Me.NO_OF_RECORDS = New System.Windows.Forms.TextBox()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UPLOAD_IMAGE = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EID
        '
        Me.EID.Location = New System.Drawing.Point(79, 54)
        Me.EID.Name = "EID"
        Me.EID.Size = New System.Drawing.Size(225, 20)
        Me.EID.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.ComboBox1.Location = New System.Drawing.Point(80, 127)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CS", "IT", "HR"})
        Me.ComboBox2.Location = New System.Drawing.Point(79, 172)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'ESAL
        '
        Me.ESAL.Location = New System.Drawing.Point(80, 214)
        Me.ESAL.Name = "ESAL"
        Me.ESAL.Size = New System.Drawing.Size(225, 20)
        Me.ESAL.TabIndex = 3
        '
        'ENAME
        '
        Me.ENAME.Location = New System.Drawing.Point(79, 91)
        Me.ENAME.Name = "ENAME"
        Me.ENAME.Size = New System.Drawing.Size(225, 20)
        Me.ENAME.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(371, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(612, 282)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 36)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(330, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(468, 143)
        Me.DataGridView1.TabIndex = 10
        '
        'CRITERIA
        '
        Me.CRITERIA.FormattingEnabled = True
        Me.CRITERIA.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.CRITERIA.Location = New System.Drawing.Point(342, 37)
        Me.CRITERIA.Name = "CRITERIA"
        Me.CRITERIA.Size = New System.Drawing.Size(169, 21)
        Me.CRITERIA.TabIndex = 12
        '
        'SEARCH_VALUE
        '
        Me.SEARCH_VALUE.Location = New System.Drawing.Point(517, 37)
        Me.SEARCH_VALUE.Name = "SEARCH_VALUE"
        Me.SEARCH_VALUE.Size = New System.Drawing.Size(178, 20)
        Me.SEARCH_VALUE.TabIndex = 13
        '
        'FILTER
        '
        Me.FILTER.Location = New System.Drawing.Point(701, 28)
        Me.FILTER.Name = "FILTER"
        Me.FILTER.Size = New System.Drawing.Size(97, 36)
        Me.FILTER.TabIndex = 14
        Me.FILTER.Text = "FILTER"
        Me.FILTER.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(371, 324)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 36)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PREVIOUS_BUTTON
        '
        Me.PREVIOUS_BUTTON.Location = New System.Drawing.Point(473, 240)
        Me.PREVIOUS_BUTTON.Name = "PREVIOUS_BUTTON"
        Me.PREVIOUS_BUTTON.Size = New System.Drawing.Size(38, 24)
        Me.PREVIOUS_BUTTON.TabIndex = 15
        Me.PREVIOUS_BUTTON.Text = "<<"
        Me.PREVIOUS_BUTTON.UseVisualStyleBackColor = True
        '
        'NEXT_BUTTON
        '
        Me.NEXT_BUTTON.Location = New System.Drawing.Point(612, 240)
        Me.NEXT_BUTTON.Name = "NEXT_BUTTON"
        Me.NEXT_BUTTON.Size = New System.Drawing.Size(38, 24)
        Me.NEXT_BUTTON.TabIndex = 16
        Me.NEXT_BUTTON.Text = ">>"
        Me.NEXT_BUTTON.UseVisualStyleBackColor = True
        '
        'NO_OF_RECORDS
        '
        Me.NO_OF_RECORDS.Location = New System.Drawing.Point(540, 243)
        Me.NO_OF_RECORDS.Name = "NO_OF_RECORDS"
        Me.NO_OF_RECORDS.Size = New System.Drawing.Size(42, 20)
        Me.NO_OF_RECORDS.TabIndex = 17
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(612, 324)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(140, 36)
        Me.ExportButton.TabIndex = 18
        Me.ExportButton.Text = "EXPORT TO EXCEL"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(31, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 105)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UPLOAD_IMAGE
        '
        Me.UPLOAD_IMAGE.Location = New System.Drawing.Point(225, 255)
        Me.UPLOAD_IMAGE.Name = "UPLOAD_IMAGE"
        Me.UPLOAD_IMAGE.Size = New System.Drawing.Size(75, 23)
        Me.UPLOAD_IMAGE.TabIndex = 20
        Me.UPLOAD_IMAGE.Text = "UPLOAD"
        Me.UPLOAD_IMAGE.UseVisualStyleBackColor = True
        '
        'EMPLOYEE_ALL_CODE_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 360)
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
        Me.Name = "EMPLOYEE_ALL_CODE_FORM"
        Me.Text = "EMPLOYEE_ALL_CODE_FORM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EID As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ESAL As System.Windows.Forms.TextBox
    Friend WithEvents ENAME As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CRITERIA As System.Windows.Forms.ComboBox
    Friend WithEvents SEARCH_VALUE As System.Windows.Forms.TextBox
    Friend WithEvents FILTER As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PREVIOUS_BUTTON As System.Windows.Forms.Button
    Friend WithEvents NEXT_BUTTON As System.Windows.Forms.Button
    Friend WithEvents NO_OF_RECORDS As System.Windows.Forms.TextBox
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UPLOAD_IMAGE As System.Windows.Forms.Button
End Class
