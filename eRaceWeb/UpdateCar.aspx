<%@ Page Language="VB" MasterPageFile="~/eRaceMaster.master" AutoEventWireup="false" CodeFile="UpdateCar.aspx.vb" Inherits="UpdateCar" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: left">
        <table  cellspacing="2">
            <tr>
                <td align="center" colspan="3">
                    Update Car<br />
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Car ID</td>
                <td style="width: 100px">
                    <asp:TextBox ID="CarID" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:Button ID="Update" runat="server" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue"
                        Text="Update Car" Width="87px" /></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Serial Number</td>
                <td style="width: 100px">
                    <asp:TextBox ID="SerialNum" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Ownership</td>
                <td style="width: 100px">
                    <asp:TextBox ID="Ownership" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    CarClassID</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="CarList1" runat="server" Width="155px">
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    State</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="StateList" runat="server" Width="155px">
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Description</td>
                <td style="width: 100px">
                    <asp:TextBox ID="Description" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    MemberId</td>
                <td style="width: 100px">
                    <asp:TextBox ID="MemberID" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                    </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
    </div>
    <asp:Label ID="myMess" runat="server" ForeColor="Red" Width="640px"></asp:Label>
</asp:Content>

