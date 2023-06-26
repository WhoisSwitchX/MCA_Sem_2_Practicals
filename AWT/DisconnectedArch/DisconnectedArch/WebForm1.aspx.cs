using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedArch
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter myAdapter;
        static int sinindex;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=RUPESH\SQLEXPRESS;Initial Catalog=rupesh;Integrated Security=True";
            con.Open();
            string query = "select * from employee";
            myAdapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            

        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            string query = "select * from employee";
            myAdapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            SqlCommandBuilder cmb = new SqlCommandBuilder(myAdapter);
            DataRow dr = ds.Tables[0].NewRow();
            dr["Id"] = TextBox1.Text;
            dr["Name"] = TextBox2.Text;
            dr["City"] = TextBox3.Text;
            ds.Tables[0].Rows.Add(dr);
            myAdapter.Update(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            string query = "select * from employee";
            myAdapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            SqlCommandBuilder cmb = new SqlCommandBuilder(myAdapter);
            DataRow dr = ds.Tables[0].Rows[sinindex];
            dr["Id"] = Convert.ToInt32(TextBox1.Text);
            dr["Name"] = TextBox2.Text;
            dr["City"] = TextBox3.Text;
         
            myAdapter.Update(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            string query = "select * from employee";
            myAdapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            SqlCommandBuilder cmb = new SqlCommandBuilder(myAdapter);
            ds.Tables[0].Rows[sinindex].Delete();
           
            myAdapter.Update(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TextBox1.Text = GridView1.SelectedRow.Cells[0].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox3.Text = GridView1.SelectedRow.Cells[2].Text;

            sinindex =GridView1.SelectedIndex;
            

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow) { 
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row";
            }
        }
    }
}