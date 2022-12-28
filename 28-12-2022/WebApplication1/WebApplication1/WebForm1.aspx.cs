using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = null;
            SqlConnection con2 = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source = DESKTOP-HIMQ0KV\\SQLEXPRESS; database=task28-12; integrated security=SSPI");
                con2 = new SqlConnection("data source = DESKTOP-HIMQ0KV\\SQLEXPRESS; database=task28-12; integrated security=SSPI");

                // writing sql query  
                if (TextBox1.Text == "")
                {
                    return;
                }
                SqlCommand cm = new SqlCommand($"insert into comments  values('{TextBox1.Text}')", con);
                SqlCommand cm2 = new SqlCommand($"select * from  comments ORDER BY id;", con2);

                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();

                //ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "swal('Member Registered Sucessfully');", true);

                //ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                //"swal('Good job!', 'Message added seccessfully ', 'success')", true);

                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert",
                "swal('Good job!', 'Message added seccessfully ')", true);
                // Displaying a message  
            //    Console.WriteLine("Record Inserted Successfully");
                //Label1.Text = "Record Inserted Successfully";
                con2.Open();
                SqlDataReader sdr = cm2.ExecuteReader();
                Label1.Text = "";
                while(sdr.Read())
                {
                    Label1.Text += $"{sdr[0]}: {sdr[1]}<br/>";
                }


            }
            catch (Exception A)
            {
              
                Label1.Text = "OOPs, something went wrong." + A;
            }
            // Closing the connection  
            finally
            {
                con.Close();
                con2.Close();
            }
        }
    }
}