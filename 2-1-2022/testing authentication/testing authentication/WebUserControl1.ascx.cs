using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace testing_authentication
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] != null)
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-HIMQ0KV\\SQLEXPRESS; Database=authentication; integrated security = true");
                con.Open();
                after.Attributes["style"] = "display: inline";
                RadioButtonList1.Attributes["style"] = "display: none";
                Button1.Attributes["style"] = "display: none";


                SqlCommand cmd1 = new SqlCommand("select SUM([A]) from users", con);
                int A = (int)cmd1.ExecuteScalar();
                SqlCommand cmd2 = new SqlCommand("select SUM([B]) from users", con);
                int B = (int)cmd2.ExecuteScalar();
                SqlCommand cmd3 = new SqlCommand("select SUM([C]) from users", con);
                int C = (int)cmd3.ExecuteScalar();
                SqlCommand cmd4 = new SqlCommand("select SUM([D]) from users", con);
                int D = (int)cmd4.ExecuteScalar();
                SqlCommand cmd5 = new SqlCommand("select SUM([E]) from users", con);
                int E = (int)cmd5.ExecuteScalar();
                int all = A + B + C + D + E;
                Label9.Text = all.ToString();

                double mom = (double)A / (double)all;
                double gg = (double)B / (double)all;
                double vv = (double)C / (double)all;
                double ww = (double)D / (double)all;
                double acc = (double)E / (double)all;

                mom = Math.Round(mom, 2);
                gg = Math.Round(gg, 2);
                vv = Math.Round(vv, 2);
                ww = Math.Round(ww, 2);
                acc = Math.Round(acc, 2);
                Label4.Text = (mom * 100).ToString() + "  %";
                //Label4.Text += $"<input type=\"range\" id=\"vol\" name=\"vol\" min=\"0\" max=\"100\" value=\"{(double)mom}\">";
                Label5.Text = (gg * 100).ToString() + "  %";
                Label6.Text = (vv * 100).ToString() + "  %";
                Label7.Text = (ww * 100).ToString() + "   %";
                Label8.Text = (acc * 100).ToString() + "   %";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source= DESKTOP-HIMQ0KV\\SQLEXPRESS; Database=authentication; integrated security = true");
            con.Open();

            if (Request.Cookies["name"] == null)
            {
                Response.Cookies["name"].Value = "user";

                try
                {
                    if (RadioButtonList1.SelectedValue == "1")
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO users " + "(A,B,C,D,E) Values('1','0','0','0','0')", con);
                        command.ExecuteNonQuery();

                    }
                    else if (RadioButtonList1.SelectedValue == "2")
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO users " + "(A,B,C,D,E) Values('0','1','0','0','0')", con);
                        command.ExecuteNonQuery();
                    }
                    if (RadioButtonList1.SelectedValue == "3")
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO users " + "(A,B,C,D,E) Values('0','0','1','0','0')", con);
                        command.ExecuteNonQuery();
                    }
                    if (RadioButtonList1.SelectedValue == "4")
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO users " + "(A,B,C,D,E) Values('0','0','0','1','0')", con);
                        command.ExecuteNonQuery();
                    }
                    if (RadioButtonList1.SelectedValue == "5")
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO users " + "(A,B,C,D,E) Values('0','0','0','0','1')", con);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception a)
                {
                    //Label4.Text = "Some Thing wrong " + a.Message;
                }


            }


        }

    }
}