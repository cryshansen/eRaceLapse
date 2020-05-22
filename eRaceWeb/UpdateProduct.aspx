<%@ Page Language="VB" MasterPageFile="~/eRaceMaster.master" AutoEventWireup="false" CodeFile="UpdateProduct.aspx.vb" Inherits="UpdateProduct" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellspacing="2">
        <tr>
            <td style="width: 100px; height: 22px">
                Product ID</td>
            <td style="width: 100px; height: 22px">
                <asp:TextBox ID="ProductID" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 22px">
                <asp:Button ID="Update" runat="server" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue"
                    Text="Update Product" Width="96px" /></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 26px;">
                Item Name</td>
            <td style="width: 100px; height: 26px;">
                <asp:TextBox ID="ItemName" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 26px;">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Item Price</td>
            <td style="width: 100px">
                <asp:TextBox ID="ItemPrice" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Cost</td>
            <td style="width: 100px">
                <asp:TextBox ID="UnitCost" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Type</td>
            <td style="width: 100px">
                <asp:TextBox ID="UnitType" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Size</td>
            <td style="width: 100px">
                <asp:TextBox ID="UnitSize" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                QOH</td>
            <td style="width: 100px">
                <asp:TextBox ID="QOH" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                ReorderLevel</td>
            <td style="width: 100px">
                <asp:TextBox ID="ReorderLevel" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Restock Charge</td>
            <td style="width: 100px">
                <asp:TextBox ID="RestockCharge" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Category</td>
            <td style="width: 100px">
                <asp:DropDownList ID="CategoryList1" runat="server" Width="153px">
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    <asp:Label ID="myMess" runat="server" Width="574px" ForeColor="Red"></asp:Label>
</asp:Content>

