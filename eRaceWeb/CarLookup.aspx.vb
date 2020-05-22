Partial Public Class CarLookup
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myMess.Text = ""
        If Not IsPostBack Then



        End If
    End Sub

    Protected Sub GetCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetCar.Click
        'this is my car lookup 
        'UpdateCar.Enabled = False
        Dim sys As New eRaceSystem.eRace
        Dim CarInfo As DataSet
        Try
            CarInfo = sys.LookupCarByCarID(CarID.Text)
            If CarInfo.Tables(0).Rows.Count = 0 Then
                myMess.Text = "No cars with that car id"
            Else

                With CarInfo.Tables(0).Rows(0)
                    CarID.Text = .Item(0)
                    Serial.Text = .Item(1)
                    Ownership.Text = .Item(2)
                    carClassID.Text = .Item(3)
                    State.Text = .Item(4)
                    Description.Text = .Item(5)
                    MemberId.Text = .Item(6)
                End With
                UpdateCar.Enabled = True
            End If
        Catch ex As Exception
            myMess.Text = ex.Message
        End Try

        myMess.Text = "Please look up a CarId before editing"



    End Sub


    Protected Sub UpdateCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCar.Click
        Dim pageString As String = "UpdateCar.aspx?CarId=" & CarID.Text
        Response.Redirect(pageString)
    End Sub
End Class
