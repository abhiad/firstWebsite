using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ItemTransaction : System.Web.UI.Page
{
    SqlConnection con = null;
    String str = string.Empty;
    SqlCommand cmd = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        String str = ConfigurationManager.ConnectionStrings["StockDBConnectionString"].ConnectionString;
        con = new SqlConnection(str);
        str = "select isNull(max(ID),1000) + 1 from ItemTransaction";
        cmd = new SqlCommand(str,con);
        if (con.State != ConnectionState.Open)
        {
            con.Open();
        }

        lblpurchno.Text = "P" + cmd.ExecuteScalar().ToString();
        Label5.Text = System.DateTime.Now.Date.ToString();

    }
    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddl.SelectedItem.Text == "Purchase")
        {
            LblIssueNo.Visible = false;
            lblpurchno.Visible = true;
            DropDownList1.Visible = true;
            DropDownList2.Visible = false;

        }
        if (ddl.SelectedItem.Text == "Issue")
        {
            LblIssueNo.Visible = true;
            lblpurchno.Visible = false;
            DropDownList1.Visible = false;
            DropDownList2.Visible = true;
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {





        String anu = ConfigurationManager.ConnectionStrings["StockDBConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(anu);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_Insert_transaction";
        cmd.Parameters.Add("@ItemID",SqlDbType.Int).Value=DropDownList3.SelectedItem.Value;
        cmd.Parameters.Add("@VendorID", SqlDbType.Int).Value = DropDownList1.SelectedItem.Value;
        cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = DropDownList2.SelectedItem.Value;
        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = txtQty.Text.Trim();
        cmd.Parameters.Add("@Mode", SqlDbType.VarChar).Value = ddl.SelectedItem.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Label6.Text="Data Saved";
        }
        catch(Exception ex)
        {
        throw ex;
                    }
        finally
        {
        con.Close();
        con.Dispose();

        }
        Response.Redirect("ItemTransaction.aspx");
    }
}