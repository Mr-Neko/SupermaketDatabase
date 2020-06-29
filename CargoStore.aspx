<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargoStore.aspx.cs" Inherits="FinalSuperMarket.CargoStore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
                    <link rel="stylesheet" type="text/css" href="CSS/CssAll.css" />
        <script>
    function CargoInsert(){
	    window.location.href("CargoInsert.aspx");
    }
    function CargoFind() {
        window.location.href("CargoFind.aspx")
        }
</script>
</head>
<body>
    <div id="content">
    <form id="form1" runat="server">
        <div>
            <br /><br /><br />
            <input type="button" name="btn1" value="查询商品存货" onclick="CargoFind()" class="button" />
        </div>
    </form>
    <p>
            <input type="button" name="btn2" value="插入新的商品" onclick="CargoInsert()" class="button" /></p>
        </div>
</body>
</html>
