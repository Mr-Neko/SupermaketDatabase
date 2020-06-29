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
    public partial class Count : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //调用配置文件中的连接字符串
            string connectionString = "server=.;database=Test;uid=realadmin;pwd=123456";
            //查询语句，查询输入框对应 语句中的 "+TextBox1.Text +"
            string sql = "SELECT *, (CargoPrice*CargoNum) as MoneyIn " +
                "FROM CargoOut " +
                "WHERE Month=" + TextBox1.Text;
            string sql2 = "SELECT SUM(CargoPrice*CargoNum) as ALL_MONEY_IN "+"FROM CargoOut " + "WHERE Month=" + TextBox1.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                reader.Close();
                SqlDataReader reader2 = cmd2.ExecuteReader();
                GridView2.DataSource = reader2;
                GridView2.DataBind();
                reader2.Close();
            }
            catch (SqlException exc)
            {
                Label1.Text += string.Format("错误：", exc.Message);
            }
            finally
            {
                con.Close();
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //调用配置文件中的连接字符串
            string connectionString = "server=.;database=Test;uid=realadmin;pwd=123456";
            //查询语句，查询输入框对应 语句中的 "+TextBox1.Text +"
            string sql = "SELECT *, (CargoPrice*CargoNum) as MoneyIn " +
                "FROM CargoOut " +
                "WHERE Month=" + TextBox1.Text + " AND DAY=" + TextBox2.Text;
            string sql2 = "SELECT SUM(CargoPrice*CargoNum) as ALL_MONEY_IN " + "FROM CargoOut " + "WHERE Month=" + TextBox1.Text + " AND DAY=" + TextBox2.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                reader.Close();
                SqlDataReader reader2 = cmd2.ExecuteReader();
                GridView2.DataSource = reader2;
                GridView2.DataBind();
                reader2.Close();
            }
            catch (SqlException exc)
            {
                Label1.Text += string.Format("错误：", exc.Message);
            }
            finally
            {
                con.Close();
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            //调用配置文件中的连接字符串
            string connectionString = "server=.;database=Test;uid=realadmin;pwd=123456";
            //查询语句，查询输入框对应 语句中的 "+TextBox1.Text +"
            string sql = "";
            string sql2 = "";
            if (TextBox1.Text.Trim() == string.Empty && TextBox2.Text.Trim() == string.Empty)
            {
                sql = "SELECT Month, CargoNo, CargoName, SUM(CargoNum) as MonthNum, SUM(CargoPrice*CargoNum) as ALL_MONEY_IN " +
                 "FROM CargoOut " +
                 "WHERE " + "CargoNo=" + TextBox3.Text + "GROUP BY CargoNo, Month, CargoName";
                sql2 = "SELECT Month, Day, CargoNo, CargoName, SUM(CargoNum) as DayNum, SUM(CargoPrice*CargoNum) as ALL_MONEY_IN " + "FROM CargoOut " + "WHERE "  + "CargoNo=" + TextBox3.Text + "GROUP BY CargoNo, Day, CargoName, Month";
            }
            else
            {

                sql = "SELECT CargoNo, CargoName, SUM(CargoNum) as MonthNum, SUM(CargoPrice*CargoNum) as ALL_MONEY_IN " +
                    "FROM CargoOut " +
                    "WHERE Month=" + TextBox1.Text + " AND CargoNo=" + TextBox3.Text + "GROUP BY CargoNo, CargoName";
                sql2 = "SELECT CargoNo, CargoName, SUM(CargoNum) as DayNum, SUM(CargoPrice*CargoNum) as ALL_MONEY_IN " + "FROM CargoOut " + "WHERE Month=" + TextBox1.Text + " AND DAY=" + TextBox2.Text + "AND CargoNo=" + TextBox3.Text + "GROUP BY CargoNo, CargoName";
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                reader.Close();
                SqlDataReader reader2 = cmd2.ExecuteReader();
                GridView2.DataSource = reader2;
                GridView2.DataBind();
                reader2.Close();
            }
            catch (SqlException exc)
            {
                Label1.Text += string.Format("错误：", exc.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}