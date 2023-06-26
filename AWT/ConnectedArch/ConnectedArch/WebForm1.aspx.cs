using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ConnectedArch
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=RUPESH\SQLEXPRESS;Initial Catalog=rupesh;Integrated Security=True";
            con.Open();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
            cmd = new SqlCommand("select * from student", con);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                TextBox1.Text+=reader[0].ToString() + " "+Environment.NewLine;
                TextBox2.Text+=reader[1].ToString()+" "+Environment.NewLine;

            }
            con.Close();
        }
    }
}