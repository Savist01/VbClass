Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constr As String ' = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"'
        constr = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"
        'bjhgjh'
        Dim conn As New SqlConnection(constr)

        conn.Open()

        Dim sql As String = "select DISTINCT Country
                             from Customers
                             order by country"
        Dim cmd As New SqlCommand(sql, conn) 'คำสั่ง , Connection'

        Dim adapter As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "GG") 'dataset + ชื่ออ้างอิง'

        For i = 0 To data.Tables("GG").Rows.Count - 1
            ComboCountry.Items.Add(data.Tables("GG").Rows(i)("Country"))
        Next

        DataGridView1.DataSource = data.Tables("WTF")

        '------------------------------------------------------------------------------------------------------'

        conn.Close()

    End Sub

    Private Sub ComboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCountry.SelectedIndexChanged
        ComboCity.Items.Clear()
        ComboCity.Enabled = True
        Dim constr As String ' = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"'
        constr = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"

        Dim conn As New SqlConnection(constr)

        conn.Open()
        Dim sql2 As String = "select DISTINCT city
                             from Customers
                             where country = '" & ComboCountry.Text & "'
                             order by city"
        Dim cmd2 As New SqlCommand(sql2, conn) 'คำสั่ง , Connection'
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim data2 As New DataSet()
        adapter2.Fill(data2, "GG") 'dataset + ชื่ออ้างอิง'

        For i = 0 To data2.Tables("GG").Rows.Count - 1
            ComboCity.Items.Add(data2.Tables("GG").Rows(i)("city"))
        Next
        conn.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim constr As String ' = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"'
        constr = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"

        Dim conn As New SqlConnection(constr)

        conn.Open()

        Dim sql As String = "select companyname,contactname,phone 
                             from customers
                             where country = '" & ComboCountry.Text & "' and city = '" & ComboCity.Text & "'"
        Dim cmd As New SqlCommand(sql, conn) 'คำสั่ง , Connection'

        Dim adapter As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "WTF") 'dataset + ชื่ออ้างอิง'
        DataGridView1.DataSource = data.Tables("WTF")

        conn.Close()
    End Sub
End Class
