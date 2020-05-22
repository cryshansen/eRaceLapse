Imports System.Data.SqlClient


Public Class Car


    Public Shared Function LookupRaceCarbyID(ByVal carid As String) As DataSet
        Dim myConn As New SqlConnection(DBConnection)
        Dim myAdaptor As New SqlDataAdapter("exec LookupCarByCarID @carid", myConn)
        myAdaptor.SelectCommand.Parameters.Add("@carid", SqlDbType.Char).Value = carid
        Dim CarInfo As New DataSet
        myAdaptor.Fill(CarInfo, "CarInfo")
        Return CarInfo
    End Function

    Public Shared Function AddTrackCar(ByVal SerialNumber As String, ByVal CarClassID As Integer, ByVal State As String, ByVal Description As String) As Integer
        Dim myConn As New SqlConnection(DBConnection)
        Dim myComm As New SqlCommand("AddTrackCar", myConn)
        myComm.CommandType = CommandType.StoredProcedure
        myComm.Parameters.Add("@serialnumber", SqlDbType.VarChar).Value = SerialNumber
        myComm.Parameters.Add("@carclassid", SqlDbType.Int).Value = CarClassID
        myComm.Parameters.Add("@state", SqlDbType.VarChar).Value = State
        myComm.Parameters.Add("@description", SqlDbType.VarChar).Value = Description

        Dim CarID As Integer
        Try
            myConn.Open()
            CarID = myComm.ExecuteScalar()
        Finally
            myConn.Close()
        End Try
        Return CarID
    End Function

    Public Shared Sub UpdateRaceCar(ByVal carid As Integer, ByVal SerialNumber As String, ByVal Ownership As String, ByVal CarClassID As Integer, ByVal State As String, ByVal description As String, ByVal MemberId As String)
        Dim myConn As New SqlConnection(DBConnection)
        Dim myComm As New SqlCommand("UpdateRaceCar", myConn)
        myComm.CommandType = CommandType.StoredProcedure
        myComm.Parameters.Add("@carid", SqlDbType.Int).Value = carid
        myComm.Parameters.Add("@serialnumber", SqlDbType.VarChar).Value = SerialNumber
        myComm.Parameters.Add("@ownership", SqlDbType.VarChar).Value = Ownership
        myComm.Parameters.Add("@carclassid", SqlDbType.Int).Value = CarClassID
        myComm.Parameters.Add("@state", SqlDbType.VarChar).Value = State
        myComm.Parameters.Add("@description", SqlDbType.VarChar).Value = description
        myComm.Parameters.Add("@memberid", SqlDbType.VarChar).Value = MemberId

        Try
            myConn.Open()
            myComm.ExecuteNonQuery()
        Finally
            myConn.Close()
        End Try

    End Sub

    Public Shared Function AllCarClassID() As DataSet
        Dim myConn As New SqlConnection(DBConnection)
        Dim myAdaptor As New SqlDataAdapter("exec getAllCarClassID", myConn)
        Dim ProductCategoryInfo As New DataSet
        Dim CarClassInfo As New DataSet
        myAdaptor.Fill(CarClassInfo, "CarClassInfo")
        Return CarClassInfo
    End Function

    Public Shared Function AllStates() As DataSet
        Dim myConn As New SqlConnection(DBConnection)
        Dim myAdaptor As New SqlDataAdapter("exec getAllStates", myConn)
        Dim StateInfo As New DataSet
        Dim ProductCategoryInfo As New DataSet
        myAdaptor.Fill(StateInfo, "StateInfo")
        Return StateInfo
    End Function
End Class
