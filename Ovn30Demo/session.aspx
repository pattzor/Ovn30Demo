<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="session.aspx.cs" Inherits="Ovn30Demo.session" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <asp:Label ID="Label1Info" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
    <table style="width: 40%;">
        <tr>
            <td>Username</td>
            <td>
                <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Logga in" OnClick="Button1_Click" />&nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Logga ut" OnClick="Button2_Click" />&nbsp;</td>
        </tr>
    </table>
</asp:Content>
