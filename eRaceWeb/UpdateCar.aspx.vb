
Partial Class UpdateCar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            
            Dim CarValue As String = Request.QueryString("CarID")
            Dim CarClassList As DataSet
            Dim StateTable As DataSet
            Dim CarInfo As DataSet
            Dim sys As New eRaceSystem.eRace

            Try
                CarClassList = sys.AllCarClassID
                StateTable = sys.AllStates

                If CarClassList.Tables(0).Rows.Count = 0 Then
                    myMess.Text = "No Car Classes Exist"
                ElseIf StateTable.Tables(0).Rows.Count = 0 Then
                    myMess.Text = "No States Exist"
                Else
                    CarClassList.Tables(0).DefaultView.Sort = "CarClassName ASC"
                    CarList1.DataSource = CarClassList.Tables(0)
                    CarList1.DataTextField = "CarClassName"
                    CarList1.DataValueField = "CarClassID"
                    CarList1.DataBind()

                    StateTable.Tables(0).DefaultView.Sort = "State Asc"
                    StateList.DataSource = StateTable.Tables(0)
                    StateList.DataTextField = "State"
                    StateList.DataValueField = "State"
                    StateList.DataBind()

                    If Not (CarValue Is Nothing) Then
                        CarID.Text = CarValue


                        Try
                            CarInfo = sys.LookupCarByCarID(CarID.Text)
                            If CarInfo.Tables(0).Rows.Count = 0 Then
                                myMess.Text = "No cars with that car id"
                            Else

                                With CarInfo.Tables(0).Rows(0)
                                    CarID.Text = .Item(0)
                                    SerialNum.Text = .Item(1)
                                    Ownership.Text = .Item(2)
                                    CarList1.SelectedValue = .Item(3)
                                    StateList.SelectedValue = .Item(4)
                                    Description.Text = .Item(5)
                                    MemberID.Text = .Item(6)
                                End With
                            End If
                        Catch ex As Exception
                            myMess.Text = ex.Message
                        End Try
                    Else

                        Dim pageString As String = "CarLookup.aspx?"
                        Response.Redirect(pageString)


                    End If
                End If
            Catch ex As Exception
                myMess.Text = ex.Message

            End Try

        End If
    End Sub
    Protected Sub Update_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Update.Click

        If ValidFields() = True Then
            Try
                Dim sys As New eRaceSystem.eRace
                sys.UpdateRaceCar(Integer.Parse(CarID.Text), SerialNum.Text, Ownership.Text, CarList1.SelectedValue, StateList.SelectedValue, Description.Text, MemberID.Text)
                myMess.Text = "Car has been updated"

            Catch ex As Exception
                myMess.Text = ex.Message

            End Try

        End If
    End Sub
    Public Function ValidFields() As Boolean
        Dim Flag As Boolean = False
        If Trim(SerialNum.Text) = "" Then
            myMess.Text = "Serial Number can not be blank"
            SerialNum.Focus()
        ElseIf Trim(Ownership.Text) = "" Then
            Ownership.Text = "Rental"
        
        ElseIf Trim(Description.Text) = "" Then
            myMess.Text = ("Description Can not be blank")
            Description.Focus()
        Else
            Flag = True
        End If

        Return Flag

    End Function

    
End Class
