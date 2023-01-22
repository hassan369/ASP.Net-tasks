using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        entityFrameworkTaskEntities1 db = new entityFrameworkTaskEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from t1 in db.Citys
                        join t2 in db.Customers
                        on t1.id equals t2.City_id
                        select new { t2.Customer_id, t2.Customer_name, t2.Age, t2.Email, t2.Phone, t2.Photo, t1.city1 };
            var result = query.ToList();




            //var data3 =  db.Customers.ToList();
            cont.InnerHtml += "<h1>A Fancy Table</h1>\r\n\r\n<table id=\"customers\"><tr>\r\n    <th>Name</th>\r\n    <th>Age</th>\r\n    <th>City</th>\r\n    <th>phone number</th>\r\n    <th>Email</th>\r\n    <th>Photo</th>\r\n  </tr>";
            foreach (var entity in result)
            {
                cont.InnerHtml += $"<tr>\r\n    <td>{entity.Customer_name}</td>\r\n    <td>{entity.Age}</td>\r\n    <td>{entity.city1}</td>\r\n    <td>{entity.Phone}</tdh>\r\n    <td>{entity.Email}</td>\r\n    <td><img style='width:200px;height:100px ' src={entity.Photo} /></td>\r\n  </tr>";
            }
            //var obj = db.Citys.ToList();
            //GridView1.DataSource= data3;
            //GridView1.DataBind();

            //var query2 = from t1 in db.Citys
            //            join t2 in db.Customers
            //            on t1.id equals t2.City_id
            //            select new { t2.Customer_id, t2.Customer_name, t2.Age, t2.Email, t2.Phone, t2.Photo, t1.city1 };
            //var result2 = query.ToList();




            ////var data3 =  db.Customers.ToList();
            //cont2.InnerHtml += "<h1>A Fancy Table</h1>\r\n\r\n<table id=\"customers\"><tr>\r\n    <th>Name</th>\r\n    <th>Age</th>\r\n    <th>City</th>\r\n    <th>phone number</th>\r\n    <th>Email</th>\r\n    <th>Photo</th>\r\n  </tr>";
            //foreach (var entity in result2)
            //{
            //    cont2.InnerHtml += $"<tr>\r\n    <td>{entity.Customer_name}</td>\r\n    <td>{entity.Age}</td>\r\n    <td>{entity.city1}</td>\r\n    <td>{entity.Phone}</tdh>\r\n    <td>{entity.Email}</td>\r\n    <td><img style='width:200px;height:100px ' src={entity.Photo} /></td>\r\n  </tr>";
            //}
            ////var obj = db.Citys.ToList();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (TextBox1.Text.Any(x => !char.IsLetter(x))) {
                 id = Convert.ToInt32(TextBox1.Text);
            }

            var query = from t1 in db.Citys
                        join t2 in db.Customers
                        on t1.id equals t2.City_id
                        where t2.Customer_name.Contains(TextBox1.Text) || t2.Customer_id == id
                        select new { t2.Customer_id, t2.Customer_name, t2.Age, t2.Email, t2.Phone, t2.Photo, t1.city1 };
            var result = query.ToList();

            cont.InnerText = "";
            cont.InnerHtml += "<h1>A Fancy Table</h1>\r\n\r\n<table id=\"customers\"><tr>\r\n    <th>Name</th>\r\n    <th>Age</th>\r\n    <th>City</th>\r\n    <th>phone number</th>\r\n    <th>Email</th>\r\n    <th>Photo</th>\r\n  </tr>";
            foreach (var entity in result)
            {
                cont.InnerHtml += $"<tr>\r\n    <td>{entity.Customer_name}</td>\r\n    <td>{entity.Age}</td>\r\n    <td>{entity.city1}</td>\r\n    <td>{entity.Phone}</tdh>\r\n    <td>{entity.Email}</td>\r\n    <td><img style='width:200px;height:100px ' src={entity.Photo} /></td>\r\n  </tr>";
            }
        }
    }
}