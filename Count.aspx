<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Count.aspx.cs" Inherits="FinalSuperMarket.Count" %>

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
                         <asp:Label ID="Label1" runat="server" Text="查询时间月份:"></asp:Label><br />
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                         <asp:Label ID="Label2" runat="server" Text="查询时间日期:"></asp:Label><br />
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                                     <asp:Label ID="Label3" runat="server" Text="查询商品序号:"></asp:Label><br />
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
             <asp:Button ID="Button1"
            runat="server" Text="月统计" onclick="Button1_Click" Cssclass="button"/><br /><br />
            <asp:Button ID="Button2"
            runat="server" Text="日统计" onclick="Button2_Click" Cssclass="button"/><br /><br />
                        <asp:Button ID="Button3"
            runat="server" Text="商品统计" onclick="Button3_Click" Cssclass="button"/><br /><br />
            <asp:GridView ID="GridView1" runat="server" CssClass="Grid">
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server" CssClass="Grid">
            </asp:GridView>
        </div>
    </form>
        </div>
</body>
</html>
