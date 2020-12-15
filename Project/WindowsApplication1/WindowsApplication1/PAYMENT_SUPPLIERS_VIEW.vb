Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel

Public Class PAYMENT_SUPPLIERS_VIEW
    Dim mypath = "C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Database\GREEN.mdb"
    Dim mypassword = ""
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from PAYMENT"
    Dim scrollValue As Integer = 0
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub PAYMENT_SUPPLIERS_VIEW_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            CRITERIA.SelectedIndex = 0
            CRITERIA.DropDownStyle = ComboBoxStyle.DropDownList
            pid.Enabled = False
            sid.Enabled = False
            piid.Enabled = False
            sname.Enabled = False
            pdate.Enabled = False
            currbal.Enabled = False
            ppaid.Enabled = False
            upbal.Enabled = False
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
            .Columns(0).HeaderCell.Value = "Payment ID"
            .Columns(1).HeaderCell.Value = "Date"
            .Columns(2).HeaderCell.Value = "Purchase invoice Id"
            .Columns(3).HeaderCell.Value = "Supplier's Id"
            .Columns(4).HeaderCell.Value = "Supplier's Name"
            .Columns(5).HeaderCell.Value = "Current Balance"
            .Columns(6).HeaderCell.Value = "Paid"
            .Columns(7).HeaderCell.Value = "Updated Balance"

            'CHANGE WIDTH
            .Columns(0).Width = 100
            .Columns(1).Width = 100
            .Columns(2).Width = 200
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            .Columns(5).Width = 100
            .Columns(6).Width = 100
            .Columns(7).Width = 100
        End With
    End Sub

    Private Sub EXIT_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EXIT_BUTTON.Click
        Me.Close()
        'MDIParent1.Show()
    End Sub

    Private Sub CLOSE_BUTTON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CLOSE_BUTTON.Click
        GroupBox1.Visible = False
    End Sub

    'View record in text boxes, when clicked on DataGridView
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    Dim COID As Integer = DataGridView1.SelectedRows(0).Cells(0).Value

                    'opening connection
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    'get data into data table
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM PAYMENT WHERE PID =" & COID, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    'SET VALUES IN TEXTBOXES
                    pid.Text = COID
                    GroupBox1.Visible = True
                    pid.Text = dt.Rows(0).Item(0)
                    sid.Text = dt.Rows(0).Item(3)
                    sname.Text = dt.Rows(0).Item(4)
                    piid.Text = dt.Rows(0).Item(2)
                    pdate.Text = dt.Rows(0).Item(1)
                    currbal.Text = dt.Rows(0).Item(5)
                    ppaid.Text = dt.Rows(0).Item(6)
                    upbal.Text = dt.Rows(0).Item(7)
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
            If CRITERIA.Text = "Select a Criteria" Or SEARCH_VALUE.Text = "" Then
                MsgBox("Select a Criteria", MsgBoxStyle.Exclamation, "Error")
                findQuery = "SELECT * FROM PAYMENT"
            Else
                If CRITERIA.Text = "Payment ID" Then
                    findQuery = "SELECT * FROM PAYMENT WHERE PID = " + SEARCH_VALUE.Text + ""
                ElseIf CRITERIA.Text = "Supplier's ID" Then
                    findQuery = "SELECT * FROM PAYMENT WHERE SID = " + SEARCH_VALUE.Text + ""
                ElseIf CRITERIA.Text = "Supplier's Name" Then
                    findQuery = "SELECT * FROM PAYMENT WHERE SNAME like '" + SEARCH_VALUE.Text + "%'"
                ElseIf CRITERIA.Text = "Purchase Invoice ID" Then
                    findQuery = "SELECT * FROM PAYMENT WHERE SI_ID like '" + SEARCH_VALUE.Text + "%'"
                ElseIf CRITERIA.Text = "Date" Then
                    findQuery = "SELECT * FROM PAYMENT WHERE P_DATE like '" + SEARCH_VALUE.Text + "%'"
                ElseIf CRITERIA.Text = "Balance" Then
                    findQuery = "SELECT * FROM PAYMENT WHERE UPDATED_BALANCE > " + SEARCH_VALUE.Text + ""
                Else
                    findQuery = "SELECT * FROM PAYMENT"
                End If
            End If
            fillDataGrid()
        Catch ex As Exception
            conn.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub
End Class
