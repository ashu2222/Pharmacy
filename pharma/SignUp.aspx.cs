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
            bool isHuman = CaptchaBox.Validate(TxtCaptcha.Text);
            TxtCaptcha.Text = null;
            if (!isHuman)
            {
                Label1.Text = "Invalid Captacha";
            }
            else
            {



                try
                {

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database2ConnectionString"].ConnectionString);
                    conn.Open();//Add data to the sql database
                    string insertQuery = "insert into SignUpTable(Username, Password, ConfirmPassword)values (@Username,@Password,@ConfirmPassword)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@Username", Username.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", ConfirmPassword.Text);

                    cmd.ExecuteNonQuery();

                    Response.Write("Student registeration Successfully!!!thank you");

                    conn.Close();

                }//catch errors
                catch (Exception ex)
                {
                    Response.Write("error" + ex.ToString());
                }

                Response.Redirect("SignIn.aspx");

            }
        }

    }
}