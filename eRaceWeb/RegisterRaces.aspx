<%@ Page Language="VB" MasterPageFile="~/eRaceMaster.master" AutoEventWireup="false" CodeFile="RegisterRaces.aspx.vb" Inherits="RegisterRaces" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="Label1" runat="server" Text="Race Date:"></asp:Label><asp:TextBox ID="RDate" runat="server" Width="79px"></asp:TextBox><asp:Button ID="fetchPostBTN" runat="server" Text="fetch posts" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue" Width="86px" /><asp:Label ID="Label2" runat="server" Text="Post Time:"></asp:Label>
   
    <asp:DropDownList
        ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <asp:Button ID="fetchRaceBTN" runat="server" Text="fetch race" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue" />
    <asp:Label ID="Label8" runat="server" Text="RaceId:" Width="24px"></asp:Label>
    <asp:Label ID="Label9" runat="server"></asp:Label>
    <asp:Label ID="Label12" runat="server" Text="Entry Count:"></asp:Label>
    &nbsp;<asp:Label ID="Label13" runat="server"></asp:Label>
    &nbsp;<asp:Label ID="Label14" runat="server" Text="Run"></asp:Label>
    <asp:CheckBox ID="ChB1" runat="server" Width="81px" />
    
    <table style="width: 869px; height: 110px">
        <tr>
            <td style="height: 21px;" colspan="3">
            </td>
        </tr>
        <tr>
            <td colspan="2">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="512px">
        <Columns>
            <asp:TemplateField HeaderText="Car ID">
                <ItemTemplate>
                       <%#Eval("CarID")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="MemberID" DataField="memberid" />
            <asp:BoundField HeaderText="Name" DataField="name" />
            <asp:BoundField HeaderText="Cert." DataField="certificate" />
            <asp:TemplateField HeaderText="Finish">
                <ItemTemplate>
                       <%#Eval("finish")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="RunTime">
                <ItemTemplate>
                       <%#Eval("runtime")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Penalty">
                <ItemTemplate>
                    <asp:DropDownList ID="PenaltyList" runat="server" BackColor="White"
                    
                    >
                    </asp:DropDownList><%#Eval("penalty")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Comment">
                <ItemTemplate>
                       <%#Eval("comment")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Button" ShowEditButton="True" >
                <ControlStyle BackColor="Navy" BorderColor="Blue" ForeColor="LightBlue" />
            </asp:CommandField>
        </Columns>
    </asp:GridView>
            </td>
            <td style="width: 139px">
                &nbsp;<asp:Label ID="Label10" runat="server" Text="Car ID"></asp:Label>&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                &nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" Text="MemberID"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="RegisterID" runat="server" BackColor="Navy" BorderColor="Blue" ForeColor="LightBlue"
                    Text="Register" />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 21px">
    <asp:Label ID="Label16" runat="server" Text="Comments"></asp:Label>
                &nbsp;
                <asp:Label ID="Label15" runat="server" Text="Employee ID:"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" Width="104px"></asp:TextBox>
    <asp:Button ID="CarStatus" runat="server" Text="Car Status" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue" />
    <asp:Button ID="RecordResults" runat="server" Text="Record Results" BackColor="Navy" BorderColor="#8080FF" ForeColor="LightBlue" /><br />
                &nbsp;<br />
    <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Width="389px"></asp:TextBox>
                &nbsp;<br />
                &nbsp;</td>
        </tr>
    </table>
    
</asp:Content>

