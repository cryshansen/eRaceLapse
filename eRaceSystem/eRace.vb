

Public Class eRace


    Public Function LookupProductbyProductID(ByVal productid As String) As DataSet
        Return Product.LookupProductbyProductID(productid)
    End Function

    Public Function getProductCategories() As DataSet
        Return Product.getProductCategories()
    End Function

    Public Function LookupProductbyCategory(ByVal category As String) As DataSet
        Return Product.LookupProductbyCategory(category)
    End Function

    Public Function getAllUnitTypes() As DataSet
        Return Product.getAllUnitTypes()
    End Function


    Public Function AddProduct(ByVal ItemName As String, ByVal ItemPrice As Decimal, ByVal OrderUnitCost As Decimal, ByVal OrderUnitType As String, ByVal OrderUnitSize As Integer, ByVal QOH As Integer, ByVal ReorderLevel As Integer, ByVal ReStockCharge As Decimal, ByVal Category As String) As Integer

        Return Product.AddProduct(ItemName, ItemPrice, OrderUnitCost, OrderUnitType, OrderUnitSize, QOH, ReorderLevel, ReStockCharge, Category)

    End Function


    Public Sub UpdateProduct(ByVal productid As Integer, ByVal ItemName As String, ByVal ItemPrice As Decimal, ByVal OrderUnitCost As Decimal, ByVal OrderUnitType As String, ByVal OrderUnitSize As Integer, ByVal QOH As Integer, ByVal ReorderLevel As Integer, ByVal ReStockCharge As Decimal, ByVal Category As String)

        Product.UpdateProduct(productid, ItemName, ItemPrice, OrderUnitCost, OrderUnitType, OrderUnitSize, QOH, ReorderLevel, ReStockCharge, Category)

    End Sub


    Public Function LookupCarByCarID(ByVal carid As String) As DataSet

        Return Car.LookupRaceCarbyID(carid)

    End Function

    Public Function AddTrackCar(ByVal SerialNumber As String, ByVal CarClassID As Integer, ByVal State As String, ByVal Description As String) As Integer

        Return Car.AddTrackCar(SerialNumber, CarClassID, State, Description)
    End Function

    Public Sub UpdateRaceCar(ByVal carid As Integer, ByVal SerialNumber As String, ByVal Ownership As String, ByVal CarClassID As Integer, ByVal State As String, ByVal description As String, ByVal MemberId As String)

        Car.UpdateRaceCar(carid, SerialNumber, Ownership, CarClassID, State, description, MemberId)
    End Sub
    Public Function AllCarClassID() As DataSet
        Return Car.AllCarClassID

    End Function

    Public Function AllStates() As DataSet
        Return Car.AllStates

    End Function



End Class
