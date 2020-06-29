<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargoInFind.aspx.cs" Inherits="FinalSuperMarket.CargoInFind" %>

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
             <asp:Label ID="Label1" runat="server" Text="商品名称:"></asp:Label><br />
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
             <asp:Label ID="Label2" runat="server" Text="商品序号:"></asp:Label><br />
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br /><br />
            <asp:Button ID="Button1"
            runat="server" Text="搜索" onclick="Button1_Click" CssClass="button" /><br />
            <div>
            <asp:GridView ID="GridView1" runat="server" Cssclass="Grid">
            </asp:GridView>
                </div>
        </div>
    </form>
    </div>
</body>
</html>
