using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class addCustomerForm : System.Web.UI.Page
    {
        entityFrameworkTaskEntities1 db = new entityFrameworkTaskEntities1 ();
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = db.Citys.ToList ();

            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "city1";
            DropDownList1.DataSource = x;
            DropDownList1.DataBind();


            //DropDownList1.DataSource= x;
            //DropDownList1.DataTextField = "city";
            //DropDownList1.DataValueField = "id";
            //DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

             //create path for the folder where to save the image
                string folderPath = Server.MapPath("~/Images/");

                //Check whether Directory (Folder) exists.
                if (!Directory.Exists(folderPath))
                {
                    //If Directory (Folder) does not exists Create it.
                    Directory.CreateDirectory(folderPath);
                }

                //Save the File to the Directory (Folder).
                string fullPath = folderPath + Path.GetFileName(FileUpload1.FileName);
                string srcPath = "/Images/" + Path.GetFileName(FileUpload1.FileName);

                FileUpload1.SaveAs(fullPath);
                //Image1.ImageUrl = srcPath;
                if (FileUpload1 != null && FileUpload1.HasFile)
                {

                    // Explicitly check if the file was an image (example approach)
                    if (FileUpload1.PostedFile.ContentType.ToLower().StartsWith("image/"))
                    {
                        // It is an image, save it
                        FileUpload1.SaveAs(fullPath);

                    }
                    else
                    {
                        Label1.Text += " file uploaded is not an image ";
                        return;
                        // Not an image, handle accordingly
                    }
                }

                Customer newOne = new Customer();
                newOne.Customer_name = nameqq.Value;
                newOne.Age = Convert.ToInt32(ageqq.Value);
                newOne.City_id = Convert.ToInt32(DropDownList1.SelectedValue);
                newOne.Phone = Convert.ToInt32(phoneqq.Value);
                newOne.Email = emailqq.Value;
            newOne.Photo = $"Images/{Path.GetFileName(FileUpload1.FileName)}";
            
            db.Customers.Add(newOne);
            db.SaveChanges();



        }
    }
}