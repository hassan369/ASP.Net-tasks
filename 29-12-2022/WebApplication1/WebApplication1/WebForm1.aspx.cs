using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    //class Person
    //{
    //   public string email;
    //   public string password;
    //}
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookieObj = Request.Cookies["login"];

                if (cookieObj != null)
                {
                    TextBox1.Text = cookieObj["email"];
                    TextBox2.Text = cookieObj["password"];
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            if(check.Checked)
            {
                HttpCookie person = Request.Cookies["login"];
                if (person == null)
                {
                    person = new HttpCookie("login");
                    person.Values["email"] = TextBox1.Text;
                    person.Values["password"] = TextBox2.Text;
                }
                else
                {
                    person.Values["email"] = TextBox1.Text;
                    person.Values["password"] = TextBox2.Text;
                }

                 
              

                Response.Cookies.Add(person);

            }
        }
    }
}