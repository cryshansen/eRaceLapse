Imports System.Data.SqlClient


Public Class Product

    Public Shared Function LookupProductbyProductID(ByVal productid As String) As DataSet
        Dim myConn As New SqlConnection(DBConnection)
        Dim myAdaptor As New SqlDataAdapter("exec LookupProductbyProductID @productid", myConn)
        myAdaptor.SelectCommand.Parameters.Add("@productid", SqlDbType.Char).Value = productid
        Dim ProductInfo As New DataSet
        myAdaptor.Fill(ProductInfo, "ProductInfo")
        Return ProductInfo
    End Function

    Public Shared Function getProductCategories() As DataSet
        Dim myConn As New SqlConnection(DBConnection)
        Dim myAdaptor As New SqlDataAdapter("exec getProductCategories", myConn)
        Dim ProductCategoryInfo As New DataSet
        myAdaptor.Fill(ProductCategoryInfo, "ProductCategoryInfo")
        Return ProductCategoryInfo
    End Function
    Public Shared Function LookupProductbyCategory(ByVal category As String) As DataSet
        Dim myConn As New SqlConnection(DBConnection)
        Dim myAdaptor As New SqlDataAdapter("exec LookupProductbyCategory @category", myConn)
        myAdaptor.SelectCommand.Parameters.Add("@category", SqlDbType.VarChar).Value = category
        Dim ProductInfo As New DataSet
        myAdaptor.Fill(ProductInfo, "ProductInfo")
        Return ProductInfo
    End Function

    Public Shared Function AddProduct(ByVal ItemName As String, ByVal ItemPrice As Decimal, ByVal OrderUnitCost As Decimal, ByVal OrderUnitType As String, ByVal OrderUnitSize As Integer, ByVal QOH As Integer, ByVal ReorderLevel As Integer, ByVal ReStockCharge As Decimal, ByVal Category As String) As Integer
        Dim myConn As New SqlConnection(DBConnection)
        Dim myComm As New SqlCommand("AddProduct", myConn)
        myComm.CommandType = CommandType.StoredProcedure
        myComm.Parameters.Add("@itemname", SqlDbType.VarChar).Value = ItemName
        myComm.Parameters.Add("@ItemPrice", SqlDbType.Money).Value = ItemPrice
        myComm.Parameters.Add("@unitcost", SqlDbType.Money).Value = OrderUnitCost
        myComm.Parameters.Add("@unittype", SqlDbType.VarChar).Value = OrderUnitType
        myComm.Parameters.Add("@unitsize", SqlDbType.Int).Value = OrderUnitSize
        myComm.Parameters.Add("@qoh", SqlDbType.Int).Value = QOH
        myComm.Parameters.Add("@reOrder", SqlDbType.Int).Value = ReorderLevel
        myComm.Parameters.Add("@restock", SqlDbType.Money).Value = ReStockCharge
        myComm.Parameters.Add("@category", SqlDbType.VarChar).Value = Category
        Dim ProductID As Integer
        Try
            myConn.Open()
            ProductID = myComm.ExecuteScalar()
        Finally
            myConn.Close()
        End Try
        Return ProductID

    End Function

    Public Shared Sub UpdateProduct(ByVal productid As Integer, ByVal ItemName As String, ByVal ItemPrice As Decimal, ByVal OrderUnitCost As Decimal, ByVal OrderUnitType As String, ByVal OrderUnitSize As Integer, ByVal QOH As Integer, ByVal ReorderLevel As Integer, ByVal ReStockCharge As Decimal, ByVal Category As String)
        Dim myConn As New SqlConnection(DBConnection)
        Dim myComm As New SqlCommand("UpdateProduct", myConn)
        myComm.CommandType = CommandType.StoredProcedure
        myComm.Parameters.Add("@productid", SqlDbType.Int).Value = productid
        myComm.Parameters.Add("@itemname", SqlDbType.VarChar).Value = ItemName
        myComm.Parameters.Add("@ItemPrice", SqlDbType.Money).Value = ItemPrice
        myComm.Parameters.Add("@unitcost", SqlDbType.Money).Value = OrderUnitCost
        myComm.Parameters.Add("@unittype", SqlDbType.VarChar).Value = OrderUnitType
        myComm.Parameters.Add("@unitsize", SqlDbType.Int).Value = OrderUnitSize
        myComm.Parameters.Add("@qoh", SqlDbType.Int).Value = QOH
        myComm.Parameters.Add("@reOrder", SqlDbType.Int).Value = ReorderLevel
        myComm.Parameters.Add("@restock", SqlDbType.Money).Value = ReStockCharge
        myComm.Parameters.Add("@category", SqlDbType.VarChar).Value = Category
        Try
            myConn.Open()
            myComm.ExecuteNonQuery()
        Finally
            myConn.Close()
        End Try

    End Sub


    Public Shared Function getAllUnitTypes() As DataSet
        Dim myConn As New SqlConnection(DBConnection)
        Dim myAdaptor As New SqlDataAdapter("exec getAllUnitTypes", myConn)
        Dim UnitInfo As New DataSet
        myAdaptor.Fill(UnitInfo, "UnitInfo")
        Return UnitInfo
    End Function

End Class


