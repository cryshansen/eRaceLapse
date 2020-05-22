
Partial Class AddProduct
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myMess.Text = ""
        If Not Page.IsPostBack Then
            Dim sysMgr As New eRaceSystem.eRace
            Dim productCat As DataSet
            Dim UnitTypes As DataSet
            Try
                productCat = sysMgr.getProductCategories()
                UnitTypes = sysMgr.getAllUnitTypes()
                If productCat.Tables(0).Rows.Count = 0 Then
                    myMess.Text = "Application error, no product categories available."
                ElseIf UnitTypes.Tables(0).Rows.Count = 0 Then
                    myMess.Text = "Application error, no UnitTypes available."
                Else

                    productCat.Tables(0).DefaultView.Sort = "Category ASC"
                    CategoryList1.DataSource = productCat.Tables(0)
                    CategoryList1.DataTextField = "Category"
                    CategoryList1.DataValueField = "Category"
                    CategoryList1.DataBind()
                    CategoryList1.Items.Insert(0, "")

                    UnitTypes.Tables(0).DefaultView.Sort = "UnitType Asc"
                    UnitList.DataSource = UnitTypes.Tables(0)
                    UnitList.DataTextField = "UnitType"
                    UnitList.DataValueField = "UnitType"
                    UnitList.DataBind()
                    UnitList.Items.Insert(0, "")

                End If
            Catch ex As Exception
                myMess.Text = ex.Message
            End Try

        End If
    End Sub

    Protected Sub Save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Save.Click
        If ValidFields() = True Then
            Dim sysMgr As New eRaceSystem.eRace
            Dim ProdID As Integer


            Try
                ProdID = sysMgr.AddProduct(ItemName.Text, ItemPrice.Text, UnitCost.Text, UnitList.SelectedValue, UnitSize.Text, QOH.Text, ReorderLevel.Text, RestockCharge.Text, CategoryList1.DataValueField)
                myMess.Text = "Add Sucessful"
                ProductId.Text = ProdID
            Catch ex As Exception
                myMess.Text = ex.Message
            End Try

        End If
    End Sub

    Public Function ValidFields() As Boolean
        Dim Flag As Boolean = False

        
        If Trim(ItemName.Text) = "" Then
            myMess.Text = "Item Name can not be blank"
            ItemName.Focus()

        ElseIf Trim(ItemPrice.Text) = "" Then
            myMess.Text = "Item Price can not be blank"
        ElseIf Not IsNumeric(ItemPrice.Text) Then
            myMess.Text = "Item Price must be numeric"

        ElseIf Trim(UnitCost.Text) = "" Then
            myMess.Text = "Unit Cost can not be blank"
        ElseIf Not IsNumeric(UnitCost.Text) Then
            myMess.Text = "Unit Cost must be numeric"

        ElseIf UnitList.SelectedIndex = 0 Then
            myMess.Text = "Please select a unit type"
            UnitList.Focus()

        ElseIf Trim(UnitSize.Text) = "" Then
            myMess.Text = "Unit Size can not be blank"
            UnitSize.Focus()
        ElseIf Not IsNumeric(UnitSize.Text) Then
            myMess.Text = "Unit Size must be numeric"
            UnitSize.Focus()

        ElseIf Trim(QOH.Text) = "" Then
            myMess.Text = "QOH can not be blank"
            QOH.Focus()
        ElseIf Not IsNumeric(QOH.Text) Then
            myMess.Text = "QOH must be numeric"
            QOH.Focus()
        ElseIf Trim(ReorderLevel.Text) = "" Then
            myMess.Text = "Reorder Level can not be blank"
            QOH.Focus()
        ElseIf Not IsNumeric(ReorderLevel.Text) Then
            myMess.Text = "Reorder Level must be numeric"
            QOH.Focus()

        ElseIf Trim(RestockCharge.Text) = "" Then
            myMess.Text = "Restock Charge can not be blank"
            RestockCharge.Focus()
        ElseIf Not IsNumeric(RestockCharge.Text) Then
            myMess.Text = "Restock Charge must be numeric"
            RestockCharge.Focus()
        ElseIf CategoryList1.SelectedIndex = 0 Then
            myMess.Text = "Please select a category"
            CategoryList1.Focus()
        Else
            Flag = True
        End If

        Return Flag

    End Function
End Class
