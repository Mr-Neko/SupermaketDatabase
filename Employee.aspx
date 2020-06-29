<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="FinalSuperMarket.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
                        <link rel="stylesheet" type="text/css" href="CSS/CssAll.css" />
    <script>
    function EmployeeFind(){
	    window.location.href("EmployeeFind.aspx");
    }
    function EmployeeInsert() {
        window.location.href("EmployeeInsert.aspx")
        }
</script>
</head>
<body>
    <div id="content">
    <form id="form1" runat="server">
        <div>
            <br /><br /><br />
            <input type="button" name="btn1" value="员工情况查询" onclick="EmployeeFind()" class="button" />
        </div>
    </form>
    <p>
            <input type="button" name="btn2" value="员工信息插入" onclick="EmployeeInsert()" class="button" /></p>
        </div>
</body>
</html>
