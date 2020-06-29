<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FinalSuperMarket.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS/CssTest.css" />
<script>
    function fun1() {
        alert('忘了我也没办法');
    }
    function fun2() {
        alert('请寻找系统管理员去数据库注册');
    }
</script>
</head>
<body>
<div id="content">
    <div class="login-header">
        欢迎访问本管理系统

    </div>
    <form runat="server">
        <div class="login-input-box">
            <span class="icon icon-user"></span>
            <asp:TextBox ID="Number" runat="server" CssClass="pwd" placeholder="Please enter your number" OnTextChanged="Number_TextChanged"></asp:TextBox>
        </div>
        <div class="login-input-box">
            <span class="icon icon-password"></span>
            <asp:TextBox ID="Password" runat="server" CssClass="pwd" placeholder="Please enter your password"></asp:TextBox>
        </div>
    <div class="remember-box">
        <label>
            <input type="checkbox"/>&nbsp;Remember Me
        </label>
    </div>
    <div class="login-button-box">
        <asp:Button ID="Button1" runat="server" Text="Login" onclick="Page_Load" CssClass="button" />
    </div>
    <div class="logon-box">
        <a href="#" onclick="fun1()">Forgot?</a>
        <a href="#" onclick="fun2()">Register</a>
    </div>
            </form>
</div>
</body>
</html>
