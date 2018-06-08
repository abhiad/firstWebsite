using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class testInsert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string anu = ConfigurationManager.ConnectionStrings["StockDBConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(anu);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_insert_test1";
        cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = txtName.Text.Trim();
        cmd.Parameters.Add("Mobile",SqlDbType.Int).Value=txtmob.Text.Trim();
        cmd.Connection = con;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            lbl1.Text = "Data Saved";

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
    }
}