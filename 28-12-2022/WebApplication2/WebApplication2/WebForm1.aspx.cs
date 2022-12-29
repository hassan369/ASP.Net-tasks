using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["name"] = "ahmad";
            string name = Session["name"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int counter;
            if (ViewState["counter"] == null)
            {
                //counter in view state still not created(first tmie)
                counter = 1;
                Label1.Text = counter.ToString();
            } 
            else
            {
                //will executed from the second time
                counter = (int)ViewState["counter"] + 1;
                Label1.Text = counter.ToString();
            }
            ViewState["counter"] = counter;


        }
    }
}