using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Data.SqlClient;


public class MyCon
{
   SqlConnection con;
    String Constr;
    SqlCommand cmd1;
     SqlDataReader dr;
    SqlDataAdapter sda;
   

    public String   RetCon()
    {

        return (ConfigurationManager.ConnectionStrings["StockDBConnectionString"].ConnectionString);
    }

    public  SqlConnection OpenMyCon()
    {
        con =new SqlConnection (RetCon());


        if (con.State == ConnectionState.Open)
        {
            con.Close();
            con.Open();
        }
        else
        {
            con.Open();
        }
        return con;
    }
    public int MyExecuteNonQuery(String query)
    {

        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = query;
        cmd1.Connection = OpenMyCon();
        i = cmd1.ExecuteNonQuery();
        return i;
    }
    public DataSet MyExecuteReader(String query)
    {
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.Connection = OpenMyCon();
        cmd1.CommandText = query;
        DataSet ds = new DataSet();
        sda = new SqlDataAdapter(cmd1);
        sda.Fill(ds);
        return ds;

    }
    public object MyExecuteScalar(String query)
    {
        object i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = query;
        cmd1.Connection = OpenMyCon();
        i = cmd1.ExecuteScalar();
        return i;
    }
 public SqlConnection OpenMyCon1()
    {
        //using (con = new SqlConnection(RetCon()))
        con = new SqlConnection(RetCon());
           if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
            {
                con.Open();
            }
            return con;
        }
 }
