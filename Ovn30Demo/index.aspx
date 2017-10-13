
<%@ Page MasterPageFile="~/main.Master" Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Ovn30Demo.index" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <script>alert("I AM INDEX");</script>
</asp:Content>

<asp:Content ContentPlaceHolderID="main_content" runat="server">
    <div>
        <asp:ListBox ID="listBoxContacts" runat="server" AutoPostBack="True" Height="511px" Width="352px"></asp:ListBox>
    </div>
    <table style="width: 60%;">
        <tr>
            <td class="auto-style1">Firstname</td>
            <td>
                <asp:TextBox ID="textBoxFirstname" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Lastname</td>
            <td>
                <asp:TextBox ID="textBoxLastname" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">SSN</td>
            <td>
                <asp:TextBox ID="textBoxSSN" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="ButtonAddContact" runat="server" OnClick="ButtonAddContact_Click" Text="Add Contact" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
