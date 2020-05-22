<%@ Page Language="VB" MasterPageFile="~/eRaceMaster.master" AutoEventWireup="false" CodeFile="AddProduct.aspx.vb" Inherits="AddProduct" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td style="width: 100px">
                Product Id</td>
            <td style="width: 105px">
                <asp:TextBox ID="ProductId" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Button ID="Save" runat="server" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue"
                    Text="Save" Width="90px" /></td>
        </tr>
        <tr>
            <td style="width: 100px">
                </td>
            <td style="width: 105px">
                </td>
            <td style="width: 100px">
                </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Item Name</td>
            <td style="width: 105px">
                <asp:TextBox ID="ItemName" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Item Price</td>
            <td style="width: 105px">
                <asp:TextBox ID="ItemPrice" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Cost</td>
            <td style="width: 105px">
                <asp:TextBox ID="UnitCost" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Type</td>
            <td style="width: 105px">
                <asp:DropDownList ID="UnitList" runat="server" Width="153px">
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Size</td>
            <td style="width: 105px">
                <asp:TextBox ID="UnitSize" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                QOH</td>
            <td style="width: 105px">
                <asp:TextBox ID="QOH" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Reorder Level</td>
            <td style="width: 105px">
                <asp:TextBox ID="ReorderLevel" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Restock Charge</td>
            <td style="width: 105px">
                <asp:TextBox ID="RestockCharge" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Category</td>
            <td style="width: 105px">
                <asp:DropDownList ID="CategoryList1" runat="server" Width="155px">
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    <asp:Label ID="myMess" runat="server" Width="615px" ForeColor="Red"></asp:Label>
</asp:Content>

