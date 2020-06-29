<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargoInInsert.aspx.cs" Inherits="FinalSuperMarket.CargoInInsert" %>

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
             <asp:Label ID="Label1" runat="server" Text="商品序号:"></asp:Label><br />
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                         <asp:Label ID="Label2" runat="server" Text="商品名称:"></asp:Label><br />
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                         <asp:Label ID="Label3" runat="server" Text="商品数量:"></asp:Label><br />
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                         <asp:Label ID="Label4" runat="server" Text="商品单价:"></asp:Label><br />
             <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                         <asp:Label ID="Label5" runat="server" Text="入库年:"></asp:Label><br />
             <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                         <asp:Label ID="Label6" runat="server" Text="入库月:"></asp:Label><br />
             <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
                         <asp:Label ID="Label7" runat="server" Text="入库日:"></asp:Label><br />
             <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
                         <asp:Label ID="Label8" runat="server" Text="商品来源:"></asp:Label><br />
             <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br /><br /><br />
            <asp:Button ID="Button1"
            runat="server" Text="插入" onclick="Button1_Click" CssClass="button" /><br />
        </div>
    </form>
        </div>
</body>
</html>
