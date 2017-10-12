<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Ovn30Demo.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 170px;
        }
    </style>
</head>
<body style="height: 17px">
    <a href="index.aspx">index.aspx</a>
    <a href="Adress.aspx">Adress.aspx</a>

    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="listBoxContacts" runat="server" AutoPostBack="True" Height="511px" Width="352px"></asp:ListBox>
        </div>
        <table style="width:60%;">
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
    </form>
</body>
</html>
