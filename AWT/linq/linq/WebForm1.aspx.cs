using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Class1> books = Class1.GetBooks();
            var booktitles = from b in books select b.title;
            foreach(var title in booktitles)
            {
                Label1.Text += String.Format("{0}<br/>", title);

            }


        }
    }
}