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
    public partial class EmployeeInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //调用配置文件中的连接字符串
            string connectionString = "server=.;database=Test;uid=realadmin;pwd=123456";
            //查询语句，查询输入框对应 语句中的 "+TextBox1.Text +"
            string sql = "INSERT INTO Employee VALUES ('" + TextBox1.Text + "'" + "," + TextBox2.Text + "," + "'" + TextBox3.Text + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                int num = cmd.ExecuteNonQuery();
                if (num == 0)
                {
                    Response.Write("<script language=javascript>alert('插入失败！');window.location = 'EmployeeInsert.aspx';</script>");
                }
                else
                    Response.Write("<script language=javascript>alert('插入成功！');window.location = 'EmployeeInsert.aspx';</script>");
            }
            catch (SqlException ee)
            {
                Label1.Text += string.Format("错误：", ee.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}