Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pro As New Product("P-001", "Pen", 200, 12.5)
        'pro.ID = "P-001"
        'pro.Name = "Pen"
        'pro.item = 200
        'pro.Price = 12.5


        Dim message As String
        message = "รหัสสินค้า : " & pro.ID & "(" & pro.Name & ")" & vbNewLine &
                  "จำนวนชิ้น : " & pro.item & ",ราคาต่อชิ้น : " & pro.Price &
                  vbNewLine & "ราคารวมทั้งมด : " & pro.calculate() & "บาท"
        MessageBox.Show(message)
    End Sub
End Class
