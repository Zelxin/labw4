Imports System.IO
''' <summary>
''' Vincent Vassallo
''' ShoppingList.vb
''' Contains a list of shopping items to be purchased, has some useful functionality like totals and finding the most/least expensive item.
''' Also can write the list to a file and import from a file.
''' </summary>
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

    Public Function LeastExpensiveItem() As ShoppingItem
        Dim lowestPricedItem As ShoppingItem = Nothing
        For Each i In Items
            If lowestPricedItem Is Nothing Then
                lowestPricedItem = i
            End If
            If i.Price < lowestPricedItem.Price Then
                lowestPricedItem = i
            End If
        Next
        Return lowestPricedItem
    End Function

    Public Sub WriteListToFile(filename As String)

    End Sub

    Public Shared Function ReadShoppingListFile(filename As String) As ShoppingList
        'Import System.IO

    End Function

End Class
