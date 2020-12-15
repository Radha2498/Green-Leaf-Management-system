Imports System.Net.Mail

Public Class SEND_MAIL_FORM

    'Button to send mail
    'take 3 textboxes ->  to, subject, body
    Private Sub send_mail_Click(sender As Object, e As EventArgs) Handles send_mail.Click
        Try
            'Imports System.Net.Mail import this at the top
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            'write your gmail username and password here
            Dim userName As String = "kaushjaiswal@gmail.com"
            Dim password As String = "clfmbpzcixmfsfjt"

            Smtp_Server.Credentials = New Net.NetworkCredential(userName, password)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            MsgBox("Sending  Mail to " + ToTextBox.Text + ". Please Wait..!")
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(userName)
            e_mail.To.Add(ToTextBox.Text)
            e_mail.Subject = SubjectTextBox.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = msgTextBox.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent to " + ToTextBox.Text + " Successfully..!")

            ToTextBox.Clear()
            SubjectTextBox.Clear()
            msgTextBox.Clear()

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class