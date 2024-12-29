<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show_Dept.aspx.cs" Inherits="college_work.Dept___Course.show_Dept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvDataDept" runat="server">
            </asp:GridView>
            <br />
            <asp:GridView ID="gvDataCourse" runat="server">
            </asp:GridView>
            <asp:DropDownList ID="ddlDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDept_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlCourse" runat="server">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
