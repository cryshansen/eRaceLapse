<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/eRaceMaster.Master" CodeFile="CarLookup.aspx.vb" Inherits="CarLookup" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table  cellspacing="2">
        <caption>
            Look Up Car</caption>
        <tr>
            <th align="left" style="width: 100px">
                Car ID</th>
            <th align="left" style="width: 100px">
                <asp:TextBox ID="CarID" runat="server"></asp:TextBox></th>
            <th align="left" style="width: 100px">
                <asp:Button ID="GetCar" runat="server" Text="Get Car" Width="99px" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue" /></th>
        </tr>
        <tr>
            <th align="left" style="width: 100px">
                Serial Number</th>
            <th align="left" style="width: 100px">
                <asp:TextBox ID="Serial" runat="server" ReadOnly="True"></asp:TextBox></th>
            <th align="left" style="width: 100px">
                <asp:Button ID="UpdateCar" runat="server" BackColor="Navy" BorderColor="#8080FF"
                    ForeColor="LightBlue" Text="Update Car" Width="98px" /></th>
        </tr>
        <tr>
            <th align="left" style="width: 100px">
                Ownership</th>
            <th align="left" style="width: 100px">
                <asp:TextBox ID="Ownership" runat="server" ReadOnly="True"></asp:TextBox></th>
            <th align="left" style="width: 100px">
            </th>
        </tr>
        <tr>
            <th align="left" style="width: 100px">
                Car Class ID</th>
            <th align="left" style="width: 100px">
                <asp:TextBox ID="carClassID" runat="server" ReadOnly="True"></asp:TextBox></th>
            <th align="left" style="width: 100px">
            </th>
        </tr>
        <tr>
            <th align="left" style="width: 100px">
                State</th>
            <th align="left" style="width: 100px">
                <asp:TextBox ID="State" runat="server" ReadOnly="True"></asp:TextBox></th>
            <th align="left" style="width: 100px">
            </th>
        </tr>
        <tr>
            <th align="left" style="width: 100px">
                Description</th>
            <th align="left" style="width: 100px">
                <asp:TextBox ID="Description" runat="server" ReadOnly="True"></asp:TextBox></th>
            <th align="left" style="width: 100px">
            </th>
        </tr>
        <tr>
            <th align="left" style="width: 100px">
                Member Id</th>
            <th align="left" style="width: 100px">
                <asp:TextBox ID="MemberId" runat="server" ReadOnly="True"></asp:TextBox></th>
            <th align="left" style="width: 100px">
            </th>
        </tr>
    </table>
    <br />
    <asp:Label ID="myMess" runat="server" Width="566px" ForeColor="Red"></asp:Label>
</asp:Content>
