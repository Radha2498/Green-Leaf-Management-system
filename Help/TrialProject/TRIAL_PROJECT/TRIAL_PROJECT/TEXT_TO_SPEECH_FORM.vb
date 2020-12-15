Public Class TEXT_TO_SPEECH_FORM

    Private Sub SPEAK_BUTTON_Click(sender As Object, e As EventArgs) Handles SPEAK_BUTTON.Click
        Dim SAPI As Object
        SAPI = CreateObject("sapi.spvoice")
        SAPI.speak(TextBox1.Text)
    End Sub
End Class