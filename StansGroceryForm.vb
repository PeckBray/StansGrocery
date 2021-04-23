Public Class StansGroceryForm
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Program()
        Dim n As Integer
        Static food$(n, 3)
        'n,0 is the item name
        'n,1 is the item isle
        'n,2 is the item category
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub
End Class
