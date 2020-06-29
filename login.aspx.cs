using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace FinalSuperMarket
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user_number = Number.Text.ToString();
            string user_pwd = Password.Text.ToString();
            string connstring = "server=.;database=Test;uid=realadmin;pwd=123456";//server=. 代表本地服务器，就是自己的电脑
            //database=test_login 数据库名
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = conn.CreateCommand();    //创建数据库命令 
            cmd.CommandText = "select * from user_inf WHERE No=" + user_number + "AND Pwd=" + "'" + user_pwd + "'";    //创建查询语句 
            try
            {
                conn.Open();//打开数据库 
                SqlDataReader sdr = cmd.ExecuteReader();    //从数据库中读取数据流存入reader中                                              
                if (sdr.Read()) //从sdr中读取下一行数据,如果没有数据,sdr.Read()返回flase 
                {
                    HttpContext.Current.Session["UserId"] = user_number;
                    HttpContext.Current.Session["Userpwd"] = user_pwd;
                    Response.Redirect("welcome.aspx");
                }
                else
                {
                    //Message.Text = "输入错误，请重新输入！";

                    // Response.Redirect("login.aspx");
                    // Response.Write("<script>confirm('输入账号或密码错误！');</script>");

                    Response.Write("<script language=javascript>alert('输入账号或密码错误！');window.location = 'login.aspx';</script>");

                }
            }
            catch (Exception ee)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}