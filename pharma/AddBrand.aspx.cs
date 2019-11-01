using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace pharma
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        string DBConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConn = ConfigurationManager.ConnectionStrings["Database2ConnectionString"].ConnectionString;

        }

        int Insertcategory()
        {
            using (SqlConnection myConnection = new SqlConnection(DBConn))
            {
                SqlCommand MyCommand = new SqlCommand("INSERT INTO BrandTable (BrandId,BrandName) Values (@BrandId,@BrandName)", myConnection);
                MyCommand.Parameters.AddWithValue("@BrandId", BrandId.Text);
                MyCommand.Parameters.AddWithValue("@BrandName", BrandName.Text);
                myConnection.Open();
                return MyCommand.ExecuteNonQuery();

            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {

            Insertcategory();
            Response.Redirect("AddBrand.aspx");
        }
    }
}