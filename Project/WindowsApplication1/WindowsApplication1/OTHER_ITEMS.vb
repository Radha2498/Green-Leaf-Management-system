Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel 'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0

Public Class OTHER_ITEMS
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from OTHER_ITEMS"

    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim imagePath As String
    Dim defaultPic = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Project\DEFAULT.jpg"

    'FORM LOAD [CHANGE NAME OF CONTROLS]
    Private Sub OTHER_ITEMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            IT_ID.Text = getNextId() 'function to get next id
            IT_ID.Enabled = False
            INAME.Focus()
            fillDataGrid() 'FILL THE DATA GRID VIEW
            prepareDataGrid()
            Button1.Text = "SAVE"
            imagePath = defaultPic
            'ComboBox1.SelectedIndex = 0
            'ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured in load: " + ex.Message)
        End Try
    End Sub

    'function to get next id
    Private Function getNextId()
        Dim id As Integer
        Try
            'check if username already exists [CHANGE TABLE AND COLUMN NAME]
            SQL = "SELECT MAX(IT_ID) FROM OTHER_ITEMS"
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
        Try
            With DataGridView1
                .AllowUserToResizeColumns = True
                .ReadOnly = True
                .ForeColor = Color.Chocolate 'CHANGE TEXT COLOR
                .BackgroundColor = Color.Chocolate 'CHANGE BACKGROUND COLOR
                .GridColor = Color.Azure 'CHANGE GRID COLOR
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft 'CHANGE ALIGNMENT
                'CHANGE HEADER
                .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "Item No"
                .Columns(1).HeaderCell.Value = "Category"
                .Columns(2).HeaderCell.Value = "Name"
                .Columns(3).HeaderCell.Value = "Size"
                .Columns(4).HeaderCell.Value = "Rate"
                .Columns(5).HeaderCell.Value = "Quantity"
                .Columns(6).HeaderCell.Value = "Description"
                
                'CHANGE WIDTH
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .Columns(2).Width = 150
                .Columns(3).Width = 150
                .Columns(4).Width = 150
                .Columns(5).Width = 100
                .Columns(6).Width = 200
                
            End With
        Catch ex As Exception
        End Try
    End Sub

    'TO FILL DATA GRID VIEW
    Private Sub fillDataGrid()
        Try
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            'fetch next 10 records only 
            'use da.Fill(ds, "OTHER_ITEMS") to fetch all at once
            da.Fill(ds, findQuery)
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view

        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try

    End Sub

    'Function to Validat data before saving or updating
    Private Function ValidateData()
        'If (IT_ID.Text = "" Or ESAL.Text = "" Or INAME.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "") Then 'IF ANY FIELD IS EMPTY
        '    MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
        'ElseIf (ESAL.Text < 0) Then
        '    MsgBox("Salay can not be Negative", MsgBoxStyle.Critical, "Incorrect Data")
        'Else
        '    Return True
        'End If
        Return False
    End Function

    'SAVE or UPDATE button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ValidateData() = False) Then 'Proceed only if data is valid
            Try
                If Button1.Text = "SAVE" Then
                    'INSERT QUERY [CHANGE TABLINAME AND NAMES OF TEXT BOXES]
                    SQL = "INSERT INTO OTHER_ITEMS VALUES ('" & IT_ID.Text & "','" & ICATEGORY.Text & "','" & INAME.Text & "', '" & ISIZE.Text & "','" & IRATE.Text & "','" & IQTY.Text & "','" & IDESCRIPTION.Text & "' );"
                Else
                    'UPDATE QUERY [CHANGE TABLINAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "UPDATE OTHER_ITEMS SET ICATAGORY = '" & ICATEGORY.Text & "', INAME= '" & INAME.Text & "', ISIZE = '" & ISIZE.Text & "', IRATE = '" & IRATE.Text & "' , IQTY = '" & IQTY.Text & "' WHERE IT_ID = " & IT_ID.Text & ";"
                End If
                MsgBox(SQL) 'REMOVE THIS LATER
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
    'Close or Cancel button
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show() 'SHOW LOGIN FORM
    End Sub

    'CLEAR BUTTON [CHANGE NAME OF CONTROLS]
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            IT_ID.Clear()
            INAME.Clear()
            ICATEGORY.Clear()
            ISIZE.Clear()
            IRATE.Clear()
            IQTY.Clear()
            IDESCRIPTION.Clear()
            'ESAL.Clear()
            INAME.Clear()
            ComboBox1.SelectedIndex = 0
            'ComboBox2.SelectedIndex = 0
            IT_ID.Text = getNextId() 'function to get next id
            findQuery = "Select * from OTHER_ITEMS"
            fillDataGrid() 'REFRESH THE DATAGRID
            Button1.Text = "SAVE"
            ComboBox1.SelectedIndex = 0
            CRITERIA.Clear()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'View record in text boxes, when clicked on DataGridView
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    Dim EMIT_ID As Integer = DataGridView1.SelectedRows(0).Cells(0).Value

                    'opening connection
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    'get data into data table
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM OTHER_ITEMS WHERE IT_ID =" & EMIT_ID, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    'SET VALUES IN TEXTBOXES
                    IT_ID.Text = EMIT_ID
                    INAME.Text = dt.Rows(0).Item(2)
                    ICATEGORY.Text = dt.Rows(0).Item(1)
                    ISIZE.Text = dt.Rows(0).Item(3)
                    IRATE.Text = dt.Rows(0).Item(4)
                    IQTY.Text = dt.Rows(0).Item(5)
                    IDESCRIPTION.Text = dt.Rows(0).Item(6)
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
                    'DELETE QUERY [CHANGE TABLINAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "DELETE FROM OTHER_ITEMS WHERE IT_ID = " & IT_ID.Text & ";"
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
    Private Sub FILTER_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Filter.Click
        Try
            If CRITERIA.Text = "" Or ComboBox1.Text = "" Then
                findQuery = "SELECT * FROM OTHER_ITEMS"
            Else
                If ComboBox1.Text = "Other item Id" Then
                    findQuery = "SELECT * FROM OTHER_ITEMS WHERE IT_ID = " + CRITERIA.Text + ""
                ElseIf ComboBox1.Text = "Item Name" Then
                    findQuery = "SELECT * FROM OTHER_ITEMS WHERE INAME like '" + CRITERIA.Text + "%'"
                Else
                    findQuery = "SELECT * FROM OTHER_ITEMS"
                End If
            End If
            fillDataGrid() 'FILL THE DATA GRID VIEW
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'Export data to excelsheet
    'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim xlApp As EXCEL.Application
        Dim xlWorkBook As EXCEL.Workbook
        Dim xlWorkSheet As EXCEL.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Int16, j As Int16

        Try
            xlApp = New EXCEL.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            Dim filINAME As String = InputBox("Enter The File Name : ", "File Name", ".xls")
            If Not filINAME.EndsWith(".xls") Then
                filINAME = filINAME + ".xls"
            End If

            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            da.Fill(ds, "OTHER_ITEMS")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view

            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next

            'Change Only the path here
            xlWorkBook.SaveAs("C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Document\" + filINAME, EXCEL.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
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
    'allow only alphabets
    Private Sub INAME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles INAME.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class

