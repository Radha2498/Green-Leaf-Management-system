<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEND_SMS_FORM
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.send_mail = New System.Windows.Forms.Button()
        Me.msgTextBox = New System.Windows.Forms.TextBox()
        Me.ToTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Message"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "To"
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.Location = New System.Drawing.Point(368, 81)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(291, 20)
        Me.SubjectTextBox.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(499, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 48)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'send_mail
        '
        Me.send_mail.Location = New System.Drawing.Point(199, 287)
        Me.send_mail.Name = "send_mail"
        Me.send_mail.Size = New System.Drawing.Size(172, 48)
        Me.send_mail.TabIndex = 11
        Me.send_mail.Text = "SEND"
        Me.send_mail.UseVisualStyleBackColor = True
        '
        'msgTextBox
        '
        Me.msgTextBox.Location = New System.Drawing.Point(368, 121)
        Me.msgTextBox.Multiline = True
        Me.msgTextBox.Name = "msgTextBox"
        Me.msgTextBox.Size = New System.Drawing.Size(291, 107)
        Me.msgTextBox.TabIndex = 10
        '
        'ToTextBox
        '
        Me.ToTextBox.Location = New System.Drawing.Point(368, 43)
        Me.ToTextBox.Name = "ToTextBox"
        Me.ToTextBox.Size = New System.Drawing.Size(291, 20)
        Me.ToTextBox.TabIndex = 9
        '
        'SEND_SMS_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 378)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubjectTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.send_mail)
        Me.Controls.Add(Me.msgTextBox)
        Me.Controls.Add(Me.ToTextBox)
        Me.Name = "SEND_SMS_FORM"
        Me.Text = "SEND_SMS_FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents send_mail As System.Windows.Forms.Button
    Friend WithEvents msgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToTextBox As System.Windows.Forms.TextBox
End Class
