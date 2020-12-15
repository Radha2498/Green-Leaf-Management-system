Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel 'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0

Public Class DELIVERY
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from DELIVERY"

    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim imagePath As String
    Dim defaultPic = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Project\DEFAULT.jpg"

    Private Sub getVendorIds()
        Try
            SQL = "SELECT * FROM VENDOR"
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                VID.Items.Add(dr.Item("VID"))
            End While
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub getSalesInvoiceIds()
        Try
            SQL = "SELECT * FROM SALES_INVOICE"
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                SI_ID.Items.Add(dr.Item("SI_ID"))
            End While
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'FORM LOAD [CHANGE NAME OF CONTROLS]
    Private Sub DELIVERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DID.Text = getNextId() 'function to get next id
            DID.Enabled = False
            getVendorIds()
            getSalesInvoiceIds()
            ComboBox1.SelectedIndex = 0
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
            VNAME.Focus()
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
            SQL = "SELECT MAX(DID) FROM DELIVERY"
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
            .Columns(0).HeaderCell.Value = "DELIVERY No."
            .Columns(1).HeaderCell.Value = "DELIVERY DATE"
            .Columns(2).HeaderCell.Value = "SUPPLIER INVOICE ID"
            .Columns(3).HeaderCell.Value = "VENDOR ID"
            .Columns(4).HeaderCell.Value = "VENDOR ADDRESS"
            .Columns(5).HeaderCell.Value = "COST OF DELIVERY"
            .Columns(5).HeaderCell.Value = "STATUS"


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
            'use da.Fill(ds, "DELIVERY") to fetch all at once
            da.Fill(ds, "DELIVERY")
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
                    SQL = "INSERT INTO DELIVERY VALUES ('" & DID.Text & "','" & D_DATE.Value.Date & "','" & SI_ID.Text & "','" & VID.Text & "','" & VNAME.Text & "','" & DADDRESS.Text & "', '" & COD.Text & "','" & SSTATUS.Text & "' );"
                Else
                    'UPDATE QUERY [CHANGE TABLPNAME, COLUMN NAMES AND NAMES OF TEXT BOXES]
                    SQL = "UPDATE DELIVERY SET VNAME = '" & VNAME.Text & "', VDATE = '" & D_DATE.Value.Date & "',SI_ID = '" & SI_ID.Text & "',DADDRESS = '" & DADDRESS.Text & "',SSTATUS = '" & SSTATUS.Text & "' , COD = '" & COD.Text & "' , WHERE VID = " & VID.Text & ";"
                End If
                'REMOVE THIS LATER
                conn.Open()
                cmd = New OleDbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Delivery details Saved Successfully..!")
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
        If (DID.Text = "" Or VNAME.Text = "" Or ComboBox1.Text = "") Then 'IF ANY FIELD IS EMPTY
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
        Else
            Return True
        End If
        Return False
    End Function


    'Close or Cancel button
    Private Sub BUTTON5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show() 'SHOW LOGIN FORM
    End Sub

    'CLEAR BUTTON [CHANGE NAME OF CONTROLS]
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            'ESAL.Clear()
            VNAME.Clear()
            DADDRESS.Clear()
            COD.Clear()
            ComboBox1.SelectedIndex = 0
            'ComboBox2.SelectedIndex = 0
            DID.Text = getNextId() 'function to get next id
            findQuery = "Select * from DELIVERY"
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
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM DELIVERY WHERE DID =" & EMPID, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    'SET VALUES IN TEXTBOXES
                    DID.Text = EMPID
                    D_DATE.Value = dt.Rows(0).Item(1)
                    SI_ID.Text = dt.Rows(0).Item(2)
                    VID.Text = dt.Rows(0).Item(3)
                    VNAME.Text = dt.Rows(0).Item(4)
                    DADDRESS.Text = dt.Rows(0).Item(5)
                    COD.Text = dt.Rows(0).Item(6)
                    SSTATUS.Text = dt.Rows(0).Item(7)
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
                    SQL = "DELETE FROM DELIVERY WHERE DID = " & DID.Text & ";"
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
    Private Sub SEARCH_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SEARCH.Click
        Try
            If ComboBox1.Text = "" Or CRITERIA.Text = "" Then
                findQuery = "SELECT * FROM DELIVERY"
            Else
                If ComboBox1.Text = "Delivery Id" Then
                    findQuery = "SELECT * FROM DELIVERY WHERE DID = " + CRITERIA.Text + ""
                ElseIf ComboBox1.Text = "Vendor Name" Then
                    findQuery = "SELECT * FROM DELIVERY WHERE VNAME like '" + CRITERIA.Text + "%'"
                Else
                    findQuery = "SELECT * FROM DELIVERY"
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
            da.Fill(ds, "DELIVERY")
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

    Private Sub VNAME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VNAME.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DID.TextChanged

    End Sub

    Private Sub VID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VID.SelectedIndexChanged
        Try
            SQL = "SELECT * FROM VENDOR WHERE VID=" + VID.Text + ""
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read
                VNAME.Text = dr.Item("VNAME")
            End While
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

















