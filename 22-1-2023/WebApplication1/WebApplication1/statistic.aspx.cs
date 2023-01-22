using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class statistic : System.Web.UI.Page
    {
        entityFrameworkTaskEntities1 db = new entityFrameworkTaskEntities1();

        protected void Page_Load(object sender, EventArgs e)
        {
            var num = (from m in db.Customers select m.Customer_id).Count();
            var avg = (from m in db.Customers select m.Age).Average();
            var maxAge = (from m in db.Customers select m.Age).Max();

            //var query = from t1 in db.Customers
                      
            //            select new { t1.Customer_id, t1.Customer_name, t1.Age, t1.Email, t2.Phone, t1.Photo, t1.city1 };
            //var result = query.ToList();




            //var data3 =  db.Customers.ToList();
            cont.InnerHtml += "<h1>A Fancy Table</h1>\r\n\r\n<table id=\"customers\"><tr>\r\n    <th>Number Of Customers</th>\r\n    <th>AVG Age</th>\r\n    <th>MAX Age</th>\r\n </tr>";
            //foreach (var entity in result)
            //{
                cont.InnerHtml += $"<tr>\r\n    <td>{num}</td>\r\n    <td>{avg}</td>\r\n    <td>{maxAge}</td>\r\n  </tr>";
            //}
        }
    }
}