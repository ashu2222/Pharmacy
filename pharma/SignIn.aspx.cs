using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pharma
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database2ConnectionString"].ConnectionString);
            conn.Open();
            string userid = username.Text;
            string password1 = password.Text;
            SqlCommand cmd = new SqlCommand("select Username,Password from SignUpTable where Username='" + username.Text + "'and Password='" + password.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                Response.Redirect("Home1.aspx");
            }
            else
            {
                Response.Write("INVALID LOGIN PASSWORD");

            }
            conn.Close();


        }
    }
}