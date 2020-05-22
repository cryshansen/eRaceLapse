
Partial Class UpdateProduct
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myMess.Text = ""
        If Not Page.IsPostBack Then
            Dim pid As String
            pid = Request.QueryString("Product")

            Dim myList As DataSet
            Dim sysMgr As New eRaceSystem.eRace
            Try
                myList = sysMgr.getProductCategories
                If myList.Tables(0).Rows.Count = 0 Then
                    myMess.Text = "There is no product by this Product Id" & ProductID.Text
                Else

                    myList.Tables(0).DefaultView.Sort = "Category ASC"
                    CategoryList1.DataSource = myList.Tables(0)
                    CategoryList1.DataTextField = "Category"
                    CategoryList1.DataValueField = "Category"
                    CategoryList1.DataBind()
                    CategoryList1.Items.Insert(0, "")

                End If
            Catch ex As Exception
                myMess.Text = ex.Message
            End Try
            If Not (pid Is Nothing) Then
                ProductID.Text = pid

                Dim sysMgr2 As New eRaceSystem.eRace
                Dim myProduct As DataSet

                Try
                    myProduct = sysMgr2.LookupProductbyProductID(ProductID.Text)
                    If myProduct.Tables(0).Rows.Count = 0 Then
                        myMess.Text = "There is no product by this Product Id" & ProductID.Text
                    Else

                        With myProduct.Tables(0).Rows(0)
                            ProductID.Text = .Item(0)

                            CategoryList1.SelectedValue = .Item(9)

                            ItemName.Text = .Item(1)
                            ItemPrice.Text = .Item(2)
                            UnitCost.Text = .Item(3)
                            UnitType.Text = .Item(4)
                            UnitSize.Text = .Item(5)
                            QOH.Text = .Item(6)
                            ReorderLevel.Text = .Item(7)
                            RestockCharge.Text = .Item(8)
                        End With
                    End If
                Catch ex As Exception
                    myMess.Text = ex.Message
                End Try
            Else

                Dim pageString As String = "ProductLook.aspx?"
                Response.Redirect(pageString)
            End If
        End If
    End Sub

    Protected Sub Update_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Update.Click
        If ValidFields() = True Then
            Dim sysMgr As New eRaceSystem.eRace

            Try
                sysMgr.UpdateProduct(ProductID.Text, ItemName.Text, ItemPrice.Text, UnitCost.Text, UnitType.Text, UnitSize.Text, QOH.Text, ReorderLevel.Text, RestockCharge.Text, CategoryList1.SelectedValue)
                myMess.Text = "Update Sucessfull"
            Catch ex As Exception
                myMess.Text = ex.Message

            End Try

        End If

    End Sub
    Public Function ValidFields() As Boolean
        Dim Flag As Boolean = False

        If CategoryList1.SelectedIndex = -1 Then
            myMess.Text = "Category must be selected"
            CategoryList1.Focus()
        ElseIf Trim(ItemName.Text) = "" Then
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
