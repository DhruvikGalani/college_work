<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regestrationForm.aspx.cs" Inherits="college_work.regestrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #808080;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 223px;
        }
        .auto-style5 {
            height: 26px;
            width: 223px;
        }
        .auto-style6 {
            height: 24px;
        }
    </style>
</head>
<body style="">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="border-style: 0; border-color: 0; border-width: 0px; padding: 0px; margin: 0px; background-color: #CCCCCC; border-spacing: 2px; border-collapse: separate; table-layout: auto;">
                <tr>
                    <td class="auto-style3" colspan="2" style="border-style: hidden; border-width: 0px">Regeistration Form</td>
                </tr>
                <tr>
                    <td class="auto-style5">Name : </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Gender :</td>
                    <td>
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>male</asp:ListItem>
                            <asp:ListItem>female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">DOB : </td>
                    <td>
                        <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Social media : </td>
                    <td class="auto-style3">
                        <asp:CheckBoxList ID="cblSocialMedia" runat="server">
                            <asp:ListItem>instagram</asp:ListItem>
                            <asp:ListItem>facebook</asp:ListItem>
                            <asp:ListItem>threads</asp:ListItem>
                            <asp:ListItem>whatsApp</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">City : </td>
                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server">
                            <asp:ListItem>select</asp:ListItem>
                            <asp:ListItem>surat</asp:ListItem>
                            <asp:ListItem>tapi</asp:ListItem>
                            <asp:ListItem>bhavanagar</asp:ListItem>
                            <asp:ListItem>ahmedabad</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Address : </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">File Upload :</td>
                    <td class="auto-style3">
                        <asp:FileUpload ID="fuUpload" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2" style="text-align: center; vertical-align: middle; white-space: pre-wrap;">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">&nbsp;<asp:Label ID="lblDetails" runat="server" Text="Details :"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
