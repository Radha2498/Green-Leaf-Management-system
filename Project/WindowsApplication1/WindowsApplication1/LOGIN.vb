Imports System.Data.OleDb

Public Class Form1
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Public I As Integer

    'Button1 is LOGIN button, name of textboxes are ID and PSWD
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'write your query here
        Dim sql = "SELECT * FROM LOGIN WHERE USERNAME='" & Textbox1.Text & "' AND PASSWORD='" & Textbox2.Text & "'"

        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MsgBox("Login ID and/or Password Field Empty", vbExclamation, "LOGIN FAILED")
        Else
            cmd = New OleDbCommand(sql, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            Try
                If dr.Read = False Then
                    I = I + 1
                    If (MsgBox("Login ID and/or Password Incorrect", vbRetryCancel + vbExclamation, "LOGIN FAILED") = vbCancel) Then
                        Close()
                    Else
                        If (I <= 2) Then
                            TextBox1.Focus()
                        Else
                            MsgBox("3 Attempts Over..!", vbCritical, "LOGIN FAILED")
                            Close()
                        End If
                    End If

                Else
                    I = 0
                    MsgBox("LOG IN SUCCESSFUL...!")
                    MDIFORM.Show()
                   
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        I = 0
    End Sub

    Private Sub Groupbox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
