
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regestrationForm.aspx.cs" Inherits="college_work.regestrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 72%;
            border: 1px solid #808080;
            table-layout: auto;
            height: 441px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style6 {
            height: 24px;
        }
        .auto-style7 {
            height: 26px;
            width: 419px;
        }
        .auto-style8 {
            width: 419px;
        }
        .auto-style9 {
            margin-left: 2px;
        }
        .auto-style10 {
            height: 26px;
            width: 331px;
        }
        .auto-style11 {
            width: 331px;
        }
    </style>
</head>
<body style="">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="border-width: 0px; padding: 0px; margin: 0px; background-color: #CCCCCC; border-spacing: 2px; border-collapse: separate; ">
                <tr>
                    <td class="auto-style3" colspan="2" style="border-style: hidden; border-width: 0px">Regeistration Form</td>
                </tr>
                <tr>
                    <td class="auto-style10">Name : </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Gender :</td>
                    <td class="auto-style8">
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>male</asp:ListItem>
                            <asp:ListItem>female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">DOB : </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Social media : </td>
                    <td class="auto-style7">
                        <asp:CheckBoxList ID="cblSocialMedia" runat="server" CssClass="auto-style9" RepeatDirection="Horizontal">
                            <asp:ListItem>instagram</asp:ListItem>
                            <asp:ListItem>facebook</asp:ListItem>
                            <asp:ListItem>threads</asp:ListItem>
                            <asp:ListItem>whatsApp</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">City : </td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Address : </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">File Upload :</td>
                    <td class="auto-style7">
                        <asp:FileUpload ID="fuUpload" runat="server" />
                    </td>
                </tr>
                <tr>

                    <td class="auto-style3" colspan="2" style="text-align: center; justify-items:center; white-space: pre-wrap;" aria-orientation="horizontal">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />

                    </tr>
                <tr>
                    <td class="auto-style6" colspan="2">&nbsp;<asp:Label ID="lblDetails" runat="server" Text="Details :"></asp:Label>
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
