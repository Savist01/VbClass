Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SEID As String = txtSE.Text

        Dim constr As String ' = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"'
        constr = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=D:\Northwind.mdf;"

        Dim conn As New SqlConnection(constr)

        conn.Open()

        Dim sql As String = "select CompanyName,ContactName,Address,Country,Phone
                             from Customers
                             where CustomerID like '" & SEID.ToUpper & "%'"
        Dim cmd As New SqlCommand(sql, conn) 'คำสั่ง , Connection'

        Dim CID As String = txtSE.Text

        Dim adapter As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "WTF") 'dataset + ชื่ออ้างอิง'

        Dim Check As Boolean = True

        If SEID = "" Then
            MessageBox.Show("Fill", "")
        Else
            If data.Tables("WTF").Rows.Count <> 0 Then
                For i = 0 To data.Tables("WTF").Rows.Count - 1
                    LBR1.Text = (data.Tables("WTF").Rows(i)("CompanyName"))
                    LBR2.Text = (data.Tables("WTF").Rows(i)("ContactName"))
                    LBR3.Text = (data.Tables("WTF").Rows(i)("Address"))
                    LBR4.Text = (data.Tables("WTF").Rows(i)("Country"))
                    LBR5.Text = (data.Tables("WTF").Rows(i)("Phone"))
                    Check = False
                Next
            End If

            If Check = True Then
                MessageBox.Show(SEID.ToUpper & " not found...", "")
                txtSE.Text = ""
                LBR1.Text = "..."
                LBR2.Text = "..."
                LBR3.Text = "..."
                LBR4.Text = "..."
                LBR5.Text = "..."
            End If
        End If
        conn.Close()
    End Sub
End Class
