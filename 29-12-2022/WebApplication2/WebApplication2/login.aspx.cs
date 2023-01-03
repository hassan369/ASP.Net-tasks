using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security; // the only added one

namespace WebApplication2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //added login button 
        protected void Login_Click(object sender, EventArgs e)
        {
            //now lets check if username and password are the same as in the authentication in config
            if (FormsAuthentication.Authenticate(UserName.Text, UserPass.Text))
            {
                //now if the chkboxPersist is true , the userName.Text will be saved in cookies.
                FormsAuthentication.RedirectFromLoginPage(UserName.Text, chkboxPersist.Checked);
            }
            else
            {
                Msg.Text = "Invalid User Name and/or Password";
            }
        }

       
    }
}