<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeInsert.aspx.cs" Inherits="FinalSuperMarket.EmployeeInsert" %>

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
            <asp:Label ID="Label1" runat="server" Text="员工姓名:"></asp:Label><br />
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                        <asp:Label ID="Label2" runat="server" Text="员工序号:"></asp:Label><br />
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                        <asp:Label ID="Label3" runat="server" Text="员工联系方式:"></asp:Label><br />
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br /><br />
            <asp:Button ID="Button1"
            runat="server" Text="插入" onclick="Button1_Click" Cssclass="button"/><br />
        </div>
    </form>
        </div>
</body>
</html>
