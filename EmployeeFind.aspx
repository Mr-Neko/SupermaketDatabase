<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeFind.aspx.cs" Inherits="FinalSuperMarket.EmployeeFind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
                            <link rel="stylesheet" type="text/css" href="CSS/CssAll.css" />
</head>
<body>
    <div id="content">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="员工序号:"></asp:Label><br />
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br /><br />
            <asp:Button ID="Button1"
            runat="server" Text="查找" onclick="Button1_Click" Cssclass="button"/><br />
            <asp:GridView ID="GridView1" runat="server" CssClass="Grid">
            </asp:GridView>
        </div>
    </form>
        </div>
</body>
</html>
