using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class delete : System.Web.UI.Page
    {
        entityFrameworkTaskEntities1 dd = new entityFrameworkTaskEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var x = dd.Citys.ToList();

                //DropDownList1.DataValueField = "id";
                //DropDownList1.DataTextField = "city1";
                //DropDownList1.DataSource = x;
                //DropDownList1.DataBind();

                int id2 = Convert.ToInt32(Request.QueryString["ID"]);
                var customer = dd.Customers.Find(id2);


                nameqq.Text = customer.Customer_name.ToString();
                ageqq.Text = customer.Age.ToString();
                //DropDownList1.SelectedValue = customer.City.ToString();
                phoneqq.Text = customer.Phone.ToString();
                emailqq.Text = customer.Email.ToString();


                //Customer_name = nameqq.Value,
                //    Age = Convert.ToInt32(ageqq.Value),
                //    City_id = Convert.ToInt32(DropDownList1.SelectedValue),
                //    Phone = Convert.ToInt32(phoneqq.Value),
                //    Email = emailqq.Value,
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id2 = Convert.ToInt32(Request.QueryString["ID"]);

            var customer = dd.Customers.Find(id2);
            dd.Customers.Remove(customer);
            dd.SaveChanges();
            Response.Redirect("WebForm1.aspx");
        }
    }
}