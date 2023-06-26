using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleInterestWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            localhost.WebServiceSI s=new localhost.WebServiceSI();
            double p=Convert.ToDouble(TextBox1.Text);
            double n = Convert.ToDouble(TextBox2.Text);
            double r = Convert.ToDouble(TextBox3.Text);
            double result=s.SI(p, n, r);
            Label1.Text = "Simple Interest: "+result.ToString();
        }
    }
}