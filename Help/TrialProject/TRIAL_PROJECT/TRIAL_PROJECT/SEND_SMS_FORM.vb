Imports System.Net
Imports System.IO

Public Class SEND_SMS_FORM

    'Send SMS using Way2sms.com
    'Take 2 textboxes -> ToTextBox and msgTextBox 
    'Button name send_mail
    Private Sub send_mail_Click(sender As Object, e As EventArgs) Handles send_mail.Click

        Try
            Dim ApiKey As String = "F74K1OZ81XVIIOTQD5ZGRJSYF7G43NT6"
            Dim SecretKey As String = "SFBHIEGDFX0S25DC"
            Dim SenderId As String = "KaushJ"
            Dim phoneNumber As String = ToTextBox.Text
            Dim msg As String = msgTextBox.Text
            Dim strWay2sms As String = "http://www.way2sms.com/api/v1/sendCampaign/?apikey=" & ApiKey & "&secret=" & SecretKey & "&usetype=stage&senderid=" & SenderId & "&phone=" & phoneNumber & "&message=" & msg & ""
            Dim myReq As HttpWebRequest = DirectCast(WebRequest.Create(strWay2sms), HttpWebRequest)
            Dim myResp As HttpWebResponse = DirectCast(myReq.GetResponse(), HttpWebResponse)
            Dim respStreamReader As New System.IO.StreamReader(myResp.GetResponseStream())
            Dim responseString As String = respStreamReader.ReadToEnd()
            respStreamReader.Close()
            myResp.Close()
            MsgBox("Message sent successfully......!")
        Catch Ex As Exception
            MsgBox("Error Occured!!!" + Ex.Message)
        End Try
    End Sub

    'Close Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
