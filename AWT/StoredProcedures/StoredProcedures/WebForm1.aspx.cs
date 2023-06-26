using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace StoredProcedures
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=RUPESH\SQLEXPRESS;Initial Catalog=rupesh;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("submitrecord", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.Parameters.Add("@id", SqlDbType.VarChar);
            param.Value = TextBox1.Text;
            SqlParameter param1 = cmd.Parameters.Add("@name", SqlDbType.VarChar);
            param1.Value = TextBox2.Text;
            cmd.ExecuteNonQuery();
            GridView1.DataBind();
            con.Close();
        }
    }
}