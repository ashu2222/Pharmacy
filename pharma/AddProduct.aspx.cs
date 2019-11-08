using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pharma
{
    public partial class WebForm15 : System.Web.UI.Page
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
                SqlCommand MyCommand = new SqlCommand("INSERT INTO ProductTable1 (Brand,ProductName,ProductID,AvailableQuantity,SalesPrice) Values (@Brand,@ProductName,@ProductID,@AvailableQuantity,@SalesPrice)", myConnection);
                MyCommand.Parameters.AddWithValue("@Brand", DropDownList1.Text);
                MyCommand.Parameters.AddWithValue("@ProductName", TextBox1.Text);
                MyCommand.Parameters.AddWithValue("@ProductID", TextBox2.Text);
                MyCommand.Parameters.AddWithValue("@AvailableQuantity", TextBox3.Text);
                MyCommand.Parameters.AddWithValue("@SalesPrice", TextBox4.Text);

                myConnection.Open();
                return MyCommand.ExecuteNonQuery();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Insertcategory();
            Response.Redirect("AddProduct.aspx");
        }
    }
}