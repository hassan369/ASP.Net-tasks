using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class delete_and_update : System.Web.UI.Page
    {
        entityFrameworkTaskEntities1 dd = new entityFrameworkTaskEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var customer = dd.Customers.Find(3);
            dd.Customers.Remove(customer);
            dd.SaveChanges();

            //var customer = new Customer { Customer_id = 2};
            //dd.Customers.Attach(customer);
            //dd.Entry(customer).State = EntityState.Deleted;
            //dd.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var customer = dd.Customers.Find(1);
            customer.Customer_name = "hassan2";
            dd.SaveChanges();
        }
    }
}