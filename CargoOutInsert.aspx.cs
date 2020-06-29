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
    public partial class CargoOutInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //调用配置文件中的连接字符串
            string connectionString = "server=.;database=Test;uid=realadmin;pwd=123456";
            //查询语句，查询输入框对应 语句中的 "+TextBox1.Text +"
            string sql = "INSERT INTO CargoOut VALUES ("  + TextBox1.Text + "," + "'" + TextBox2.Text + "'" + "," + TextBox3.Text + "," + TextBox4.Text + "," + TextBox5.Text + "," + TextBox6.Text + ","  + TextBox7.Text + "," + TextBox8.Text + ",'" + TextBox9.Text + "')";
            string sql2 = "UPDATE CargoStore SET CargoNum=";
            string sql3 = "SELECT * FROM CargoStore WHERE CargoName=" + "'" + TextBox2.Text + "'";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd3.ExecuteReader();
                int nums = 0;
                while (reader.Read())
                {
                    nums = Convert.ToInt32(reader["CargoNum"]);
                }
                reader.Close();
                if (nums == 0)
                {
                    Response.Write("<script language=javascript>alert('库存中不存在此物品！');window.location = 'CargoOutInsert.aspx';</script>");
                }
                else
                {
                    if (nums - Convert.ToInt32(TextBox8.Text) < 0)
                        Response.Write("<script language=javascript>alert('库存中此物品数量不足！');window.location = 'CargoOutInsert.aspx';</script>");
                    else
                    {
                        sql2 = sql2 + (nums - Convert.ToInt32(TextBox8.Text)).ToString() + " WHERE CargoNo=" + TextBox1.Text;
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.ExecuteNonQuery();
                    }
                }
                int num = 0;
                num = cmd.ExecuteNonQuery();
                if (num == 0)
                {
                    Response.Write("<script language=javascript>alert('出库记录插入失败！');window.location = 'CargoOutInsert.aspx';</script>");
                }
                else
                    Response.Write("<script language=javascript>alert('出库记录插入成功！');window.location = 'CargoOutInsert.aspx';</script>");
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