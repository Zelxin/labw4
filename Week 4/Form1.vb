Public Class Form1

    Private Sub btn_addItem_Click(sender As Object, e As EventArgs) Handles btn_addItem.Click
        Dim item As New ShoppingItem()
        item.Name = txt_name.Text
        item.Units = txt_units.Text
        Dim amt As Integer
        Dim bEnteredAmt = Integer.TryParse(txt_amount.Text, amt)

        If bEnteredAmt Then
            item.Amount = amt
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If

        item.AddItem(txt_items)
    End Sub
End Class
