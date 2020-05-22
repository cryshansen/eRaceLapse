
Partial Class AddCar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CarID.Text = ""
        If Not Page.IsPostBack Then
            Dim CarClassListTable As DataSet
            Dim StateTable As DataSet


            Try
                Dim sys As New eRaceSystem.eRace
                Dim sysMg As New eRaceSystem.eRace

                CarClassListTable = sys.AllCarClassID
                StateTable = sys.AllStates

                ' check for  table is empty
                If CarClassListTable.Tables(0).Rows.Count = 0 Then
                    MyMess.Text = "No Car Classes Exist"
                ElseIf StateTable.Tables(0).Rows.Count = 0 Then
                    MyMess.Text = "No States Exist"
                Else
                    CarClassListTable.Tables(0).DefaultView.Sort = "CarClassName Asc"
                    CarClassList.DataSource = CarClassListTable.Tables(0)
                    CarClassList.DataTextField = "CarClassName"
                    CarClassList.DataValueField = "CarClassId"
                    CarClassList.DataBind()
                    CarClassList.Items.Insert(0, "")

                End If

            Catch ex As Exception
                MyMess.Text = ex.Message

            End Try
        End If
    End Sub
    Protected Sub Save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Save.Click
        CarID.Text = ""

        'selectvalue sends string value to stored procedure
        'select index is for testing to test
        If ValidFields() = True Then
            Try
                Dim sys As New eRaceSystem.eRace
                Dim NewCarId As Integer
                NewCarId = sys.AddTrackCar(SerialNumber.Text, CarClassList.SelectedValue, State.Text, description.Text)
                CarID.Text = NewCarId
                MyMess.Text = "Car has been Saved!"

            Catch ex As Exception
                myMess.text = ex.Message

            End Try

        End If
    End Sub
    Public Function ValidFields() As Boolean
        Dim Flag As Boolean = False
        If Trim(SerialNumber.Text) = "" Then
            myMess.Text = "Serial Number can not be blank"
            SerialNumber.Focus()
        ElseIf Trim(description.Text) = "" Then
            MyMess.Text = ("Description Can not be blank")
            description.Focus()
        ElseIf CarClassList.SelectedIndex = 0 Then
            MyMess.Text = "Please select a category"
            CarClassList.Focus()
        Else
            Flag = True
        End If
        Return Flag

    End Function

End Class
