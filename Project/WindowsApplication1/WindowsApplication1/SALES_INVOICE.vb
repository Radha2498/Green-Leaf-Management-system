Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel

Public Class SALES_INVOICE
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim findQuery As String = "Select * from SALES_INVOICE"
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim availableQuantity As Integer

    Private Sub SALES_INVOIE_BILL_FORM_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            TTOTAL.Text = 0
            getSuppliePNAMEs()
            getRawMaterialNames()
            prepareDataGPID()
            CNAME.SelectedIndex = 0
            CNAME.DropDownStyle = ComboBoxStyle.DropDownList
            PNAME.SelectedIndex = 0
            PNAME.DropDownStyle = ComboBoxStyle.DropDownList
            PMODE.SelectedIndex = 0
            PMODE.DropDownStyle = ComboBoxStyle.DropDownList
            SI_ID.Text = getNextId()
            SI_ID.Enabled = False
            CNAME.Focus()
            CID.Enabled = True
            CCONTACT.Enabled = True
            CCTYPE.Enabled = True
            CMAIL.Enabled = True
            CADDRESS.Enabled = True
            PID.Enabled = True
            PRATE.Enabled = True
            SAVE.Text = "SAVE"
            DataGridView1.RowCount = 1
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'function to get next id
    Private Function getNextId()
        Dim id As Integer
        Try
            SQL = "SELECT MAX(SI_ID) FROM SALES_INVOICE"
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

    'function to get next id
    Private Function getSALES_INVOICE_details_id()
        Dim id As Integer
        Try
            SQL = "SELECT MAX(SID_ID) FROM SALES_INVOICE_DETAILS"
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

    Private Sub prepareDataGPID()
        Try
            With DataGridView1
                .ColumnCount = 7
                .AllowUserToResizeColumns = True
                .ReadOnly = True
                .ForeColor = Color.Crimson
                .BackgroundColor = Color.LightBlue
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "PLANT ID"
                .Columns(1).HeaderCell.Value = "PLANTS NAME"
                .Columns(2).HeaderCell.Value = "TYPE"
                .Columns(3).HeaderCell.Value = "SIZE"
                .Columns(4).HeaderCell.Value = "QUANTITY"
                .Columns(5).HeaderCell.Value = "RATE"
                .Columns(6).HeaderCell.Value = "TOTAL"

                'CHANGE WIDTH
                .Columns(0).Width = 200
                .Columns(1).Width = 250
                .Columns(2).Width = 200
                .Columns(3).Width = 200
                .Columns(4).Width = 200
                .Columns(5).Width = 200
                .Columns(6).Width = 200
            End With
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub prepareMAINDATAGRID()
        Try
            With DataGridView2
                .ColumnCount = 9
                .AllowUserToResizeColumns = True
                .ReadOnly = True
                .ForeColor = Color.Crimson
                .BackgroundColor = Color.LightBlue
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "SUPPLIER INVOICE ID"
                .Columns(1).HeaderCell.Value = "SUPPLIER DATE"
                .Columns(2).HeaderCell.Value = "CUSTOMER ID"
                .Columns(3).HeaderCell.Value = "CUSTOMER NAME"
                .Columns(4).HeaderCell.Value = "CUSTOMER CONTACT"
                .Columns(5).HeaderCell.Value = "PAID"
                .Columns(6).HeaderCell.Value = "BALANCE"
                .Columns(7).HeaderCell.Value = "PAYMENT MODE"

                'CHANGE WIDTH
                .Columns(0).Width = 200
                .Columns(1).Width = 250
                .Columns(2).Width = 200
                .Columns(3).Width = 200
                .Columns(4).Width = 200
                .Columns(5).Width = 200
                .Columns(6).Width = 200
                .Columns(7).Width = 150
                .Columns(8).Width = 150
            End With
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub


    Private Sub CLEAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CLEAR.Click
        Try
            SI_ID.Clear()
            CID.Clear()
            CNAME.SelectedIndex = 0
            CID.Clear()
            CCONTACT.Clear()
            PNAME.SelectedIndex = 0
            PID.Clear()
            PQTY.Clear()
            PRATE.Clear()
            PSIZE.Clear()
            PMODE.SelectedIndex = 0
            TTOTAL.Clear()
            CGST.Clear()
            SGST.Clear()
            GRAND.Clear()
            PAID.Clear()
            BALANCE.Clear()
            SI_ID.Text = getNextId()
            SAVE.Text = "SAVE"
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub getSuppliePNAMEs()
        Try
            SQL = "SELECT * FROM CUSTOMER"
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                CNAME.Items.Add(dr.Item("CNAME"))
            End While
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub getRawMaterialNames()
        Try
            SQL = "SELECT * FROM PLANTS"
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read
                PNAME.Items.Add(dr.Item("PNAME"))
            End While
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub CNAME_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CNAME.SelectedIndexChanged
        If CNAME.Text <> "" And CNAME.Text <> "SELECT CUSTOMER NAME" Then
            Try
                SQL = "SELECT * FROM CUSTOMER WHERE CNAME='" + CNAME.Text + "'"
                cmd = New OleDbCommand(SQL, conn)
                conn.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    CID.Text = dr.Item("CID")
                    CCONTACT.Text = dr.Item("CCONTACT")
                    CCTYPE.Text = dr.Item("CTYPE")
                    CMAIL.Text = dr.Item("CMAIL")
                    CADDRESS.Text = dr.Item("CADDRESS")
                End While
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MsgBox("Exception Occured : " + ex.Message)
            End Try
        End If
    End Sub


    Private Sub PNAME_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles PNAME.SelectedIndexChanged
        If PNAME.Text <> "" And PNAME.Text <> "SELECT PLANT NAME" Then
            Try
                SQL = "SELECT * FROM PLANTS WHERE PNAME='" + PNAME.Text + "'"
                cmd = New OleDbCommand(SQL, conn)
                conn.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    PID.Text = dr.Item("PID")
                    PQTY.Text = dr.Item("PQTY")
                    PTYPE.Text = dr.Item("PTYPE")
                    PRATE.Text = dr.Item("PRATE")
                    PSIZE.Text = dr.Item("PSIZE")
                    availableQuantity = PQTY.Text
                End While
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MsgBox("Exception Occured : " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub TTOTAL_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TTOTAL.TextChanged
        CGST.Text = 0.09 * Val(TTOTAL.Text)
        SGST.Text = 0.09 * Val(TTOTAL.Text)
        GRAND.Text = Val(CGST.Text) + Val(SGST.Text) + Val(TTOTAL.Text)
    End Sub

    Private Sub paid_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles PAID.TextChanged
        BALANCE.Text = Val(GRAND.Text) - Val(PAID.Text)
    End Sub
    Private Sub EXIT_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EEXIT.Click
        Me.Close()
    End Sub

    Private Sub SAVE_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SAVE.Click
        If (ValidateData() = True) Then
            Try
                'save record in SALES_INVOICE
                If SAVE.Text = "SAVE" Then
                    'INSERT QUERY 
                    SQL = "INSERT INTO SALES_INVOICE VALUES ('" & SI_ID.Text & "', '" & SDATE.Value & "', '" & CID.Text & "','" & CNAME.Text & "','" & CCONTACT.Text & "','" & PAID.Text & "','" & BALANCE.Text & "','" & TTOTAL.Text & "','" & PMODE.Text & "');"
                Else
                    'UPDATE QUERY
                    SQL = "UPDATE SALES_INVOICE SET SI_ID = '" & SI_ID.Text & "',  SDATE= '" & SDATE.Text & "', CID= '" & CID.Text & "', CNAME= '" & CNAME.Text & "',CCONTACT = '" & CCONTACT.Text & "', PAID = '" & PAID.Text & "', BALANCE = '" & BALANCE.Text & "', TTOTAL = '" & TTOTAL.Text & "' PMODE = '" & PMODE.Text & "' WHERE SI_ID = " & SI_ID.Text & ";"
                End If
                'MsgBox(SQL) 'REMOVE THIS LATER
                conn.Open()
                cmd = New OleDbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()

                'save in SALES_INVOICE_DETAILS now
                Dim r As Integer
                With DataGridView1
                    r = 0
                    Do While r < .RowCount - 1
                        SQL = "INSERT INTO SALES_INVOICE_DETAILS VALUES ('" & getSALES_INVOICE_details_id() & "', '" & SI_ID.Text & "', '" & .Rows(r).Cells(0).Value & "', '" & .Rows(r).Cells(1).Value & "', '" & .Rows(r).Cells(2).Value & "','" & .Rows(r).Cells(3).Value & "','" & .Rows(r).Cells(4).Value & "','" & .Rows(r).Cells(5).Value & "','" & .Rows(r).Cells(6).Value & "');"
                        MsgBox(SQL) 'REMOVE THIS LATER
                        conn.Open()
                        cmd = New OleDbCommand(SQL, conn)
                        cmd.ExecuteNonQuery()
                        'update the quantity in Raw material table
                        SQL = "UPDATE PLANTS SET PQTY =PQTY+" & .Rows(r).Cells(4).Value & " WHERE PID = " & .Rows(r).Cells(0).Value & ";"
                        'MsgBox(SQL) 'REMOVE THIS LATER

                        cmd = New OleDbCommand(SQL, conn)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        conn.Close()
                        r = r + 1
                    Loop
                End With

                MsgBox("Saved Successfully..!")

                Call CLEAR_Click(sender, e)
            Catch ex As Exception
                conn.Close()
                MsgBox("Exception Occured : " + ex.Message)
            End Try
        End If
    End Sub

    Private Function ValidateData()
        If (SI_ID.Text = "" Or CNAME.Text = "" Or SDATE.Text = "" Or CID.Text = "" Or CCONTACT.Text = "" Or PMODE.Text = "" Or TTOTAL.Text = "" Or CGST.Text = "" Or SGST.Text = "" Or GRAND.Text = "" Or PAID.Text = "" Or BALANCE.Text = "" Or PMODE.Text = "") Then
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
            'ElseIf (CCONTACT.Text.Length <> 10) Then
            'MsgBox("Contact number must be 10 digits", MsgBoxStyle.Critical, "Incorrect Data")
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Val(PQTY.Text <= availableQuantity) Then
                Dim row As String() = New String() {PID.Text, PNAME.Text, PTYPE.Text, PSIZE.Text, PQTY.Text, PRATE.Text, PQTY.Text * PRATE.Text}
                DataGridView1.Rows.Add(row)
                TTOTAL.Text = TTOTAL.Text + (PQTY.Text * PRATE.Text)
                PAID.Clear()
                PAID.Text = 0
                PNAME.SelectedIndex = 0
                PID.Clear()
                PQTY.Clear()
                PRATE.Clear()
            Else
                MsgBox("Stock not available! Max Quantity = " & availableQuantity)
            End If
        Catch ex As Exception
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            If ComboBox2.Text = "" Or CRITERIA.Text = "" Then
                findQuery = "SELECT * FROM SALES_INVOICE"
            Else
                If ComboBox2.Text = "SALES INVOICE ID" Then
                    findQuery = "SELECT * FROM SALES_INVOICE WHERE SI_ID = " + CRITERIA.Text + ""
                ElseIf ComboBox2.Text = "CUSTOMER NAME" Then
                    findQuery = "SELECT * FROM SALES_INVOICE WHERE CNAME like '" + CRITERIA.Text + "%'"
                Else
                    findQuery = "SELECT * FROM SALES_INVOICE"
                End If
            End If
            fillDataGrid() 'FILL THE DATA GRID VIEW
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub
    Private Sub fillDataGrid()
        Try
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter(findQuery, conn)
            'fetch next 10 records only 
            'use da.Fill(ds, "SALES_INVOIE") to fetch all at once
            da.Fill(ds, findQuery)
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView2.DataSource = view

        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class

