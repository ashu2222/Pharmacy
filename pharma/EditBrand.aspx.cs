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
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }






        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database2ConnectionString"].ConnectionString);
                conn.Open();//Add data to the sql database
                string deleteQuery = "delete from BrandTable where BrandId='" + this.TextBox1.Text + "';";
                SqlDataAdapter SDA = new SqlDataAdapter(deleteQuery, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                Response.Write("Successfully deleted !!!thank you");

                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database2ConnectionString"].ConnectionString);
                conn.Open();

                string updateQuery = "update BrandTable set BrandId= '" + this.TextBox1.Text + "', BrandName = '" + this.TextBox2.Text + "'where BrandId = '" + this.TextBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(updateQuery, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                Response.Write("Update Successfully  !!!thank you");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }
    }
}