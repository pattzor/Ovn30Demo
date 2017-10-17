<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Ovn30Demo.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        table {
            margin-left: auto;
            margin-right: auto;
            margin-top: 50px;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="page-header" style="text-align: center; align-content: center;">
            <h1>The Contactlist</h1>
        </div>
    </div>
    <form id="form1" runat="server">
        <div style="text-align: center; align-content: center; display: block;">
            <div style="text-align: center; align-content: center;">
                <table class="table table-condensed table-bordered" style="width: 300px;">
                    <tr>
                        <td>Username</td>
                        <td>
                            <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Password</td>
                        <td>
                            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="text-align: right;">
                            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" /></td>
                    </tr>
                </table>
                <asp:Label ID="LabelInfo" runat="server" Text="" ForeColor="Red"></asp:Label><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please provide username" ControlToValidate="TextBoxUsername" EnableClientScript="False" ForeColor="Red"></asp:RequiredFieldValidator><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please provide password" EnableClientScript="False" ForeColor="Red" ControlToValidate="TextBoxPassword"></asp:RequiredFieldValidator><br />
            </div>
        </div>
    </form>
</body>
</html>
