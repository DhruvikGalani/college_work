<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="college_work.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 61%;
            height: 184px;
        }
        .auto-style2 {
            height: 32px;
        }
        .auto-style3 {
            width: 376px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="3" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style3">User Name :</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Password :</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2" style="text-align: center">
                        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="lblDetails" runat="server" Text="Details :"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
