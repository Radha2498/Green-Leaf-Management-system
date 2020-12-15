Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel

Public Class PURCHASE_INVOICE
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim findQuery As String = "Select * from PURCHASE_INVOICE"
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim availableQuantity As Integer

    Private Sub PURCHASE_INVOICE_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            TOTAL.Text = 0
            PAID.Text = 0
            getSupplierNames()
            getRawMaterialNames()
            prepareDataGrid()
            PI_ID.Text = getNextId()
            PI_ID.Enabled = True
            PI_ID.Enabled = True
            SCONTACT.Enabled = True
            PNAME.Enabled = True
            PRATE.Enabled = True
            SAVE_BUTTON.Text = "SAVE"
            DataGridView1.RowCount = 1

            SNAME.SelectedIndex = 0
            SNAME.DropDownStyle = ComboBoxStyle.DropDownList
            PNAME.SelectedIndex = 0
            PNAME.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox1.SelectedIndex = 0
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'function to get next id
    Private Function getNextId()
        Dim id As Integer
        Try
            SQL = "SELECT MAX(PI_ID) FROM PURCHASE_INVOICE"
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
    Private Function getPurchase_invoice_details_id()
        Dim id As Integer
        Try
            SQL = "SELECT MAX(PU_ID) FROM PURCHASE_INVOICE_DETAILS"
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

    Private Sub prepareDataGrid()
        Try
            With DataGridView1
                .ColumnCount = 7
                .AllowUserToResizeColumns = True
                .ReadOnly = True
                .ForeColor = Color.Crimson
                .BackgroundColor = Color.LightBlue
                .GridColor = Color.Azure
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "PLANTS ID"
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

    Private Sub getSupplierNames()
        Try
            SQL = "SELECT * FROM SUPPLIER"
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                SNAME.Items.Add(dr.Item("SNAME"))
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

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SNAME.SelectedIndexChanged
        Try
            SQL = "SELECT * FROM SUPPLIER WHERE SNAME='" + SNAME.Text + "'"
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read
                SID.Text = dr.Item("SID")
                SCONTACT.Text = dr.Item("SCONTACT")
                SEMAIL.Text = dr.Item("SEMAIL")
                SCITY.Text = dr.Item("SCITY")
                SADDRESSS.Text = dr.Item("SADDREESS")
                SUPPLIES.Text = dr.Item("SUPPLIES")
            End While
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub


    Private Sub PNAME_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles PNAME.SelectedIndexChanged
        Try
            SQL = "SELECT * FROM PLANTS WHERE PNAME='" + PNAME.Text + "'"
            cmd = New OleDbCommand(SQL, conn)
            conn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read
                PID.Text = dr.Item("PID")
                PQTY.Text = dr.Item("PQTY")
                PTYPE.Text = dr.Item("PTYPE")
                PSIZE.Text = dr.Item("PSIZE")
                PQTY.Text = dr.Item("PQTY")
                PRATE.Text = dr.Item("PRATE")

                availableQuantity = PQTY.Text
            End While
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub TOTAL_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TOTAL.TextChanged
        CGST.Text = 0.09 * Val(TOTAL.Text)
        SGST.Text = 0.09 * Val(TOTAL.Text)
        GRAND.Text = Val(CGST.Text) + Val(SGST.Text) + Val(TOTAL.Text)
    End Sub

    Private Sub PAID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles PAID.TextChanged
        SBALANCE.Text = Val(GRAND.Text) - Val(PAID.Text)
    End Sub
    Private Sub SAVE_BUTTON_CLICK(ByVal sender As Object, ByVal e As EventArgs) Handles SAVE_BUTTON.Click
        If (ValidateData() = True) Then
            Try
                'save record in PURCHASE_INVOICE
                If SAVE_BUTTON.Text = "SAVE" Then
                    'INSERT QUERY 
                    SQL = "INSERT INTO PURCHASE_INVOICE VALUES ('" & PI_ID.Text & "', '" & SDATE.Value & "', '" & SID.Text & "','" & SNAME.Text & "','" & SCONTACT.Text & "','" & TOTAL.Text & "','" & PAID.Text & "','" & SBALANCE.Text & "');"
                Else
                    'UPDATE QUERY
                    SQL = "UPDATE PURCHASE_INVOICE SET PI_ID = '" & PI_ID.Text & "', SDATE = '" & SDATE.Text & "', SID= '" & SID.Text & "', SNAME= '" & SID.Text & "',SCONTACT= '" & SCONTACT.Text & "', TOTAL = '" & TOTAL.Text & "', PAID = '" & PAID.Text & "', BALANCE = '" & SBALANCE.Text & "', & " ' WHERE P_ID = " & SI_ID.Text & ";")
                End If
                'MsgBox(SQL) 'REMOVE THIS LATER
                conn.Open()
                cmd = New OleDbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()

                'save in PURCHASE_INVOICE_DETAILS now
                Dim r As Integer
                With DataGridView1
                    r = 0
                    Do While r < .RowCount - 1
                        SQL = "INSERT INTO PURCHASE_INVOICE_DETAILS VALUES ('" & getPurchase_invoice_details_id() & "', '" & PI_ID.Text & "', '" & .Rows(r).Cells(0).Value & "', '" & .Rows(r).Cells(1).Value & "', '" & .Rows(r).Cells(2).Value & "','" & .Rows(r).Cells(3).Value & "','" & .Rows(r).Cells(4).Value & "','" & .Rows(r).Cells(5).Value & "','" & .Rows(r).Cells(6).Value & "');"
                        MsgBox(SQL) 'REMOVE THIS LATER
                        conn.Open()
                        cmd = New OleDbCommand(SQL, conn)
                        cmd.ExecuteNonQuery()
                        'update the quantity in Raw material table
                        SQL = "UPDATE PLANTS SET PQTY = PQTY+" & .Rows(r).Cells(4).Value & " WHERE PID = " & .Rows(r).Cells(0).Value & ";"
                        'MsgBox(SQL) 'REMOVE THIS LATER

                        cmd = New OleDbCommand(SQL, conn)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        conn.Close()
                        r = r + 1
                    Loop
                End With

                MsgBox("Details Saved Successfully..!")

                Call Button5_CLICK(sender, e)
            Catch ex As Exception
                conn.Close()
                MsgBox("Exception Occured : " + ex.Message)
            End Try
        End If
    End Sub

    Private Function ValidateData()
        If (PI_ID.Text = "" Or SNAME.Text = "" Or SDATE.Text = "" Or SID.Text = "" Or SCONTACT.Text = "" Or TOTAL.Text = "" Or CGST.Text = "" Or SGST.Text = "" Or GRAND.Text = "" Or PAID.Text = "" Or SBALANCE.Text = "") Then
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Critical, "Fields Empty")
            'ElseIf (scont.Text.Length <> 10) Then
            'MsgBox("Contact number must be 10 digits", MsgBoxStyle.Critical, "Incorrect Data")
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim row As String() = New String() {PID.Text, PNAME.Text, PTYPE.Text, PSIZE.Text, PQTY.Text, PRATE.Text, PQTY.Text * PRATE.Text}
            DataGridView1.Rows.Add(row)
            TOTAL.Text = TOTAL.Text + (PQTY.Text * PRATE.Text)
            PAID.Clear()
            PAID.Text = 0
            PNAME.SelectedIndex = 0
            PID.Clear()
            PQTY.Clear()
            PRATE.Clear()
        Catch ex As Exception
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            PI_ID.Clear()
            SID.Clear()
            SNAME.SelectedIndex = 0
            SID.Clear()
            SCONTACT.Clear()
            PNAME.SelectedIndex = 0
            PID.Clear()
            PQTY.Clear()
            PRATE.Clear()
            TOTAL.Clear()
            CGST.Clear()
            SGST.Clear()
            GRAND.Clear()
            PAID.Clear()
            SBALANCE.Clear()
            PI_ID.Text = getNextId()
            SAVE_BUTTON.Text = "SAVE"
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

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            If ComboBox1.Text = "" Or CRITERIA.Text = "" Then
                findQuery = "SELECT * FROM PURCHASE_INVOICE"
            Else
                If ComboBox1.Text = "PURCHASE_INVOICE_ID" Then
                    findQuery = "SELECT * FROM PURCHASE_INVOICE WHERE PI_ID = " + CRITERIA.Text + ""
                ElseIf ComboBox1.Text = "SUPPLIER NAME" Then
                    findQuery = "SELECT * FROM PURCHASE_INVOICE WHERE SNAME like '" + CRITERIA.Text + "%'"
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class

