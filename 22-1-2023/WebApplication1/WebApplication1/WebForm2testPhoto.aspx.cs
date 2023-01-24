using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2testPhoto : System.Web.UI.Page
    {
        entityFrameworkTaskEntities1 db = new entityFrameworkTaskEntities1();

        protected void Page_Load(object sender, EventArgs e)
        {
            var query = (from t1 in db.Citys
                        join t2 in db.Customers
                        on t1.id equals t2.City_id
                        select new { t2.Customer_id, t2.Customer_name, t2.Age, t2.Email, t2.Phone, t2.Photo, t1.city1 }).Take(4);

            var result = query.ToList();


            GridView1.DataSource = result;
            GridView1.DataBind();
        }
    }
}