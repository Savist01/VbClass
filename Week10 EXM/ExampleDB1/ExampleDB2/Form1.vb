Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constr As String ' = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"'
        constr = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"

        Dim conn As New SqlConnection(constr)

        conn.Open()

        Dim sql As String = "select * 
                             from categories
                             where description like 'S%'"
        Dim cmd As New SqlCommand(sql, conn) 'คำสั่ง , Connection'

        Dim adapter As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "WTF") 'dataset + ชื่ออ้างอิง'

        'MsgBox(data.Tables("WTF").Rows.Count)'
        'MsgBox(data.Tables("WTF").columns.Count)'
        'MsgBox(data.Tables("WTF").Columns(1).ToString)'
        'MsgBox(data.Tables("WTF").Rows(0)("CategoryID"))'

        DataGridView1.DataSource = data.Tables("WTF")

        For i = 0 To data.Tables("WTF").Rows.Count - 1
            ListBox1.Items.Add(data.Tables("WTF").Rows(i)("categoryname"))
        Next

        conn.Close()
    End Sub


End Class
