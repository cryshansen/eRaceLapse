<%@ Page Language="VB" MasterPageFile="~/eRaceMaster.master" AutoEventWireup="false" CodeFile="ProductLook.aspx.vb" Inherits="ProductLook" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table  cellspacing="2">
        <tr>
            <td align="center" colspan="3">
                Lookup a Product<br />
                Select either Product Id or Category to retrieve a record</td>
        </tr>
        <tr>
            <td style="width: 100px">
                Product Id</td>
            <td style="width: 100px">
                <asp:TextBox ID="ProductId" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Button ID="LookupProduct" runat="server" BackColor="Navy" BorderColor="#8080FF"
                    ForeColor="LightBlue" Text="Search" Width="90px" /></td>
        </tr>
        <tr>
            <td style="width: 100px">
                </td>
            <td style="width: 100px">
                </td>
            <td style="width: 100px">
                <asp:Button ID="UpdateButton" runat="server" BackColor="Navy" BorderColor="#8080FF"
                    ForeColor="LightBlue" Text="Update ID" Width="91px" /></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Item Name</td>
            <td style="width: 100px">
                <asp:TextBox ID="ItemName" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px">
                </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Item Price</td>
            <td style="width: 100px">
                <asp:TextBox ID="ItemPrice" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Cost</td>
            <td style="width: 100px">
                <asp:TextBox ID="UnitCost" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px">
                </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Type</td>
            <td style="width: 100px">
                <asp:TextBox ID="UnitType" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Unit Size</td>
            <td style="width: 100px">
                <asp:TextBox ID="UnitSize" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 26px;">
                QOH</td>
            <td style="width: 100px; height: 26px;">
                <asp:TextBox ID="QOH" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px; height: 26px;">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Reorder Level</td>
            <td style="width: 100px">
                <asp:TextBox ID="ReorderLevel" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Restock Charge</td>
            <td style="width: 100px">
                <asp:TextBox ID="RestockCharge" runat="server" Width="178px"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Category</td>
            <td style="width: 100px">
                <asp:DropDownList ID="CategoryList1" runat="server" Width="188px">
                </asp:DropDownList></td>
            <td style="width: 100px">
                <asp:Button ID="SelectBtn" runat="server" BackColor="Navy" BorderColor="#8080FF"
                    ForeColor="LightBlue" Text="Select" Width="90px" /></td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Label ID="myMess" runat="server" Width="647px" ForeColor="Red"></asp:Label><br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" ForeColor="Navy"
        Width="167px"></asp:Label><br />
    <asp:GridView ID="CategoryGrid" runat="server" AutoGenerateColumns="False" Height="70px"
        PageSize="3" Width="545px" AllowPaging="True">
        <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:BoundField HeaderText="Productid" DataField="Productid" />
            <asp:BoundField HeaderText="ItemName" DataField="itemname" />
            <asp:BoundField HeaderText="QOH" DataField="quantityonhand" />
        </Columns>
        <AlternatingRowStyle BackColor="#8080FF" />
        <PagerSettings Position="Top" />
    </asp:GridView>
    &nbsp;&nbsp;<br />
    <br />
    <br />
    <br />
    &nbsp; &nbsp;
</asp:Content>

