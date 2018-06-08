using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class VendorMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        String anu = ConfigurationManager.ConnectionStrings["StockDBConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(anu);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "SP_Insert_Vendor";
        cmd.Parameters.Add("@VendorName", SqlDbType.VarChar).Value = txtName.Text.Trim();
        cmd.Connection = con;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Data Saved Succesfully";
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
        Response.Redirect("VendorMaster.aspx");
    }
}