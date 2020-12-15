Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel 'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0

Public Class PLANTS
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from PLANTS"

    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim imagePath As String
    Dim defaultPic = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Project\DEFAULT.jpg"

    'FORM LOAD [CHANGE NAME OF CONTROLS]
    Private Sub PLANTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CRITERIA.SelectedIndex = 0
            CRITERIA.DropDownStyle = ComboBoxStyle.DropDownList

            PID.Text = getNextId() 'function to get next id
            PID.Enabled = False
            PNAME.Focus()

            fillDataGrid() 'FILL THE DATA GRID VIEW
            prepareDataGrid()
            Button1.Text = "SAVE"
            imagePath = defaultPic
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
            SQL = "SELECT MAX(PID) FROM PLANTS"
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
            .Columns(0).HeaderCell.Value = "Plant No."
            .Columns(1).HeaderCell.Value = "Name"
            .Columns(2).HeaderCell.Value = "Quantity"
            .Columns(3).HeaderCell.Value = "Type"
            .Columns(4).HeaderCell.Value = "Rate"
            .Columns(5).HeaderCell.Value = "Size"
            .Columns(6).HeaderCell.Value = "Color"

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
            'use da.Fill(ds, "PLANTS") to fetch all at once
            da.Fill(ds, "PLANTS")
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
        'If (PID.Text = "" Or ESAL.Text = "" Or PNAME.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "") Then 'IF ANY FIELD IS EMPTY
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
                    'INSERT QUERY [CHANGE TABLPNAME AND NAMES OF TEXT BOXES]
                    SQL = "INSERT INTO PLANTS VALUES ('" & PID.Text & "', '" & PNAME.Text & "', '" & PQTY.Text & "', '" & PTYPE.Text & "', '" & PRATE.Text & "', '" & PSIZE.Text & "', '" & PCOLOR.Text & "');"
                Else
                    'UPDATE QUERY [CHANGE TABLPNAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "UPDATE PLANTS SET PNAME = '" & PNAME.Text & "', PQTY = '" & PQTY.Text & "', PTYPE = '" & PTYPE.Text & "', PRATE = '" & PRATE.Text & "' , PSIZE = '" & PSIZE.Text & "' , PCOLOR = '" & PCOLOR.Text & "' WHERE PID = " & PID.Text & ";"
                End If
                'MsgBox(SQL) 'REMOVE THIS LATER
                conn.Open()
                cmd = New OleDbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Saved Successfully..!")
                cmd.Dispose()
                conn.Close()
                Call Button3_Click(sender, e)
            Catch ex As Exception
                conn.Close()
                MsgBox("Exception Occured : " + ex.Message)
            End Try
        End If
    End Sub

    'Close or Cancel button
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Form1.Show() 'SHOW LOGIN FORM
    End Sub

    'CLEAR BUTTON [CHANGE NAME OF CONTROLS]
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Try
            PID.Clear()
            'ESAL.Clear()
            PNAME.Clear()
            PQTY.Clear()
            PSIZE.Clear()
            PTYPE.Clear()
            PCOLOR.Clear()
            PRATE.Clear()
            CRITERIA.SelectedIndex = 0
            'ComboBox2.SelectedIndex = 0
            PID.Text = getNextId() 'function to get next id
            findQuery = "Select * from PLANTS"
            fillDataGrid() 'REFRESH THE DATAGRID
            Button1.Text = "SAVE"
            CRITERIA.SelectedIndex = 0
            SEARCH_VALUE.Clear()
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
                    Dim EMPID As Integer = DataGridView1.SelectedRows(0).Cells(0).Value

                    'opening connection
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    'get data into data table
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM PLANTS WHERE PID =" & EMPID, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    'SET VALUES IN TEXTBOXES
                    PID.Text = EMPID
                    PNAME.Text = dt.Rows(0).Item(1)
                    PQTY.Text = dt.Rows(0).Item(2)
                    PTYPE.Text = dt.Rows(0).Item(3)
                    PRATE.Text = dt.Rows(0).Item(4)
                    PSIZE.Text = dt.Rows(0).Item(5)
                    PCOLOR.Text = dt.Rows(0).Item(6)
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
    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Try
            If Button1.Text = "SAVE" Then 'IF NO RECORD IS SELECTED
                MsgBox("Select a Record to Delete!")
            Else
                'Confirmation
                If MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
                    'DELETE QUERY [CHANGE TABLPNAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "DELETE FROM PLANTS WHERE PID = " & PID.Text & ";"
                    conn.Open()
                    cmd = New OleDbCommand(SQL, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted Successfully..!")
                    cmd.Dispose()
                    conn.Close()
                    Call Button3_Click(sender, e)
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
            If CRITERIA.Text = "" Or SEARCH_VALUE.Text = "" Then
                findQuery = "SELECT * FROM CUSTOMER"
            Else
                If CRITERIA.Text = "Plant Id" Then
                    findQuery = "SELECT * FROM PLANTS WHERE PID = " + SEARCH_VALUE.Text + ""
                ElseIf CRITERIA.Text = "Plant Name" Then
                    findQuery = "SELECT * FROM PLANTS WHERE PNAME like '" + SEARCH_VALUE.Text + "%'"
                Else
                    findQuery = "SELECT * FROM PLANTS"
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
        Dim xlApp As EXCEL.Application
        Dim xlWorkBook As EXCEL.Workbook
        Dim xlWorkSheet As EXCEL.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Int16, j As Int16

        Try
            xlApp = New EXCEL.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            Dim filPNAME As String = InputBox("Enter The File Name : ", "File Name", ".xls")
            If Not filPNAME.EndsWith(".xls") Then
                filPNAME = filPNAME + ".xls"
            End If

            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            da.Fill(ds, "PLANTS")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view

            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next

            'Change Only the path here
            xlWorkBook.SaveAs("C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Document\" + filPNAME, EXCEL.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PLANTS_Load(sender, e)
    End Sub
    Private Sub PNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNAME.TextChanged
        'Check if a textbox is not blank
        If Len(Trim(PNAME.Text)) = 0 Then
            MessageBox.Show("Enter the Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            PNAME.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PLANT_REPORT.Show()
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

