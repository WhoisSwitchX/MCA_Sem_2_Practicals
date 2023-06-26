using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceClient srv = new ServiceReference1.ServiceClient();
        double p = Convert.ToDouble(TextBox1.Text);
        double n = Convert.ToDouble(TextBox2.Text);
        double r = Convert.ToDouble(TextBox3.Text);
        double ans = srv.simpleIntrest(p, n, r);
        Label1.Text = ans.ToString();

    }
}