﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace FinalSuperMarket
{
    public partial class CargoOutFind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //调用配置文件中的连接字符串
            string connectionString = "server=.;database=Test;uid=realadmin;pwd=123456";
            //查询语句，查询输入框对应 语句中的 "+TextBox1.Text +"
            string sql = "SELECT * " +
                "FROM CargoOut " +
                "WHERE ";
            if(TextBox4.Text.Trim()!=string.Empty)
            {
                sql = sql + "BussinessNo='" + TextBox4.Text + ",";
                if (TextBox3.Text.Trim() != string.Empty)
                {
                    sql = sql + "AND EmpolyeeNo=" + TextBox3.Text;
                    if (TextBox1.Text.Trim() != string.Empty)
                    {
                        sql = sql + "AND CargoName='" + TextBox1.Text + "'";
                        if (TextBox2.Text.Trim() != string.Empty)
                        {
                            sql = sql + "AND CargoNo=" + TextBox2.Text;
                        }
                    }
                }
            }
            else if(TextBox3.Text.Trim() != string.Empty)
            {
                sql = sql + "EmpolyeeNo=" + TextBox3.Text;
                if (TextBox1.Text.Trim() != string.Empty)
                {
                    sql = sql + "AND CargoName='" + TextBox1.Text + "'";
                    if (TextBox2.Text.Trim() != string.Empty)
                    {
                        sql = sql + "AND CargoNo=" + TextBox2.Text;
                    }
                }
            }
            else if (TextBox1.Text.Trim() != string.Empty)
            {
                sql = sql + "CargoName='" + TextBox1.Text + "'";
                if (TextBox2.Text.Trim() != string.Empty)
                {
                    sql = sql + "AND CargoNo=" + TextBox2.Text;
                }
            }
            else if (TextBox2.Text.Trim() != string.Empty)
            {
                sql = sql + "CargoNo=" + TextBox2.Text;
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataReader reader1 = cmd.ExecuteReader();
                if (!reader1.Read())
                {
                    Response.Write("<script language=javascript>alert('根本就没有这条记录嘛!');window.location = 'CargoInFind.aspx';</script>");
                    reader1.Close();
                }
                else
                {
                    reader1.Close();
                    SqlDataReader reader = cmd.ExecuteReader();
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    reader.Close();
                }
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