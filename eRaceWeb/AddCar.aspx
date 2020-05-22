<%@ Page Language="VB" MasterPageFile="~/eRaceMaster.master" AutoEventWireup="false" CodeFile="AddCar.aspx.vb" Inherits="AddCar" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: left">
        <table cellspacing="2">
            <tr>
                <td align="center" colspan="3">
                    Add New Car</td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Car Id</td>
                <td style="width: 100px">
                    <asp:TextBox ID="CarID" runat="server" ReadOnly="True"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:Button ID="Save" runat="server" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue"
                        Text="Save Car" Width="92px" /></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Serial Number</td>
                <td style="width: 100px">
                    <asp:TextBox ID="SerialNumber" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Car Class ID</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="CarClassList" runat="server" Width="157px">
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    State</td>
                <td style="width: 100px">
                    <asp:TextBox ID="State" runat="server" ReadOnly="True">Unknown</asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Description</td>
                <td style="width: 100px">
                    <asp:TextBox ID="description" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
        &nbsp;&nbsp;
        <asp:Label ID="MyMess" runat="server" Width="556px" ForeColor="Red"></asp:Label>
        &nbsp; &nbsp; &nbsp;
    </div>
</asp:Content>

