<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cargo.aspx.cs" Inherits="FinalSuperMarket.Cargo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link rel="stylesheet" type="text/css" href="CSS/CssAll.css" />
    <script>
    function CargoStore(){
	    window.location.href("CargoStore.aspx");
    }
    function CargoIn() {
        window.location.href("CargoIn.aspx");
        }
    function CargoOut() {
        window.location.href("CargoOut.aspx");
        }
        function count() {
            window.location.href("Count.aspx");
        }
</script>
</head>
<body>
    <div id="content">
    <form id="form1" runat="server">
        <div>
            <br /><br /><br />
            <input type="button" name="btn1" value="商品存货管理" onclick="CargoStore()" class="button" />
    <p>
            <input type="button" name="btn2" value="商品入库管理" onclick="CargoIn()" class="button" /></p>
    <p>
            <input type="button" name="btn3" value="商品出库管理" onclick="CargoOut()" class="button" /></p>
    <p>
            <input type="button" name="btn4" value="商品统计" onclick="count()" class="button" /></p>
        </div>
    </form>
        </div>
</body>
</html>
