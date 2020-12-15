Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel 'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0

Public Class EMPLOYEE_ALL_CODE_FORM
    Dim mypath = "C:\Users\kaush\Desktop\TrialProject\TrialProject.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from EMPLOYEE"
    Dim scrollValue As Integer = 0
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim imagePath As String
    Dim defaultPic = "C:\Users\kaush\Desktop\TrialProject\insta.jpg"

    'FORM LOAD [CHANGE NAME OF CONTROLS]
    Private Sub EMPLOYEE_ALL_CODE_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBox1.SelectedIndex = 0
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox2.SelectedIndex = 0
            ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
            EID.Text = getNextId() 'function to get next id
            EID.Enabled = False
            ENAME.Focus()
            NO_OF_RECORDS.Text = 2
            NO_OF_RECORDS.TextAlign = HorizontalAlignment.Center
            fillDataGrid() 'FILL THE DATA GRID VIEW
            prepareDataGrid()
            Button1.Text = "SAVE"
            imagePath = defaultPic
            PictureBox1.Load(imagePath)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
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
            SQL = "SELECT MAX(EID) FROM EMPLOYEE"
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
            .Columns(0).HeaderCell.Value = "E No."
            .Columns(1).HeaderCell.Value = "Name"
            .Columns(2).HeaderCell.Value = "Gender"
            .Columns(3).HeaderCell.Value = "Department"
            .Columns(4).HeaderCell.Value = "Salary"
            .Columns(5).HeaderCell.Value = "Photo"

            'CHANGE WIDTH
            .Columns(0).Width = 100
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 150
            .Columns(4).Width = 100
            .Columns(5).Width = 200

        End With
    End Sub

    'TO FILL DATA GRID VIEW
    Private Sub fillDataGrid()
        Try
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            'fetch next 10 records only 
            'use da.Fill(ds, "EMPLOYEE") to fetch all at once
            da.Fill(ds, scrollValue, NO_OF_RECORDS.Text, "EMPLOYEE")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view

        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try

    End Sub

    'next button to get next 10 records
    Private Sub NEXT_BUTTON_Click(sender As Object, e As EventArgs) Handles NEXT_BUTTON.Click
        If Not DataGridView1.RowCount - 1 < NO_OF_RECORDS.Text Then
            scrollValue = scrollValue + NO_OF_RECORDS.Text
            fillDataGrid()
        End If
    End Sub

    'previous button to get previous 10 records
    Private Sub PREVIOUS_BUTTON_Click(sender As Object, e As EventArgs) Handles PREVIOUS_BUTTON.Click
        scrollValue = scrollValue - NO_OF_RECORDS.Text
        If scrollValue < 0 Then
            scrollValue = 0
        End If
        fillDataGrid()
    End Sub

    'IF NO OF RECORDS TO VIEW IS CHANGED
    Private Sub NO_OF_RECORDS_TextChanged(sender As Object, e As EventArgs) Handles NO_OF_RECORDS.TextChanged
        If NO_OF_RECORDS.Text <> "" Then
            scrollValue = 0
            fillDataGrid() 'FILL THE DATA GRID VIEW
        End If
    End Sub


    'Function to Validat data before saving or updating
    Private Function ValidateData()
        If (EID.Text = "" Or ESAL.Text = "" Or ENAME.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "") Then 'IF ANY FIELD IS EMPTY
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
        ElseIf (ESAL.Text < 0) Then
            MsgBox("Salay can not be Negative", MsgBoxStyle.Critical, "Incorrect Data")
        Else
            Return True
        End If
        Return False
    End Function

    'SAVE or UPDATE button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ValidateData() = True) Then 'Proceed only if data is valid
            Try
                If Button1.Text = "SAVE" Then
                    'INSERT QUERY [CHANGE TABLENAME AND NAMES OF TEXT BOXES]
                    SQL = "INSERT INTO EMPLOYEE VALUES ('" & EID.Text & "', '" & ENAME.Text & "', '" & ComboBox1.Text & "', '" & ComboBox2.Text & "', '" & ESAL.Text & "', '" & imagePath & "');"
                Else
                    'UPDATE QUERY [CHANGE TABLENAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "UPDATE EMPLOYEE SET ENAME = '" & ENAME.Text & "', EGENDER = '" & ComboBox1.Text & "', EDEPARTMENT = '" & ComboBox2.Text & "', ESAL = '" & ESAL.Text & "' , EPHOTO = '" & imagePath & "' WHERE EID = " & EID.Text & ";"
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
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show() 'SHOW LOGIN FORM
    End Sub

    'CLEAR BUTTON [CHANGE NAME OF CONTROLS]
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            EID.Clear()
            ESAL.Clear()
            ENAME.Clear()
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
            EID.Text = getNextId() 'function to get next id
            findQuery = "Select * from EMPLOYEE"
            scrollValue = 0
            fillDataGrid() 'REFRESH THE DATAGRID
            Button1.Text = "SAVE"
            CRITERIA.SelectedIndex = 0
            SEARCH_VALUE.Clear()
            imagePath = defaultPic
            PictureBox1.Load(imagePath)
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'View record in text boxes, when clicked on DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    Dim EMPID As Integer = DataGridView1.SelectedRows(0).Cells(0).Value

                    'opening connection
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    'get data into data table
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM EMPLOYEE WHERE EID =" & EMPID, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    'SET VALUES IN TEXTBOXES
                    EID.Text = EMPID
                    ENAME.Text = dt.Rows(0).Item(1)
                    ComboBox1.Text = dt.Rows(0).Item(2)
                    ComboBox2.Text = dt.Rows(0).Item(3)
                    ESAL.Text = dt.Rows(0).Item(4)
                    Try
                        PictureBox1.Load(dt.Rows(0).Item(5))
                    Catch Ex As Exception
                        imagePath = defaultPic
                        PictureBox1.Load(imagePath)
                    End Try
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If Button1.Text = "SAVE" Then 'IF NO RECORD IS SELECTED
                MsgBox("Select a Record to Delete!")
            Else
                'Confirmation
                If MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
                    'DELETE QUERY [CHANGE TABLENAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "DELETE FROM EMPLOYEE WHERE EID = " & EID.Text & ";"
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
    Private Sub FILTER_Click(sender As Object, e As EventArgs) Handles FILTER.Click
        Try
            If CRITERIA.Text = "" Or SEARCH_VALUE.Text = "" Then
                findQuery = "SELECT * FROM EMPLOYEE"
            Else
                If CRITERIA.Text = "Employee Id" Then
                    findQuery = "SELECT * FROM EMPLOYEE WHERE EID = " + SEARCH_VALUE.Text + ""
                ElseIf CRITERIA.Text = "Employee Name" Then
                    findQuery = "SELECT * FROM EMPLOYEE WHERE ENAME like '" + SEARCH_VALUE.Text + "%'"
                ElseIf CRITERIA.Text = "Employee Department" Then
                    findQuery = "SELECT * FROM EMPLOYEE WHERE EDEPARTMENT like '" + SEARCH_VALUE.Text + "%'"
                Else
                    findQuery = "SELECT * FROM EMPLOYEE"
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
    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
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
            xlWorkBook.SaveAs("C:\Users\kaush\Desktop\TrialProject\" + fileName, EXCEL.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
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

    'TO LOAD PICTURE IN A PICTURE BOX
    'Add pictureBox and OpenFileDialog on Form
    Private Sub UPLOAD_IMAGE_Click(sender As Object, e As EventArgs) Handles UPLOAD_IMAGE.Click
        Try
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                imagePath = OpenFileDialog1.FileName
                If imagePath.Contains("jpg") Or imagePath.Contains("JPG") Or imagePath.Contains("jpeg") Or imagePath.Contains("JPEG") Then
                    PictureBox1.Load(imagePath)
                Else
                    imagePath = defaultPic
                    PictureBox1.Load(imagePath)
                End If
            Else
                imagePath = PictureBox1.ImageLocation
                MsgBox(imagePath)
            End If
        Catch ex As Exception
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub
End Class