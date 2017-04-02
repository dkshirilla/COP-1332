'CLASS FORM 
'Programmer: Douglas Shirilla
'Date:05/04/2016


Public Class piecepay
    Private QuantityInteger As Integer
    Private PiecePriceDecimal As Decimal
    Private TotalPriceDecimal As Decimal
    Private TotalPayDecimal As Decimal
    Private Shared PriceTotalDecimal As Decimal
    Private Shared PieceCountInteger As Integer

    Sub New(ByVal QuantityIn As Integer, ByVal PriceIn As Decimal)
        Quantity = QuantityIn
        PiecePrice = PriceIn
        CalculatePrice()
        AddToTotals()
    End Sub


    Property Quantity() As Integer
        Get
            Return QuantityInteger
        End Get
        Set(ByVal value As Integer)
            If value >= 0 Then
                QuantityInteger = value
            End If
        End Set
    End Property

    Property PiecePrice() As Decimal
        Get
            Return PiecePriceDecimal
        End Get
        Set(ByVal value As Decimal)
            If value >= 0 Then
                PiecePriceDecimal = value
            End If
        End Set
    End Property

    Property TotalPrice() As Decimal
        Get
            Return TotalPriceDecimal
        End Get
        Set(ByVal Value As Decimal)
            If Value >= 0 Then
                TotalPriceDecimal = Value
            End If
        End Set
    End Property

    Property TotalPay() As Decimal
        Get
            Return TotalPayDecimal
        End Get
        Set(ByVal Value As Decimal)
            If Value >= 0 Then
                TotalPayDecimal = Value
            End If
        End Set
    End Property


    Shared ReadOnly Property PriceTotal() As Decimal
        Get
            Return PriceTotalDecimal
        End Get
    End Property

    Shared ReadOnly Property PieceCount() As Integer
        Get
            Return PieceCountInteger
        End Get
    End Property


    Protected Sub CalculatePrice()
        TotalPriceDecimal = QuantityInteger * PiecePriceDecimal
    End Sub

    Protected Sub AddToTotals()
        PriceTotalDecimal += TotalPriceDecimal
        PieceCountInteger += QuantityInteger
    End Sub
End Class
