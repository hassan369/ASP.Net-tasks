using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie color = Request.Cookies["txtColor"];

            if (color != null)
            {
                string color2 = color["color"];
                Label1.Attributes.Add("style", $"color:{color2}");
                
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }




        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Attributes.Add("style", $"color:{DropDownList1.SelectedValue}");

            HttpCookie color = Request.Cookies["txtColor"];
            if (color == null)
            {
                color = new HttpCookie("txtColor");
                color.Values["color"] = DropDownList1.SelectedValue;
                
            }
            else
            {
                color.Values["color"] = DropDownList1.SelectedValue;
                
            }

            Response.Cookies.Add(color);

            
        }
    }
}