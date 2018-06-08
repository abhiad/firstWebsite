using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Purchase : System.Web.UI.Page
{
    MyCon c = new MyCon();
    InsertClass ins = new InsertClass();
    SqlConnection con = null;
    String str = string.Empty;
    SqlCommand cmd = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        String str = ConfigurationManager.ConnectionStrings["StockDBConnectionString"].ConnectionString;
        con = new SqlConnection(str);
        str = "select isNull(max(ID),1000) + 1 from ItemTransaction";
        cmd = new SqlCommand(str, con);
        if (con.State != ConnectionState.Open)
        {
            con.Open();
        }

        lblPno.Text = "Purch" + cmd.ExecuteScalar().ToString();
        lblDate.Text = System.DateTime.Now.Date.ToString();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string ds1 = c.MyExecuteScalar("Select BalanceQty From ItemTable where  ItemName  ='" + DropDownList2.SelectedItem.Text + "' ").ToString();
        if (ds1 != "")
        {
            lbl_BQty.Text = ds1;
        }


        int a;
        int b;
        a = Convert.ToInt16(txtQty.Text);
        b = Convert.ToInt16(lbl_BQty.Text);
        int d=(a)+(b);
        Label7.Text = d.ToString();
       

        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["StockDBConnectionString"].ConnectionString);
        String UPDATESQL;
        UPDATESQL = "UPDATE ItemTable SET [BalanceQty]=@BalanceQty WHERE [ItemName]='" + DropDownList2.SelectedItem.Text + "'";
        SqlCommand cmd = new SqlCommand(UPDATESQL, conn1);
        cmd.Parameters.AddWithValue("@BalanceQty", Label7.Text);


        //  int add = 0;
        try
        {
            conn1.Open();
            cmd.ExecuteNonQuery();
            //Label1.Text = add.ToString() + "Record updated";
            Response.Write("<script>alert('Records Updated')</script>");
        }
        catch (Exception err)
        {
            //Response.Write(err.StackTrace);
        }
        finally
        {
            conn1.Close();

        }

        //

        //
    }
}