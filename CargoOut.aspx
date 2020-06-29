<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargoOut.aspx.cs" Inherits="FinalSuperMarket.CargoOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
                <link rel="stylesheet" type="text/css" href="CSS/CssAll.css" />
 <script>
    function CargoInsert(){
	    window.location.href("CargoOutInsert.aspx");
    }
    function CargoFind() {
        window.location.href("CargoOutFind.aspx")
        }
</script>
</head>
<body>
    <div id="content">
    <form id="form1" runat="server">
        <div>
            <br /><br /><br />
            <input type="button" name="btn1" value="查询销售记录" onclick="CargoFind()" class="button" />
        </div>
    </form>
    <p>
            <input type="button" name="btn2" value="记录销售信息" onclick="CargoInsert()" class="button" /></p>
        </div>
</body>
</html>
