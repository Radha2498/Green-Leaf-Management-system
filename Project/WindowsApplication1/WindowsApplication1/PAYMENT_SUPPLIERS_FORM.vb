Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel
Imports System.Net.Mail 'send mail

Public Class PAYMENT_SUPPLIERS_FORM
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from PURCHASE_INVOICE where BALANCE > 0"
    Dim scrollValue As Integer = 0
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim SIID As Integer
    Dim EMAIL As String

    Private Sub send_mail()
        Try
            'Imports System.Net.Mail import this at the top
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            'write your gmail username and password here
            Dim userName As String = "kulkarniradha2498@gmail.com"
            Dim password As String = "24rk1998"

            Smtp_Server.Credentials = New Net.NetworkCredential(userName, password)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            MsgBox("Payment Done. Sending  Mail to " + EMAIL + ". Please Wait..!")
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(userName)
            e_mail.To.Add(EMAIL)
            e_mail.Subject = "Payment Done"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Payment of Rs " & ppaid.Text & " has been made for your Invoice - " & SIID & ". Regards, Green Leaf"
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent to " + EMAIL + " Successfully..!")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub
    Private Sub getsupplieremail()
        If Not conn.State = ConnectionState.Open Then
            conn.Open()
        End If

        'get data into data table
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM SUPPLIER WHERE SID =" & sid.Text, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        'SET VALUES IN TEXTBOXES
        
        EMAIL = dt.Rows(0).Item(3)
        conn.Close()

    End Sub


    Private Sub PAYMENT_SUPPILER_FORM_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            CRITERIA.SelectedIndex = 0
            CRITERIA.DropDownStyle = ComboBoxStyle.DropDownList
            pid.Text = getNextId()
            pid.Enabled = False
            sid.Enabled = False
            piid.Enabled = False
            sname.Enabled = False
            GroupBox1.Visible = False
            NO_OF_RECORDS.Text = 10
            NO_OF_RECORDS.TextAlign = HorizontalAlignment.Center
            fillDataGrid()
            prepareDataGrid()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'function to get next id
    Private Function getNextId()
        Dim id As Integer
        Try
            SQL = "SELECT MAX(PID) FROM PAYMENT"
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If dr.Read = True Then
                id = dr.Item(0)
            Else
                id = 0
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
        Return id + 1
    End Function

    'TO FILL DATA GRID VIEW
    Private Sub fillDataGrid()
        Try
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            da.Fill(ds, scrollValue, NO_OF_RECORDS.Text, findQuery)
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'To chnage properties of DataGridView like column Headers and width
    Private Sub prepareDataGrid()

        With DataGridView1
            .AllowUserToResizeColumns = True
            .ReadOnly = True
            .ForeColor = Color.Blue
            .BackgroundColor = Color.LightSteelBlue
            .GridColor = Color.Azure
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersVisible = True
            .Columns(0).HeaderCell.Value = "Purchase Invoice ID"
            .Columns(1).HeaderCell.Value = "Date"
            .Columns(2).HeaderCell.Value = "Supplier ID"
            .Columns(3).HeaderCell.Value = "Supplier Name"
            .Columns(4).HeaderCell.Value = "Supplier Contact"
            .Columns(5).HeaderCell.Value = "Total"
            .Columns(6).HeaderCell.Value = "Paid"
            .Columns(7).HeaderCell.Value = "Balance"
           
            'CHANGE WIDTH
            .Columns(0).Width = 100
            .Columns(1).Width = 100
            .Columns(2).Width = 100
            .Columns(3).Width = 150
            .Columns(4).Width = 150
            .Columns(5).Width = 100
            .Columns(6).Width = 100
            .Columns(7).Width = 100

        End With
    End Sub

    Private Sub CANCEL_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CANCEL_BUTTON.Click
        Me.Hide()
        'MDIParent1.Show()
    End Sub

    Private Sub CLEAR_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CLEAR_BUTTON.Click
        Try
            pid.Clear()
            sname.Clear()
            sid.Clear()
            piid.Clear()
            pdate.Value = Today
            currbal.Clear()
            ppaid.Clear()
            upbal.Clear()
            pid.Text = getNextId()
            findQuery = "Select * from PURCHASE_INVOICE where BALANCE > 0"
            scrollValue = 0
            fillDataGrid()
            CRITERIA.SelectedIndex = 0
            SEARCH_VALUE.Clear()
            GroupBox1.Visible = False
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'Function to Validat data before saving or updating
    Private Function ValidateData()
        If (pid.Text = "" Or sname.Text = "" Or sid.Text = "" Or piid.Text = "" Or pdate.Text = "" Or currbal.Text = "" Or ppaid.Text = "" Or upbal.Text = "") Then
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub SAVE_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SAVE_BUTTON.Click
        If (ValidateData() = True) Then
            Try
                'INSERT QUERY 
                SQL = "INSERT INTO PAYMENT VALUES ('" & pid.Text & "', '" & Now.Date & "', '" & piid.Text & "', '" & sid.Text & "', '" & sname.Text & "','" & currbal.Text & "', '" & ppaid.Text & "', '" & upbal.Text & "');"
                conn.Open()
                cmd = New OleDbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                SQL = "UPDATE PURCHASE_INVOICE SET  PAID = PAID +" & ppaid.Text & ", BALANCE = BALANCE -" & ppaid.Text & " WHERE PI_ID = " & piid.Text & ";"
                cmd = New OleDbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
                getsupplieremail()
                send_mail()
                Call CLEAR_BUTTON_Click(sender, e)
            Catch ex As Exception
                conn.Close()
                MsgBox("Exception Occured : " + ex.Message)
            End Try
        End If
    End Sub

    'View record in text boxes, when clicked on DataGridView
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    siid = DataGridView1.SelectedRows(0).Cells(0).Value

                    'opening connection
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    'get data into data table
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM PURCHASE_INVOICE WHERE PI_ID =" & SIID, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    'SET VALUES IN TEXTBOXES
                    'pid.Text = SIID
                    GroupBox1.Visible = True
                    sid.Text = dt.Rows(0).Item(2)
                    sname.Text = dt.Rows(0).Item(3)
                    piid.Text = dt.Rows(0).Item(0)
                    pdate.Text = dt.Rows(0).Item(1)
                    currbal.Text = dt.Rows(0).Item(7)
                    ppaid.Text = 0
                    conn.Close()
                End If
            Else
                MessageBox.Show("No record to be edit. Add some record first", "Edit Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured HERE : " + ex.Message)
        End Try
    End Sub

    Private Sub FILTER_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FILTER_BUTTON.Click
        Try
            If CRITERIA.Text = "" Or CRITERIA.Text = "" Then
                findQuery = "SELECT * FROM PURCHASE_INVOICE"
            Else
                If CRITERIA.Text = "PURCHASE_INVOICE_ID" Then
                    findQuery = "SELECT * FROM PURCHASE_INVOICE WHERE PI_ID = " + SEARCH_VALUE.Text + ""
                ElseIf CRITERIA.Text = "SUPPLIER NAME" Then
                    findQuery = "SELECT * FROM PURCHASE_INVOICE WHERE SNAME like '" + SEARCH_VALUE.Text + "%'"
                Else
                    findQuery = "SELECT * FROM PURCHASE_INVOICE"
                End If
            End If
            fillDataGrid() 'FILL THE DATA GRID VIEW
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub NO_OF_RECORDS_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NO_OF_RECORDS.TextChanged
        If NO_OF_RECORDS.Text <> "" Then
            scrollValue = 0
            fillDataGrid()
        End If
    End Sub

    Private Sub PREVIOUS_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PREVIOUS_BUTTON.Click
        scrollValue = scrollValue - NO_OF_RECORDS.Text
        If scrollValue < 0 Then
            scrollValue = 0
        End If
        fillDataGrid()
    End Sub

    Private Sub NEXT_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NEXT_BUTTON.Click
        If Not DataGridView1.RowCount - 1 < NO_OF_RECORDS.Text Then
            scrollValue = scrollValue + NO_OF_RECORDS.Text
            fillDataGrid()
        End If
    End Sub

    Private Sub EXPORT_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EXPORT_BUTTON.Click
        Dim xlApp As EXCEL.Application
        Dim xlWorkBook As EXCEL.Workbook
        Dim xlWorkSheet As EXCEL.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Int16, j As Int16

        Try
            xlApp = New EXCEL.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            Dim fileName As String = InputBox("Enter The File Name : ", "File Name", ".xls")
            If Not fileName.EndsWith(".xls") Then
                fileName = fileName + ".xls"
            End If

            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            da.Fill(ds, "EMPLOYEE")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view

            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next

            'Change Only the path here
            xlWorkBook.SaveAs("C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Document\" + fileName, EXCEL.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
             EXCEL.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()

            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MessageBox.Show("Excel Generated..!")
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
        fillDataGrid()
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub VIEW_EXCEL_Click(ByVal sender As Object, ByVal e As EventArgs) Handles VIEW_EXCEL.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim PATH As String = OpenFileDialog1.FileName
            System.Diagnostics.Process.Start(PATH)
        End If
    End Sub

    Private Sub RESET_BUTTON_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles RESET_BUTTON.Click
        Call CLEAR_BUTTON_Click(sender, e)
    End Sub

    Private Sub ppaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ppaid.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ppaid_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ppaid.TextChanged
        If Val(ppaid.Text) < 0 Then
            MsgBox("Amount can not be less than 0", MsgBoxStyle.Critical, "Incorrect Amount")
        ElseIf (Val(ppaid.Text) > Val(currbal.Text)) Then
            MsgBox("Paid amount caanot be greater than current balance", MsgBoxStyle.Critical, "Incorrect Amount")
        Else
            upbal.Text = Val(currbal.Text) - Val(ppaid.Text)
        End If
    End Sub

    Private Sub currbal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles currbal.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub upbal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles upbal.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub VIEW_REPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEW_REPORT.Click
        'PAYMENT_SUPPLIERS_FORM_REPORT.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class