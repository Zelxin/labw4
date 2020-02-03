Public Class Form1
    Private _shoppingList As New ShoppingList
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

        Dim price As Decimal
        Dim bEnteredPrice = Decimal.TryParse(txt_price.Text, price)

        If bEnteredPrice AndAlso price >= 0 Then
            item.Price = price
        Else
            MessageBox.Show("Please enter a valid Price.")
        End If

        _shoppingList.Items.Add(item)

        lb_Items.Items.Add(item)
        lbl_subTotal.Text = $"Sub Total: {_shoppingList.SubTotal:C}"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _shoppingList = New ShoppingList()
    End Sub

    Private Sub btn_writeList_Click(sender As Object, e As EventArgs) Handles btn_writeList.Click

    End Sub
End Class
