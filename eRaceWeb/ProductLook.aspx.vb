
Partial Class ProductLook
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myMess.Text = ""
        If Not Page.IsPostBack Then
            Dim sysMgr As New eRaceSystem.eRace
            Dim productCat As New DataSet
            Try
                productCat = sysMgr.getProductCategories()
                If productCat.Tables(0).Rows.Count = 0 Then
                    myMess.Text = "Application error, no product categories available."
                Else
                    productCat.Tables(0).DefaultView.Sort = "Category ASC"
                    CategoryList1.DataSource = productCat.Tables(0)
                    CategoryList1.DataTextField = "Category"
                    CategoryList1.DataValueField = "Category"
                    CategoryList1.DataBind()
                    CategoryList1.Items.Insert(0, "")

                End If
            Catch ex As Exception
                myMess.Text = ex.Message
            End Try

        end if

    End Sub

    Protected Sub LookupProduct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupProduct.Click
        'this is for lookup by product Id
        Dim sysMgr As New eRaceSystem.eRace
        Dim Product As DataSet
        ProductId.Text = ProductId.Text.Trim
        UpdateButton.Enabled = False
        CategoryGrid.Enabled = False
        Label1.Text = ""
        Try
            Product = sysMgr.LookupProductbyProductID(ProductId.Text)
            If Product.Tables(0).Rows.Count = 0 Then
                myMess.Text = "No product exists for id: " & ProductId.Text
                
            Else

                With Product.Tables(0).Rows(0)
                    ProductId.Text = .Item(0)
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
                UpdateButton.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub SelectBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectBtn.Click
        'This is look up categories
        CategoryGrid.Enabled = True
        ProductId.Text = ""
        ItemName.Text = ""
        ItemPrice.Text = ""
        UnitCost.Text = ""
        UnitType.Text = ""
        UnitSize.Text = ""
        QOH.Text = ""
        ReorderLevel.Text = ""
        RestockCharge.Text = ""
        Label1.Text = "Select an item to Update"
        Dim sysMgr As New eRaceSystem.eRace
        Dim productCat As DataSet
        Try

            productCat = sysMgr.LookupProductbyCategory(CategoryList1.SelectedValue)
            If productCat.Tables(0).Rows.Count = 0 Then


                myMess.Text = "Application error, no products for this category."
                CategoryGrid.DataSource = Nothing
                CategoryGrid.DataBind()
                myMess.Text = productCat.Tables(0).Rows.Count
            Else
                myMess.Text = productCat.Tables(0).Rows.Count
                CategoryGrid.PageIndex = 0
                productCat.Tables(0).DefaultView.Sort = "ProductId ASC"
                CategoryGrid.DataSource = productCat.Tables(0)
                CategoryGrid.DataBind()

                ViewState("myProductDS") = productCat
            End If

        Catch ex As Exception
            myMess.Text = ex.Message
        End Try

    End Sub


    Protected Sub CategoryGrid_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles CategoryGrid.PageIndexChanging
        'this is paging for datagrid
        Dim pageindex As Integer = e.NewPageIndex
        CategoryGrid.PageIndex = pageindex

        Dim ProductInfo As DataSet = ViewState("myProductDS")
        CategoryGrid.DataSource = ProductInfo.Tables(0)
        CategoryGrid.DataBind()

    End Sub

    Protected Sub CategoryGrid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CategoryGrid.SelectedIndexChanged
        Dim aGridViewRow As GridViewRow = CategoryGrid.SelectedRow
        Dim pageString As String = "UpdateProduct.aspx?Product=" & aGridViewRow.Cells(1).Text
        Response.Redirect(pageString)
    End Sub

    Protected Sub UpdateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateButton.Click

        Dim pageString As String = "UpdateProduct.aspx?Product=" & ProductId.Text
        Response.Redirect(pageString)
    End Sub
End Class
