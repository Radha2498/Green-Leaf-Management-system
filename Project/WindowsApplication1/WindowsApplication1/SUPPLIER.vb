Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel 'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0

Public Class SUPPLIER
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from SUPPLIER"

    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    'FORM LOAD [CHANGE NAME OF CONTROLS]
    Private Sub SUPPLIER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            SID.Text = getNextId() 'function to get next id
            SID.Enabled = False
            SNAME.Focus()

            fillDataGrid() 'FILL THE DATA GRID VIEW
            prepareDataGrid()
            Button1.Text = "SAVE"
            CRITERIA.SelectedIndex = 0
            CRITERIA.DropDownStyle = ComboBoxStyle.DropDownList

        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'function to get next id
    Private Function getNextId()
        Dim id As Integer
        Try
            'check if username already exists [CHANGE TABLE AND COLUMN NAME]
            SQL = "SELECT MAX(SID) FROM SUPPLIER"
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

    'To chnage properties of DataGridView like column Headers and width
    Private Sub prepareDataGrid()

        With DataGridView1
            .AllowUserToResizeColumns = True
            .ReadOnly = True
            .ForeColor = Color.Chocolate 'CHANGE TEXT COLOR
            .BackgroundColor = Color.Chocolate 'CHANGE BACKGROUND COLOR
            .GridColor = Color.Azure 'CHANGE GRID COLOR
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft 'CHANGE ALIGNMENT
            'CHANGE HEADER
            .RowHeadersVisible = True
            .Columns(0).HeaderCell.Value = "Supplier No."
            .Columns(1).HeaderCell.Value = "Name"
            .Columns(2).HeaderCell.Value = "Contact"
            .Columns(3).HeaderCell.Value = "Email"
            .Columns(4).HeaderCell.Value = "City"
            .Columns(5).HeaderCell.Value = "Address"
            .Columns(6).HeaderCell.Value = "Supplier"

            'CHANGE WIDTH
            .Columns(0).Width = 100
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 150
            .Columns(4).Width = 100
            .Columns(5).Width = 200
            .Columns(6).Width = 200

        End With
    End Sub

    'TO FILL DATA GRID VIEW
    Private Sub fillDataGrid()
        Try
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            'fetch next 10 records only 
            'use da.Fill(ds, "SUPPLIER") to fetch all at once
            da.Fill(ds, "SUPPLIER")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view

        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try

    End Sub
    'SAVE or UPDATE button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ValidateData() = True) Then 'Proceed only if data is valid
            Try
                If Button1.Text = "SAVE" Then
                    'INSERT QUERY [CHANGE TABLPNAME AND NAMES OF TEXT BOXES]
                    SQL = "INSERT INTO SUPPLIER VALUES ('" & SID.Text & "', '" & SNAME.Text & "', '" & SCONTACT.Text & "', '" & SEMAIL.Text & "', '" & SCITY.Text & "', '" & SADDRESS.Text & "', '" & SUPPLIES.Text & "' );"
                Else
                    'UPDATE QUERY [CHANGE TABLPNAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "UPDATE SUPPLIER SET SNAME = '" & SNAME.Text & "', SCONTACT = '" & SCONTACT.Text & "', SEMAIL = '" & SEMAIL.Text & "', SCITY= '" & SCITY.Text & "', SADDRESS = '" & SADDRESS.Text & "' , SUPPLIES = '" & SUPPLIES.Text & "' , WHERE SID = " & SID.Text & ";"
                End If
                'MsgBox(SQL) 'REMOVE THIS LATER
                conn.Open()
                cmd = New OleDbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Saved Successfully..!")
                cmd.Dispose()
                conn.Close()
                Call Button2_Click(sender, e)
            Catch ex As Exception
                conn.Close()
                MsgBox("Exception Occured : " + ex.Message)
            End Try
        End If
    End Sub
    'Validation on Click of Save button
    Private Function ValidateData()

        'check if all textboxes are filled
        If (SID.Text = "" Or SNAME.Text = "" Or SCONTACT.Text = "" Or SEMAIL.Text = "" Or SADDRESS.Text = "" Or SCITY.Text = "" Or SUPPLIES.Text = "") Then
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
            Return False

            'contact number must be exact 10 digits
        ElseIf (SCONTACT.Text.Length <> 10) Then
            MsgBox("Contact number must be 10 digits", MsgBoxStyle.Critical, "Incorrect Data")
            Return False

            'validate email
        ElseIf SEMAIL.Text <> "" Then
            Try
                Dim vEmailAddress As New System.Net.Mail.MailAddress(SEMAIL.Text)
                Return True
            Catch ex As Exception
                MsgBox("Invalid Email Id", MsgBoxStyle.Critical, "Incorrect Data")
                Return False
            End Try
        Else
            Return True
        End If
        Return False
    End Function

    'View record in text boxes, when clicked on DataGridView
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    Dim EMSID As Integer = DataGridView1.SelectedRows(0).Cells(0).Value

                    'opening connection
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    'get data into data table
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM SUPPLIER WHERE SID =" & EMSID, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    'SET VALUES IN TEXTBOXES
                    SID.Text = EMSID
                    SNAME.Text = dt.Rows(0).Item(1)
                    SCONTACT.Text = dt.Rows(0).Item(2)
                    SEMAIL.Text = dt.Rows(0).Item(3)
                    SADDRESS.Text = dt.Rows(0).Item(4)
                    SCITY.Text = dt.Rows(0).Item(5)
                    SUPPLIES.Text = dt.Rows(0).Item(6)
                    'Change button caption to UPDATE
                    Button1.Text = "UPDATE"

                    conn.Close()

                End If
            Else
                MessageBox.Show("No record to be edit. Add some record first", "Edit Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'DELETE BUTTON
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Try
            If Button1.Text = "SAVE" Then 'IF NO RECORD IS SELECTED
                MsgBox("Select a Record to Delete!")
            Else
                'Confirmation
                If MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
                    'DELETE QUERY [CHANGE TABLSNAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "DELETE FROM SUPPLIER WHERE SID = " & SID.Text & ";"
                    conn.Open()
                    cmd = New OleDbCommand(SQL, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted Successfully..!")
                    cmd.Dispose()
                    conn.Close()
                    Call Button2_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'FIND FILTER OR SEARCH BUTTON
    Private Sub Filter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Filter.Click
        Try
            If CRITERIA.Text = "" Or SEARCH_VALUE.Text = "" Then
                findQuery = "SELECT * FROM SUPPLIER"
            Else
                If CRITERIA.Text = "SUPPLIER ID" Then
                    findQuery = "SELECT * FROM SUPPLIER WHERE SID = " + SEARCH_VALUE.Text + ""
                ElseIf CRITERIA.Text = "SUPPLIER NAME" Then
                    findQuery = "SELECT * FROM SUPPLIER WHERE SNAME like '" + SEARCH_VALUE.Text + "%'"
                Else
                    findQuery = "SELECT * FROM SUPPLIER"
                End If
            End If
            MsgBox(findQuery)
            fillDataGrid() 'FILL THE DATA GRID VIEW
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'Export data to excelsheet
    'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0
    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click
        Dim xlApp As EXCEL.Application
        Dim xlWorkBook As EXCEL.Workbook
        Dim xlWorkSheet As EXCEL.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Int16, j As Int16

        Try
            xlApp = New EXCEL.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            Dim filSNAME As String = InputBox("Enter The File Name : ", "File Name", ".xls")
            If Not filSNAME.EndsWith(".xls") Then
                filSNAME = filSNAME + ".xls"
            End If

            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            da.Fill(ds, "SUPPLIER")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view

            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next

            'Change Only the path here
            xlWorkBook.SaveAs("C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Document\" + filSNAME, EXCEL.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
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

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            SID.Clear()
            'ESAL.Clear()
            SNAME.Clear()
            SCONTACT.Clear()
            SEMAIL.Clear()
            SCITY.Clear()
            SADDRESS.Clear()
            SUPPLIES.Clear()
            CRITERIA.SelectedIndex = 0
            'ComboBox2.SelectedIndex = 0
            SID.Text = getNextId() 'function to get next id
            findQuery = "Select * from SUPPLIER"
            fillDataGrid() 'REFRESH THE DATAGRID
            Button1.Text = "SAVE"
            CRITERIA.SelectedIndex = 0
            SEARCH_VALUE.Clear()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show() 'SHOW LOGIN FORM
    End Sub

    Private Sub sname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SNAME.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SUPPLIER_REPORT.Show()

    End Sub

    Private Sub SID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SID.TextChanged

    End Sub
End Class






