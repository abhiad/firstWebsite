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

/// <summary>
/// Summary description for logic
/// </summary>
public class logic
{
    MyCon c = new MyCon();
	public logic()
	{
		
	}
    public object max_id(String tbl_name)
    {
        object i;
        string qry = "Select max(id)+1 from " + tbl_name;
        i = c.MyExecuteScalar(qry);
        return (i);
    }
  
}
