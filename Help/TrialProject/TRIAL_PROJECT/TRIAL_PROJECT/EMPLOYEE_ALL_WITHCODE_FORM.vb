Imports System.Data
Imports System.Data.OleDb
Imports EXCEL = Microsoft.Office.Interop.Excel 'Click PROECT-> Add References -> Extensions -> Microsoft.Office.Interop.Excel 12.0

Public Class EMPLOYEE_ALL_WITHCODE_FORM

    Dim mypath = "C:\Users\kaush\Desktop\TrialProject\TrialProject.mdb"  'write PATH of your mdb
    Dim mypassword = ""
    'Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mypath & ";Jet OLEDB:Database Password=" & mypassword)
    Dim cmd As OleDbCommand
    Dim SQL As String
    Dim findQuery As String = "Select * from EMPLOYEE"
    Dim scrollValue As Integer = 0
    'Dim da As OleDbDataAdapter
    'Dim ds As DataSet
    Dim tables As DataTableCollection
    'Dim source1 As New BindingSource
    Dim imagePath As String
    Dim defaultPic = "C:\Users\kaush\Desktop\TrialProject\insta.jpg"

    Private Sub EMPLOYEE_ALL_WITHCODE_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TrialProjectDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.MdiParent = HOME_PAGE
        Me.EMPLOYEETableAdapter.Fill(Me.TrialProjectDataSet.EMPLOYEE)
        DataGridView1.DataSource = TrialProjectDataSet
        DataGridView1.DataMember = "EMPLOYEE"

        Try
            ComboBox1.SelectedIndex = 0
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox2.SelectedIndex = 0
            ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
            'EID.Text = getNextId() 'function to get next id
            'EID.Enabled = False
            ENAME.Focus()
            'NO_OF_RECORDS.Text = 2
            'NO_OF_RECORDS.TextAlign = HorizontalAlignment.Center
            'fillDataGrid() 'FILL THE DATA GRID VIEW
            'prepareDataGrid()
            Button1.Text = "SAVE"
            imagePath = defaultPic
            PictureBox1.Load(imagePath)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MsgBox("Exception Occured : " + ex.Message)
        End Try

    End Sub

    'ADD NEW
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TRY
            EMPLOYEEBindingSource.AddNew()
            imagePath = defaultPic
            PictureBox1.Load(imagePath)
        Catch ex As Exception
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'SAVE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            EMPLOYEEBindingSource.EndEdit()
            EMPLOYEETableAdapter.Update(TrialProjectDataSet.EMPLOYEE)
            EMPLOYEE_ALL_WITHCODE_FORM_Load(sender, e)
        Catch ex As Exception
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    'DELETE CODE
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
                EMPLOYEETableAdapter.Update(TrialProjectDataSet.EMPLOYEE)
            End If
        Catch ex As Exception
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        LOGIN_FORM.Show()
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
            MsgBox("Exception Occured : " + ex.Message)
        End Try
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button5_Click(sender, e)
    End Sub

    'View record in text boxes, when clicked on DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    Dim EMPID As Integer = DataGridView1.SelectedRows(0).Cells(0).Value

                    EMPLOYEETableAdapter.Connection.Open()
                    'get data into data table
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM EMPLOYEE WHERE EID =" & EMPID, EMPLOYEETableAdapter.Connection)
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

                    EMPLOYEETableAdapter.Connection.Close()

                End If
            Else
                MessageBox.Show("No record to be edit. Add some record first", "Edit Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            EMPLOYEETableAdapter.Connection.Close()
            MsgBox("Exception Occured : " + ex.Message)
        End Try
    End Sub

End Class