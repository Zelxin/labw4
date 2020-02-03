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

    Public ReadOnly Property SubTotal() As Decimal?
        Get
            Dim stotal As Decimal? = 0
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
        Using sw = New StreamWriter(filename)
            For Each item In Items
                sw.WriteLine(item.ToFileString())
            Next
        End Using
    End Sub

    Public Shared Function ReadShoppingListFile(filename As String) As ShoppingList
        'Import System.IO
        Dim listOfItems = New List(Of ShoppingItem)
        Dim line As String = ""

        Using sr = New StreamReader(filename)
            line = sr.ReadLine()
            While line IsNot Nothing
                Try
                    '$"{Name}|{Amount}|{Units}|{Price}"               
                    Dim data = line.Split("|"c)
                    Dim shoppingItem = New ShoppingItem()
                    shoppingItem.Name = data(0)
                    shoppingItem.Amount = Integer.Parse(data(1))
                    shoppingItem.Units = data(2)
                    shoppingItem.Price = Decimal.Parse(data(3))
                    listOfItems.Add(shoppingItem)
                Catch ioEX As IOException
                    MessageBox.Show($"{ioEX.Message}", "File Error!")
                Catch ex As Exception
                    MessageBox.Show($"{ex.Message}", "Generic Error!")
                Finally
                    line = sr.ReadLine()
                End Try
            End While
        End Using

        Return New ShoppingList(listOfItems)
    End Function

End Class
