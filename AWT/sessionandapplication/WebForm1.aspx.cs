using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sessionandapplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "Welcome, "+Session["User"].ToString()+" !";
            Application["NoOfVisitors"] = (int)Application["NoOfVisitors"] + 1;
            Label2.Text =Application["NoOfVisitors"].ToString();


        }
    }
}