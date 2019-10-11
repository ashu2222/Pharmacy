using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pharma
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();//Add data to the sql database
                string insertQuery = "insert into SignUp(Username, Password, Confirm Password)values (@Username,@Password,@Confirm Password)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Confirm Password", TextBox3.Text);

                cmd.ExecuteNonQuery();

                Response.Write("Student registeration Successfully!!!thank you");

                conn.Close();

            }//catch errors
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
            Label1.Text = "Valid Captcha";
            Response.Redirect("LogIn.aspx");
        }
    }

 }
