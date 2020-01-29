Public Class ShoppingItem
    Private _name As String
    ''' <summary>
    ''' This is the name of the item
    ''' </summary>
    ''' <returns>The name of the shopping item</returns>
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _units As String
    ''' <summary>
    ''' format the item comes in
    ''' </summary>
    ''' <returns></returns>
    Public Property Units() As String
        Get
            Return _units
        End Get
        Set(ByVal value As String)
            _units = value
        End Set
    End Property

    Private _amount As Integer
    ''' <summary>
    ''' Number of items
    ''' </summary>
    ''' <returns></returns>
    Public Property Amount() As Integer
        Get
            Return _amount
        End Get
        Set(ByVal value As Integer)
            _amount = value
        End Set
    End Property

    Private _price As Decimal
    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            _price = value
        End Set
    End Property

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()

    End Sub

    Public Sub New(name As String, units As String, amount As Integer)
        Me.Name = name
        Me.Amount = amount
        Me.Units = units
    End Sub

    ''' <summary>
    ''' Adds item to the text box given
    ''' </summary>
    ''' <param name="txtBox">Textbox for the item text to be added to.</param>
    Public Sub AddItem(txtBox As TextBox)
        'txtBox.AppendText($"{Me.ToString()}{Environment.NewLine}")
        txtBox.AppendText(Me.ToString() & Environment.NewLine)
    End Sub

    ''' <summary>
    ''' Summary of shopping item
    ''' </summary>
    ''' <returns>Nicely formated description</returns>
    Public Overrides Function ToString() As String
        Return $"{Amount} x {Units} of {Name}"
    End Function

End Class
