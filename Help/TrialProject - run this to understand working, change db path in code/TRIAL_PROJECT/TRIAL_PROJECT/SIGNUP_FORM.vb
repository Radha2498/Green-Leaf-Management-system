Imports System.Data
Imports System.Data.OleDb

Public Class SIGNUP_FORM
    Dim mypath = "C:\Users\kaush\Desktop\TrialProject\TrialProject.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand

    'FORM LOAD [CHANGE NAME OF CONTROLS]
    Private Sub SIGNUP_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        ComboBox1.SelectedIndex = 0
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    'SAVE button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "SELECT A SECURITY QUESTION") Then 'IF ANY FIELD IS EMPTY
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
        ElseIf (TextBox2.Text <> TextBox3.Text) Then 'IF PASSWORDS DO NOT MATCH
            MsgBox("Passowrds Not Same", MsgBoxStyle.Critical, "Incorrect Password")
        Else
            Try
                'check if username already exists [CHANGE TABLE AND COLUMN NAMES]
                Dim sql = "SELECT USERNAME FROM USERS WHERE USERNAME =  '" & TextBox1.Text & "';"
                cmd = New OleDbCommand(sql, conn)
                conn.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                If dr.Read = True Then
                    MsgBox("User Name already Exist", MsgBoxStyle.Exclamation)
                    dr.Close()
                    TextBox1.Focus()
                Else
                    'INSERT QUERY [CHANGE TABLENAME AND NAME OF TEXT BOXES]
                    sql = "INSERT INTO USERS VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "', '" & TextBox4.Text & "');"
                    MsgBox(sql)
                    cmd = New OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registration Successful, Plz Login to Continue")
                    cmd.Dispose()
                    Form1.Show()  'SHOW LOGIN FORM
                End If
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MsgBox("Exception Occured : " + ex.Message)
            End Try
        End If
    End Sub

    'Close or Cancel button
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show() 'SHOW LOGIN FORM
    End Sub

    'CLEAR BUTTON [CHANGE NAME OF CONTROLS]
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.SelectedIndex = 0
    End Sub

    'TO CREATE TABLE USING CODE [CHANGE TABLE AND COLUMN NAMES]
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim tableName As String
            tableName = "EMPLOYEE"
            conn.Open()
            Dim dbSchema As DataTable = conn.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, tableName, "TABLE"})
            conn.Close()
            Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" + tableName + "] ([ENAME] TEXT(30), [EGENDER] TEXT(200), [EDEPARTMENT] TEXT(200), [ESAL] INTEGER)", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Table Created!")
        Catch Ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + Ex.Message)
        End Try
    End Sub
End Class