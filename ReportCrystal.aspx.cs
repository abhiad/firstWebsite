using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class ReportCrystal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportDocument rptDoc = new ReportDocument();
        DataSet_Transaction ds = new DataSet_Transaction(); // .xsd file name
        DataTable dt = new DataTable();

        // Just set the name of data table
        dt.TableName = "Crystal Report Example";
        dt = getAllOrders(); //This function is located below this function
        ds.Tables[0].Merge(dt);

        // Your .rpt file path will be below
        rptDoc.Load(Server.MapPath("../CrystalReport.rpt"));

        //set dataset to the report viewer.
        rptDoc.SetDataSource(ds);
        CrystalReportViewer1.ReportSource = rptDoc;
    }
    public DataTable getAllOrders()
    {
        //Connection string replace 'databaseservername' with your db server name
        string sqlCon = "User ID=sa;PWD=123; server=SAAAR-PC;INITIAL CATALOG=StockDB;" +
                            "PERSISTSECURITY INFO=FALSE;Connect Timeout=0";
        SqlConnection Con = new SqlConnection(sqlCon);
        SqlCommand cmd = new SqlCommand();
        DataSet ds = null;
        SqlDataAdapter adapter;
        try
        {
            Con.Open();
            //Stored procedure calling. It is already in sample db.
            cmd.CommandText = "getAllOrders";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Con;
            ds = new DataSet();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Users");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            cmd.Dispose();
            if (Con.State != ConnectionState.Closed)
                Con.Close();
        }
        return ds.Tables[0];
    }
}