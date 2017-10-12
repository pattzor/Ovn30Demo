<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adress.aspx.cs" Inherits="Ovn30Demo.Adress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 166px;
        }
        .auto-style2 {
            width: 275px;
        }
    </style>
</head>
<body>
    <a href="index.aspx">index.aspx</a>
    <a href="Adress.aspx">Adress.aspx</a>

    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="dropDownListContacts" runat="server" Height="28px" Width="369px">
            </asp:DropDownList>
        </div>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">Street</td>
            <td class="auto-style2">
                <asp:TextBox ID="textBoxStreet" runat="server" Width="274px"></asp:TextBox>
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
    </form>
    </body>
</html>
