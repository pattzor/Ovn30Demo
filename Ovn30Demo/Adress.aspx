<%@ Page MasterPageFile="~/main.Master" Language="C#" AutoEventWireup="true" CodeBehind="Adress.aspx.cs" Inherits="Ovn30Demo.Adress" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <script>alert("I AM ADRESS");</script>
</asp:Content>

<asp:Content ContentPlaceHolderID="main_content" runat="server">
    <div>
        <asp:DropDownList ID="dropDownListContacts" runat="server" Height="28px" Width="369px">
        </asp:DropDownList>
    </div>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">Type</td>
            <td class="auto-style2">
                <asp:TextBox ID="textBoxType" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Street</td>
            <td class="auto-style2">
                <asp:TextBox ID="textBoxStreet" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">City</td>
            <td class="auto-style2">
                <asp:TextBox ID="textBoxCity" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="ButtonAddAddress" runat="server" OnClick="ButtonAddAddress_Click" Text="Add Adress" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
