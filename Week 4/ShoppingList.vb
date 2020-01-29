Public Class ShoppingList

    Private _items As List(Of ShoppingItem)
    Public Property Items() As List(Of ShoppingItem)
        Get
            Return _items
        End Get
        Set(ByVal value As List(Of ShoppingItem))
            _items = value
        End Set
    End Property

    Public ReadOnly Property SubTotal() As Decimal
        Get
            Dim stotal As Decimal = 0
            For Each i In Items
                stotal += i.Price * i.Amount
            Next
            Return stotal
        End Get
    End Property

    Public Sub New()
        Me.Items = New List(Of ShoppingItem)
    End Sub
    Public Sub New(items As List(Of ShoppingItem))
        Me.Items = items
    End Sub

    Public Function MostExpensiveItem() As ShoppingItem
        Dim highestPricedItem As ShoppingItem = Nothing
        For Each i In Items
            If highestPricedItem Is Nothing Then
                highestPricedItem = i
            End If
            If i.Price > highestPricedItem.Price Then
                highestPricedItem = i
            End If
        Next
        Return highestPricedItem
    End Function



End Class
