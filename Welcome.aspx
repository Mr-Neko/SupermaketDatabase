<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="FinalSuperMarket.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS/CssAll.css" />
<script>
    function Cargo(){
	    window.location.href("Cargo.aspx");
    }
    function Employee() {
        window.location.href("Employee.aspx")
    }
</script>
</head>
<body>
    <div id="content">
    <form id="form1" runat="server">
    &nbsp;
    <div>
        YOU ARE THE GUY CHOOSED.
    </div>
        <br /><br /><br />
    <input type="button" name="btn2" value="商品管理" onclick="Cargo();" class="button"/><br /><br />
    <input type="button" name="btn2" value="人员管理" onclick="Employee();" class="button"/>
    </form>
        </div>
</body>
</html>