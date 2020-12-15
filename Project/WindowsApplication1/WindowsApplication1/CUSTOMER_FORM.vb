Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel 'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0

Public Class CUSTOMER_FORM
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from CUSTOMER"

    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim imagePath As String
    Dim defaultPic = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Project\DEFAULT.jpg"

    'FORM LOAD [CHANGE NAME OF CONTROLS]
    Private Sub CUSTOMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBox1.SelectedIndex = 0
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

            CID.Text = getNextId() 'function to get next id
            CID.Enabled = False
            CNAME.Focus()

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
            SQL = "SELECT MAX(CID) FROM CUSTOMER"
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
            .Columns(0).HeaderCell.Value = "Customer No."
            .Columns(1).HeaderCell.Value = "Name"
            .Columns(2).HeaderCell.Value = "Contact"
            .Columns(3).HeaderCell.Value = "Type"
            .Columns(4).HeaderCell.Value = "Email"
            .Columns(5).HeaderCell.Value = "Address"


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
            'use da.Fill(ds, "CUSTOMER") to fetch all at once
            da.Fill(ds, "CUSTOMER")
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
                    SQL = "INSERT INTO CUSTOMER VALUES ('" & CID.Text & "', '" & CNAME.Text & "', '" & CCONTACT.Text & "', '" & CCTYPE.Text & "', '" & CEMAIL.Text & "', '" & CADDRESS.Text & "' );"
                Else
                    'UPDATE QUERY [CHANGE TABLPNAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "UPDATE CUSTOMER SET CNAME = '" & CNAME.Text & "', CCONTACT = '" & CCONTACT.Text & "', CTYPE = '" & CCTYPE.Text & "', CEMAIL = '" & CEMAIL.Text & "' , CADDRESS = '" & CADDRESS.Text & "'WHERE CID = " & CID.Text & ";"
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
    Private Function ValidateData()

        'check if all textboxes are filled
        If (CID.Text = "" Or CNAME.Text = "" Or CADDRESS.Text = "" Or CCONTACT.Text = "" Or CEMAIL.Text = "") Then
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
            Return False

            'contact number must be exact 10 digits
        ElseIf (CCONTACT.Text.Length <> 10) Then
            MsgBox("Contact number must be 10 digits", MsgBoxStyle.Critical, "Incorrect Data")
            Return False

            'validate email
        ElseIf CEMAIL.Text <> "" Then
            Try
                Dim vEmailAddress As New System.Net.Mail.MailAddress(CEMAIL.Text)
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

    'Close or Cancel button
    Private Sub BUTTON5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        MDIFORM.Show() 'SHOW LOGIN FORM
    End Sub

    'CLEAR BUTTON [CHANGE NAME OF CONTROLS]
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            CID.Clear()
            'ESAL.Clear()
            CNAME.Clear()
            CADDRESS.Clear()
            CCTYPE.Clear()
            CCONTACT.Clear()
            CEMAIL.Clear()
            ComboBox1.SelectedIndex = 0
            'ComboBox2.SelectedIndex = 0
            CID.Text = getNextId() 'function to get next id
            findQuery = "Select * from CUSTOMER"
            fillDataGrid() 'REFRESH THE DATAGRID
            Button1.Text = "SAVE"
            ComboBox1.SelectedIndex = 0
            SEARCH_VALUE.Clear()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'View record in text boxes, when clicked on DataGridView
    Private Sub DataGridView1_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    Dim EMPID As Integer = DataGridView1.SelectedRows(0).Cells(0).Value

                    'opening connection
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    'get data into data table
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM CUSTOMER WHERE CID =" & EMPID, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    'SET VALUES IN TEXTBOXES
                    CID.Text = EMPID
                    CNAME.Text = dt.Rows(0).Item(1)
                    CCONTACT.Text = dt.Rows(0).Item(2)
                    CCTYPE.Text = dt.Rows(0).Item(3)
                    CEMAIL.Text = dt.Rows(0).Item(4)
                    CADDRESS.Text = dt.Rows(0).Item(5)
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
                    'DELETE QUERY [CHANGE TABLPNAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "DELETE FROM CUSTOMER WHERE CID = " & CID.Text & ";"
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
            If ComboBox1.Text = "" Or SEARCH_VALUE.Text = "" Then
                findQuery = "SELECT * FROM CUSTOMER"
            Else
                If ComboBox1.Text = "Customer Id" Then
                    findQuery = "SELECT * FROM CUSTOMER WHERE CID = " + SEARCH_VALUE.Text + ""
                ElseIf ComboBox1.Text = "Customer Name" Then
                    findQuery = "SELECT * FROM CUSTOMER WHERE CNAME like '" + SEARCH_VALUE.Text + "%'"
                Else
                    findQuery = "SELECT * FROM CUSTOMER"
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

            Dim filPNAME As String = InputBox("Enter The File Name : ", "File Name", ".xls")
            If Not filPNAME.EndsWith(".xls") Then
                filPNAME = filPNAME + ".xls"
            End If

            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            da.Fill(ds, "CUSTOMER")
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

    Private Sub CNAME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CNAME.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form2.Show()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

