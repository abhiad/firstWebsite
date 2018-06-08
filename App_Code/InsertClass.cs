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
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;


/// <summary>
/// Summary description for InsertClass
/// </summary>
public class InsertClass
{
    SqlCommand cmd1, cmd2, cmd3;
    //SqlDataReader dr1, dr2, dr3;
    MyCon c = new MyCon();
    
	public InsertClass()
	{
		
	}
    //Insert Class for Product master
    public int Insert_product(DateTime  p_date, String p_compy, String p_type, String p_name, String amount, String remark, String status)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_ProductMaster";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@p_date", p_date);
        cmd1.Parameters.AddWithValue("@p_compy", p_compy);
        cmd1.Parameters.AddWithValue("@p_type", p_type);
        cmd1.Parameters.AddWithValue("@p_name", p_name);
        cmd1.Parameters.AddWithValue("@amount", amount);
        cmd1.Parameters.AddWithValue("@remark", remark);
        cmd1.Parameters.AddWithValue("@status", status);
        i= cmd1.ExecuteNonQuery();
        return i;
      }

    public int Insert_shipper(String name, String code, String address, String country, String state, String city, String contct_person, String contct_person_no, String tin_no, String email, String pin, String fax, String website, String remark)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_ShipperMaster";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@name", name);
        cmd1.Parameters.AddWithValue("@code", code);
        cmd1.Parameters.AddWithValue("@address", address);
        cmd1.Parameters.AddWithValue("@country", country);
        cmd1.Parameters.AddWithValue("@state", state);
        cmd1.Parameters.AddWithValue("@city", city);
        cmd1.Parameters.AddWithValue("@contct_person", contct_person);
        cmd1.Parameters.AddWithValue("@contct_person_no", contct_person_no);
        cmd1.Parameters.AddWithValue("@tin_no", tin_no);
        cmd1.Parameters.AddWithValue("@email", email);
        cmd1.Parameters.AddWithValue("@pin", pin);
        cmd1.Parameters.AddWithValue("@fax", fax);
        cmd1.Parameters.AddWithValue("@website", website);
        cmd1.Parameters.AddWithValue("@remark", remark);
        i = cmd1.ExecuteNonQuery();
        return i;


    }
    public int Insert_buyer(String name, String code, String address, String country, String state, String city, String contct_person, String contct_person_no, String tin_no, String email, String pin, String fax, String website, String remark)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_BuyersMaster";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@name", name);
        cmd1.Parameters.AddWithValue("@code", code);
        cmd1.Parameters.AddWithValue("@address", address);
        cmd1.Parameters.AddWithValue("@country", country);
        cmd1.Parameters.AddWithValue("@state", state);
        cmd1.Parameters.AddWithValue("@city", city);
        cmd1.Parameters.AddWithValue("@contct_person", contct_person);
        cmd1.Parameters.AddWithValue("@contct_person_no", contct_person_no);
        cmd1.Parameters.AddWithValue("@tin_no", tin_no);
        cmd1.Parameters.AddWithValue("@email", email);
        cmd1.Parameters.AddWithValue("@pin", pin);
        cmd1.Parameters.AddWithValue("@fax", fax);
        cmd1.Parameters.AddWithValue("@website", website);
        cmd1.Parameters.AddWithValue("@remark", remark);
        i = cmd1.ExecuteNonQuery();
        return i;


    }
    public int Insert_plannig(String sno, String datee, String shipper, String mawb_no, String hawb_no, String pkt, String weight, String flt_no,
                               String igm, String be_no, String cnee, String ref1, String pcs, String pcs_weight, String app_duty,
                               String c_duty, String val, String f_duty, String shiping_by, String cd_pcs, String frieght, String status,
                               String mode, String duty_status, String print_status, String p_date)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure; 
        cmd1.CommandText = "sp_Insert_Planning_entry";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@sno", sno);
        cmd1.Parameters.AddWithValue("@datee", datee);
        cmd1.Parameters.AddWithValue("@shipper", shipper);
        cmd1.Parameters.AddWithValue("@mawb_no", mawb_no);
        cmd1.Parameters.AddWithValue("@hawb_no", hawb_no);
        cmd1.Parameters.AddWithValue("@pkt", pkt);
        cmd1.Parameters.AddWithValue("@weight", weight);
        cmd1.Parameters.AddWithValue("@flt_no", flt_no);
        cmd1.Parameters.AddWithValue("@igm", igm);
        cmd1.Parameters.AddWithValue("@be_no", be_no);
        cmd1.Parameters.AddWithValue("@cnee", cnee);
        cmd1.Parameters.AddWithValue("@ref", ref1);
        cmd1.Parameters.AddWithValue("@pcs", pcs);
        cmd1.Parameters.AddWithValue("@pcs_weight", pcs_weight);
        cmd1.Parameters.AddWithValue("@app_duty", app_duty);
        cmd1.Parameters.AddWithValue("@c_duty", c_duty);
        cmd1.Parameters.AddWithValue("@val", val);
        cmd1.Parameters.AddWithValue("@f_duty", f_duty);
        cmd1.Parameters.AddWithValue("@shiping_by", shiping_by);
        cmd1.Parameters.AddWithValue("@cd_pcs", cd_pcs);
        cmd1.Parameters.AddWithValue("@frieght", frieght);
        cmd1.Parameters.AddWithValue("@status", status);
        cmd1.Parameters.AddWithValue("@mode", mode);
        cmd1.Parameters.AddWithValue("@duty_status", duty_status);
        cmd1.Parameters.AddWithValue("@print_status", print_status);
        cmd1.Parameters.AddWithValue("@p_date", p_date);
        i = cmd1.ExecuteNonQuery();
        return i;


    }
     public int Insert_vProductMaster(String comp_name, String type, String prod_name, String cprice, String sprice, String revenue, String plan, String remark)
      {
          Int32 i;
          cmd1 = new SqlCommand();
          cmd1.CommandType = CommandType.StoredProcedure;
          cmd1.CommandText = "sp_Insert_vProductrMaster";
          cmd1.Connection = c.OpenMyCon();
          cmd1.Parameters.AddWithValue("@comp_name", comp_name);
          cmd1.Parameters.AddWithValue("@type", type);
          cmd1.Parameters.AddWithValue("@prod_name", prod_name);
          cmd1.Parameters.AddWithValue("@cprice", cprice);
          cmd1.Parameters.AddWithValue("@sprice", sprice);
          cmd1.Parameters.AddWithValue("@revenue", revenue);
          cmd1.Parameters.AddWithValue("@plan", plan);
          cmd1.Parameters.AddWithValue("@remark", remark);
          i = cmd1.ExecuteNonQuery();
          return i;

      }
    public int Insert_prermission(String formid, String form_name)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_permission";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@formid", formid);
        cmd1.Parameters.AddWithValue("@form_name", form_name);
        i = cmd1.ExecuteNonQuery();
        return i;

    }
    public int Insert_createuser(String user_name, String password, string user_role, Int32 vid)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_createuser";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@user_name", user_name);
        cmd1.Parameters.AddWithValue("@password", password);
        cmd1.Parameters.AddWithValue("@user_role", user_role);
        cmd1.Parameters.AddWithValue("@vid", vid);
        i = cmd1.ExecuteNonQuery();
        return i;
            }
    public int Insert_consignee(String name, String code, String address, String country, String state, String city, String contct_person, String contct_person_no, String tin_no, String email, String pin, String fax, String website, String remark)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_ConsigneeMaster";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@name", name);
        cmd1.Parameters.AddWithValue("@code", code);
        cmd1.Parameters.AddWithValue("@address", address);
        cmd1.Parameters.AddWithValue("@country", country);
        cmd1.Parameters.AddWithValue("@state", state);
        cmd1.Parameters.AddWithValue("@city", city);
        cmd1.Parameters.AddWithValue("@contct_person", contct_person);
        cmd1.Parameters.AddWithValue("@contct_person_no", contct_person_no);
        cmd1.Parameters.AddWithValue("@tin_no", tin_no);
        cmd1.Parameters.AddWithValue("@email", email);
        cmd1.Parameters.AddWithValue("@pin", pin);
        cmd1.Parameters.AddWithValue("@fax", fax);
        cmd1.Parameters.AddWithValue("@website", website);
        cmd1.Parameters.AddWithValue("@remark", remark);
        i = cmd1.ExecuteNonQuery();
        return i;
            }
    public int Insert_EmployeeMaster(String name, String surname, String fname, String mname, String dob, String gender, String marital, String email,
                               String address, String country, String state, String city, String mobile, String phone, String other_mobile,
                               String e_mobile, String pan, String remark, String grad, String grad_inst, String post_grad, String pg_inst,
        String other_edu, String other_edu_inst, String vertical,  String designation, String joining_dt,
       String basic_sal, String report_to, String location, String for_company, String emp_status, String acc_no, String pf_no, double pf_percent, Int32 leave_allow)
       //String basic_sal, String report_to, String location, String for_company,byte[] emp_photo,String emp_status,String acc_no,String pf_no,double pf_percent,Int32 leave_allow)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_EmployeeMaster";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@name", name);
        cmd1.Parameters.AddWithValue("@surname", surname);
        cmd1.Parameters.AddWithValue("@fname", fname);
        cmd1.Parameters.AddWithValue("@mname", mname);
        cmd1.Parameters.AddWithValue("@dob", dob);
        cmd1.Parameters.AddWithValue("@gender", gender);
        cmd1.Parameters.AddWithValue("@marital", marital);
        cmd1.Parameters.AddWithValue("@email", email);
        cmd1.Parameters.AddWithValue("@address", address);
        cmd1.Parameters.AddWithValue("@country", country);
        cmd1.Parameters.AddWithValue("@state", state);
        cmd1.Parameters.AddWithValue("@city", city);
        cmd1.Parameters.AddWithValue("@mobile", mobile);
        cmd1.Parameters.AddWithValue("@phone", phone);
        cmd1.Parameters.AddWithValue("@other_mobile", other_mobile);
        cmd1.Parameters.AddWithValue("@e_mobile", e_mobile);
        cmd1.Parameters.AddWithValue("@pan", pan);
        cmd1.Parameters.AddWithValue("@remark", remark);
        cmd1.Parameters.AddWithValue("@grad", grad);
        cmd1.Parameters.AddWithValue("@grad_inst", grad_inst);
        cmd1.Parameters.AddWithValue("@post_grad", post_grad);
        cmd1.Parameters.AddWithValue("@pg_inst", pg_inst);
        cmd1.Parameters.AddWithValue("@other_edu", other_edu); 
        cmd1.Parameters.AddWithValue("@other_edu_inst", other_edu_inst);
        cmd1.Parameters.AddWithValue("@designation", designation);
        cmd1.Parameters.AddWithValue("@joining_dt", joining_dt);
        //cmd1.Parameters.AddWithValue("@confirm_dt", confirm_dt)
        cmd1.Parameters.AddWithValue("@vertical", vertical);
       // cmd1.Parameters.AddWithValue("@resign_date", resign_date);
        cmd1.Parameters.AddWithValue("@basic_sal", basic_sal);
        cmd1.Parameters.AddWithValue("@report_to", report_to);
        cmd1.Parameters.AddWithValue("@location", location);
        cmd1.Parameters.AddWithValue("@for_company", for_company);
       // cmd1.Parameters.AddWithValue("@emp_photo", emp_photo);
        cmd1.Parameters.AddWithValue("@emp_status", emp_status);
        cmd1.Parameters.AddWithValue("@acc_no", acc_no);
        cmd1.Parameters.AddWithValue("@pf_no", pf_no);
        cmd1.Parameters.AddWithValue("@pf_percent", pf_percent);
        cmd1.Parameters.AddWithValue("@leave_allow", leave_allow);
        i = cmd1.ExecuteNonQuery();
        return i;
        
    }
    public int Insert_DocumentDetails(Int32 Emp_id, String doc_type, String doc_no, String doc)
        
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_EmployeeDoc";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@Emp_id", Emp_id);
        cmd1.Parameters.AddWithValue("@doc_type", doc_type);
        cmd1.Parameters.AddWithValue("@doc_no", doc_no);
        cmd1.Parameters.AddWithValue("@doc", doc);
        cmd1.Parameters.AddWithValue("@flag", '1');
        i = cmd1.ExecuteNonQuery();
        return i;

    }
       public int Insert_Vertical(String company_name, String vertical_name, String vertical_code, String b2b,String b2c, String remarks, String zone)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_VerticalMaster";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@company_name", company_name);
        cmd1.Parameters.AddWithValue("@vertical_name", vertical_name);
        cmd1.Parameters.AddWithValue("@vertical_code", vertical_code);
        cmd1.Parameters.AddWithValue("@b2b", b2b);
        cmd1.Parameters.AddWithValue("@b2c", b2c);
        cmd1.Parameters.AddWithValue("@remarks", remarks);
        cmd1.Parameters.AddWithValue("@zone",zone);
        i = cmd1.ExecuteNonQuery();
        return i;

    }
       public int Insert_EmployeeTarget(int month, int vid, String yr)
      {
          Int32 i;
          cmd1 = new SqlCommand();
          cmd1.CommandType = CommandType.StoredProcedure;
          cmd1.CommandText = "sp_Insert_vEmployeeTarget";
          cmd1.Connection = c.OpenMyCon();
          cmd1.Parameters.AddWithValue("@month", month);
          cmd1.Parameters.AddWithValue("@vid", vid);
          cmd1.Parameters.AddWithValue("@yr", yr);
          i = cmd1.ExecuteNonQuery();
          return i;

      }
     public int Insert_EmployeeTarget_details(int tid, int emp_id, double target_amt)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_vEmp_Target_dtls";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@tid", tid);
         cmd1.Parameters.AddWithValue("@emp_id", emp_id);
         cmd1.Parameters.AddWithValue("@target_amt", target_amt);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Delete_DocumentDetails(Int32 Emp_id)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Delete_EmployeeDoc";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@Emp_id", Emp_id);

         i = cmd1.ExecuteNonQuery();
         return i;

     }
     public int Delete_EmployeeMaster(String emp_id)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Delete_EmployeeMaster";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@emp_id", emp_id);
       
        i = cmd1.ExecuteNonQuery();
        return i;

    }
public int Update_EmployeeMaster(String emp_id, String name, String surname, String fname, String mname, String dob, String gender, String marital, String email,
                              String address, String country, String state, String city, String mobile, String phone, String other_mobile,
                              String e_mobile, String pan, String remark, String grad, String grad_inst, String post_grad, String pg_inst,
       String other_edu, String other_edu_inst, String vertical, String designation, String joining_dt,
       String basic_sal, String report_to, String location, String for_company,  String emp_status, String acc_no, String pf_no, double pf_percent, Int32 leave_allow)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Update_EmployeeMaster";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@emp_id", emp_id);
        cmd1.Parameters.AddWithValue("@name", name);
        cmd1.Parameters.AddWithValue("@surname", surname);
        cmd1.Parameters.AddWithValue("@fname", fname);
        cmd1.Parameters.AddWithValue("@mname", mname);
        cmd1.Parameters.AddWithValue("@dob", dob);
        cmd1.Parameters.AddWithValue("@gender", gender);
        cmd1.Parameters.AddWithValue("@marital", marital);
        cmd1.Parameters.AddWithValue("@email", email);
        cmd1.Parameters.AddWithValue("@address", address);
        cmd1.Parameters.AddWithValue("@country", country);
        cmd1.Parameters.AddWithValue("@state", state);
        cmd1.Parameters.AddWithValue("@city", city);
        cmd1.Parameters.AddWithValue("@mobile", mobile);
        cmd1.Parameters.AddWithValue("@phone", phone);
        cmd1.Parameters.AddWithValue("@other_mobile", other_mobile);
        cmd1.Parameters.AddWithValue("@e_mobile", e_mobile);
        cmd1.Parameters.AddWithValue("@pan", pan);
        cmd1.Parameters.AddWithValue("@remark", remark);
        cmd1.Parameters.AddWithValue("@grad", grad);
        cmd1.Parameters.AddWithValue("@grad_inst", grad_inst);
        cmd1.Parameters.AddWithValue("@post_grad", post_grad);
        cmd1.Parameters.AddWithValue("@pg_inst", pg_inst);
        cmd1.Parameters.AddWithValue("@other_edu", other_edu);
        cmd1.Parameters.AddWithValue("@other_edu_inst", other_edu_inst);
        cmd1.Parameters.AddWithValue("@designation", designation);
        cmd1.Parameters.AddWithValue("@joining_dt", joining_dt);
        //cmd1.Parameters.AddWithValue("@confirm_dt", confirm_dt)
        cmd1.Parameters.AddWithValue("@vertical", vertical);
        // cmd1.Parameters.AddWithValue("@resign_date", resign_date);
        cmd1.Parameters.AddWithValue("@basic_sal", basic_sal);
        cmd1.Parameters.AddWithValue("@report_to", report_to);
        cmd1.Parameters.AddWithValue("@location", location);
        cmd1.Parameters.AddWithValue("@for_company", for_company);
       // cmd1.Parameters.AddWithValue("@emp_photo", emp_photo);
        cmd1.Parameters.AddWithValue("@emp_status", emp_status);
        cmd1.Parameters.AddWithValue("@acc_no", acc_no);
        cmd1.Parameters.AddWithValue("@pf_no", pf_no);
        cmd1.Parameters.AddWithValue("@pf_percent", pf_percent);
        cmd1.Parameters.AddWithValue("@leave_allow", leave_allow);
        i = cmd1.ExecuteNonQuery();
        return i;

    }
    //public int Insert_assests_entry(String entry_no, String todays_date, string assets_type, string name, string company, string model, string emi_no, string price_mobile, string qty_mob, string headphone, string charger, string other, string datacard, string reg_no, string price_car, string qty_car)
    //{
    //    Int32 i;
    //    cmd1 = new SqlCommand();
    //    cmd1.CommandType = CommandType.StoredProcedure;
    //    cmd1.CommandText = "sp_Insert_assestsEntry";
    //    cmd1.Connection = c.OpenMyCon();
    //    cmd1.Parameters.AddWithValue("@entry_no", entry_no);
    //    cmd1.Parameters.AddWithValue("@todays_date", todays_date);
    //    cmd1.Parameters.AddWithValue("@assets_type", assets_type);
    //    cmd1.Parameters.AddWithValue("@name", name);
    //    cmd1.Parameters.AddWithValue("@company", company);
    //    cmd1.Parameters.AddWithValue("@model", model);
    //    cmd1.Parameters.AddWithValue("@emi_no", emi_no);
    //    cmd1.Parameters.AddWithValue("@price_mobile", price_mobile);
    //    cmd1.Parameters.AddWithValue("@qty_mob", qty_mob);
    //    cmd1.Parameters.AddWithValue("@headphone", headphone);
    //    cmd1.Parameters.AddWithValue("@charger", charger);
    //    cmd1.Parameters.AddWithValue("@other", other);
    //    cmd1.Parameters.AddWithValue("@datacard", datacard);
    //    cmd1.Parameters.AddWithValue("@reg_no", reg_no);
    //    cmd1.Parameters.AddWithValue("@price_car", price_car);
    //    cmd1.Parameters.AddWithValue("@qty_car", qty_car);
    //    i = cmd1.ExecuteNonQuery();
    //    return i;
    //}


    //public int Insert_Customer_Master(String cust_name, String cust_id, String cont_prs_name, String house_no, String landmark, String location, String country, String state, String city, String pin, String phone, String mobile, String kit_no, String name_seller, String branch, String TL_name, String package, String incentive, String amount, String amt_received, String discount, String mode_payment, String amt_recv_by, String account_status, String emp_name, String company, String amt_deduct, String cheque_no, String bank_name, string bank_address, string remark)
    //{
    //    Int32 i;
    //    cmd1 = new SqlCommand();
    //    cmd1.CommandType = CommandType.StoredProcedure;
    //    cmd1.CommandText = "sp_Insert_CustomerMaster";
    //    cmd1.Connection = c.OpenMyCon();
    //    cmd1.Parameters.AddWithValue("@cust_name ", cust_name);
    //    cmd1.Parameters.AddWithValue("@cust_id ", cust_id);
    //    cmd1.Parameters.AddWithValue("@cont_prs_name ", cont_prs_name);
    //    cmd1.Parameters.AddWithValue("@house_no ", house_no);
    //    cmd1.Parameters.AddWithValue("@landmark ", landmark);
    //    cmd1.Parameters.AddWithValue("@location ", location);
    //    cmd1.Parameters.AddWithValue("@country ", country);
    //    cmd1.Parameters.AddWithValue("@state ", state);
    //    cmd1.Parameters.AddWithValue("@city  ", city);
    //    cmd1.Parameters.AddWithValue("@pin ", pin);
    //    cmd1.Parameters.AddWithValue("@phone ", phone);
    //    cmd1.Parameters.AddWithValue("@mobile  ", mobile);
    //    cmd1.Parameters.AddWithValue("@kit_no  ", kit_no);
    //    cmd1.Parameters.AddWithValue("@name_seller  ", name_seller);
    //    cmd1.Parameters.AddWithValue("@branch  ", branch);
    //    cmd1.Parameters.AddWithValue("@TL_name  ", TL_name);
    //    cmd1.Parameters.AddWithValue("@package   ", package);
    //    cmd1.Parameters.AddWithValue("@incentive   ", incentive);
    //    cmd1.Parameters.AddWithValue("@amount   ", amount);
    //    cmd1.Parameters.AddWithValue("@amt_received   ", amt_received);
    //    cmd1.Parameters.AddWithValue("@discount   ", discount);
    //    cmd1.Parameters.AddWithValue("@mode_payment   ", mode_payment);
    //    cmd1.Parameters.AddWithValue("@amt_recv_by   ", amt_recv_by);
    //    cmd1.Parameters.AddWithValue("@account_status  ", account_status);
    //    cmd1.Parameters.AddWithValue("@emp_name  ", emp_name);
    //    cmd1.Parameters.AddWithValue("@company  ", company);
    //    cmd1.Parameters.AddWithValue("@amt_deduct  ", amt_deduct);
    //    cmd1.Parameters.AddWithValue("@cheque_no  ", cheque_no);
    //    cmd1.Parameters.AddWithValue("@bank_name  ", bank_name);
    //    cmd1.Parameters.AddWithValue("@bank_address  ", bank_address);
    //    cmd1.Parameters.AddWithValue("@remark  ", remark);
    //    i = cmd1.ExecuteNonQuery();
    //    return i;
    //   }

    public int Insert_assests_entry( String todays_date, string assets_type, string name, string company, string model, string emi_reg_no, string price, string status)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_assestsEntry";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@todays_date", todays_date);
        cmd1.Parameters.AddWithValue("@assets_type", assets_type);
        cmd1.Parameters.AddWithValue("@name", name);
        cmd1.Parameters.AddWithValue("@company", company);
        cmd1.Parameters.AddWithValue("@model", model);
        cmd1.Parameters.AddWithValue("@emi_reg_no", emi_reg_no);
        cmd1.Parameters.AddWithValue("@price", price);
        cmd1.Parameters.AddWithValue("@status", status);
        i = cmd1.ExecuteNonQuery();
        return i;
    }

    public int Insert_assests_Inventory(String entry_no,  String assets_type,  String qty_mob,String qty_car)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_assestsInventory";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@entry_no", entry_no);
        cmd1.Parameters.AddWithValue("@assets_type", assets_type);
        cmd1.Parameters.AddWithValue("@qty_mob", qty_mob);
        cmd1.Parameters.AddWithValue("@qty_car", qty_car);
        i = cmd1.ExecuteNonQuery();
        return i;
    }
    public int Update_qty_assests_Inventory( String assets_type, int qty_mob, int qty_car)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_assestsEntry_qtyUpdate";
        cmd1.Connection = c.OpenMyCon();
        //cmd1.Parameters.AddWithValue("@entry_no", entry_no);
        cmd1.Parameters.AddWithValue("@assets_type", assets_type);
        cmd1.Parameters.AddWithValue("@qty_mob", qty_mob);
        cmd1.Parameters.AddWithValue("@qty_car", qty_car);
        i = cmd1.ExecuteNonQuery();
        return i;
    }

    public int Insert_Material_Issue(String employee_id, String employee_name, String todays_date, String Issue_type, string company, string model, string emi_reg_no, string price, string assetsid)
    {
        Int32 i;
        cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "sp_Insert_MaterialIssue";
        cmd1.Connection = c.OpenMyCon();
        cmd1.Parameters.AddWithValue("@employee_id", employee_id);
        cmd1.Parameters.AddWithValue("@employee_name", employee_name);
        cmd1.Parameters.AddWithValue("@todays_date", todays_date);
        cmd1.Parameters.AddWithValue("@Issue_type", Issue_type);
        cmd1.Parameters.AddWithValue("@company", company);
        cmd1.Parameters.AddWithValue("@model", model);
        cmd1.Parameters.AddWithValue("@emi_reg_no", emi_reg_no);
        cmd1.Parameters.AddWithValue("@price", price);
        cmd1.Parameters.AddWithValue("@assetsid", assetsid);
       
        i = cmd1.ExecuteNonQuery();
        return i;
    }

      public int Insert_Customer_Master(String today_date, String cust_id, String cust_name, String cont_prs_name, String house_no, String landmark, String location, String country, String state, String city, String pin, String phone, String mobile, String mobile2, String remark, String kit_no, String package, String amount, String name_seller, String TL_name, String branch, String incentive, String mode_payment, String amt_recv_by, String amt_received, String discount, String account_status, String bank_name, String acc_no, String deposit_dt, String emp_name, String company, String amt_deduct, String cheque_no, String bank_name2, String chq_dt1, String dd_no, String infavourof, String chq_dt2, String serial_no, String sales_status, String lapu_amt)
      {
          Int32 i;
          cmd1 = new SqlCommand();
          cmd1.CommandType = CommandType.StoredProcedure;
          cmd1.CommandText = "sp_Insert_CustomerMaster";
          cmd1.Connection = c.OpenMyCon();
          cmd1.Parameters.AddWithValue("@today_date ", today_date);
          cmd1.Parameters.AddWithValue("@cust_id ", cust_id);
          cmd1.Parameters.AddWithValue("@cust_name ", cust_name);
          cmd1.Parameters.AddWithValue("@cont_prs_name ", cont_prs_name);
          cmd1.Parameters.AddWithValue("@house_no ", house_no);
          cmd1.Parameters.AddWithValue("@landmark ", landmark);
          cmd1.Parameters.AddWithValue("@location ", location);
          cmd1.Parameters.AddWithValue("@country ", country);
          cmd1.Parameters.AddWithValue("@state ", state);
          cmd1.Parameters.AddWithValue("@city  ", city);
          cmd1.Parameters.AddWithValue("@pin ", pin);
          cmd1.Parameters.AddWithValue("@phone ", phone);
          cmd1.Parameters.AddWithValue("@mobile  ", mobile);
          cmd1.Parameters.AddWithValue("@mobile2  ", mobile2);
          cmd1.Parameters.AddWithValue("@remark  ", remark);
          cmd1.Parameters.AddWithValue("@kit_no  ", kit_no);
          cmd1.Parameters.AddWithValue("@package   ", package);
          cmd1.Parameters.AddWithValue("@amount   ", amount);
          cmd1.Parameters.AddWithValue("@name_seller  ", name_seller);
          cmd1.Parameters.AddWithValue("@TL_name  ", TL_name);
          cmd1.Parameters.AddWithValue("@branch  ", branch);
          cmd1.Parameters.AddWithValue("@incentive   ", incentive);
          cmd1.Parameters.AddWithValue("@mode_payment   ", mode_payment);
          cmd1.Parameters.AddWithValue("@amt_recv_by   ", amt_recv_by);
          cmd1.Parameters.AddWithValue("@amt_received   ", amt_received);
          cmd1.Parameters.AddWithValue("@discount   ", discount);
          cmd1.Parameters.AddWithValue("@account_status  ", account_status);
          cmd1.Parameters.AddWithValue("@bank_name  ", bank_name);
          cmd1.Parameters.AddWithValue("@acc_no  ", acc_no);
          cmd1.Parameters.AddWithValue("@deposit_dt  ", deposit_dt);
          cmd1.Parameters.AddWithValue("@emp_name  ", emp_name);
          cmd1.Parameters.AddWithValue("@company  ", company);
          cmd1.Parameters.AddWithValue("@amt_deduct  ", amt_deduct);
          cmd1.Parameters.AddWithValue("@cheque_no  ", cheque_no);
          cmd1.Parameters.AddWithValue("@bank_name2  ", bank_name2);
          cmd1.Parameters.AddWithValue("@chq_dt1  ", chq_dt1);
          cmd1.Parameters.AddWithValue("@dd_no  ", dd_no);
          cmd1.Parameters.AddWithValue("@infavourof  ", infavourof);
          cmd1.Parameters.AddWithValue("@chq_dt2  ", chq_dt2);
          cmd1.Parameters.AddWithValue("@serial_no  ", serial_no);
          cmd1.Parameters.AddWithValue("@sales_status  ", sales_status);
          cmd1.Parameters.AddWithValue("@lapu_amt", lapu_amt);

          i = cmd1.ExecuteNonQuery();
          return i;


      }
     public int Insert_kit_master(String datee, String entry_no, String kitno,String status,String remark)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_kit_entry";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@datee", datee);
         cmd1.Parameters.AddWithValue("@entry_no", entry_no);
         cmd1.Parameters.AddWithValue("@kitno", kitno);
         cmd1.Parameters.AddWithValue("@status", status);
         cmd1.Parameters.AddWithValue("@remark", remark);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
      public int Update_status_ass(String Issue_type,  String emi_reg_no, String status)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Update_status_assets";
         cmd1.Connection = c.OpenMyCon();
       
         cmd1.Parameters.AddWithValue("@Issue_type", Issue_type);
         cmd1.Parameters.AddWithValue("@emi_reg_no", emi_reg_no);
         cmd1.Parameters.AddWithValue("@status", status);

         i = cmd1.ExecuteNonQuery();
         return i;
     }
      public int Insert_emp_attend_daily(String company_name, String vid, String datee, String emp_id, String today_commitment, String attendance,String in_time, String achivement, String activation_in_no, String activation_revnue, String scanning_in_no, String scanning_revnue,String revenue, String remark)
      {
          Int32 i;
          cmd1 = new SqlCommand();
          cmd1.CommandType = CommandType.StoredProcedure;
          cmd1.CommandText = "sp_Insert_emp_daily_attendance";
          cmd1.Connection = c.OpenMyCon();
          cmd1.Parameters.AddWithValue("@company_name", company_name);
          cmd1.Parameters.AddWithValue("@vid", vid);
          cmd1.Parameters.AddWithValue("@datee", datee);
          cmd1.Parameters.AddWithValue("@emp_id", emp_id);
          cmd1.Parameters.AddWithValue("@today_commitment", Convert.ToDouble(today_commitment));
          cmd1.Parameters.AddWithValue("@attendance", attendance);
          cmd1.Parameters.AddWithValue("@in_time", in_time);
          cmd1.Parameters.AddWithValue("@achivement", Convert.ToDouble(achivement));
          cmd1.Parameters.AddWithValue("@activation_in_no", Convert.ToDouble(activation_in_no));
          cmd1.Parameters.AddWithValue("@activation_revnue", Convert.ToDouble(activation_revnue));
          cmd1.Parameters.AddWithValue("@scanning_in_no ", Convert.ToDouble(scanning_in_no));
          cmd1.Parameters.AddWithValue("@scanning_revnue ", Convert.ToDouble(scanning_revnue));
          cmd1.Parameters.AddWithValue("@revenue ", Convert.ToDouble(revenue));
          cmd1.Parameters.AddWithValue("@remark ", remark);
          i = cmd1.ExecuteNonQuery();
          return i;
      }
     public int Insert_emp_designation(String desg_name, String desg_code, String remark)
      {
          Int32 i;
          cmd1 = new SqlCommand();
          cmd1.CommandType = CommandType.StoredProcedure;
          cmd1.CommandText = "sp_Insert_designation_master";
          cmd1.Connection = c.OpenMyCon();
          cmd1.Parameters.AddWithValue("@desg_name", desg_name);
          cmd1.Parameters.AddWithValue("@desg_code", desg_code);
          cmd1.Parameters.AddWithValue("@remark", remark);
         
          i = cmd1.ExecuteNonQuery();
          return i;
      }
    
     public int Insert_emp_Salary(String emp_id,String achivement, String percents, String advance, String mandays, String ac_mandays, String leave_deduction, String salary_af_leave_deduc, String deduc_non_perfor_per, String deduc_non_perfor_amt, String sal_af_perfor_deduc, String other_deduc, String pf_deduc, String net_sal, String pending,String datee,String month,String year,String vid)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_v_emp_sal";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@emp_id", emp_id);
         cmd1.Parameters.AddWithValue("@achivement", achivement);
         cmd1.Parameters.AddWithValue("@percents", percents);
         cmd1.Parameters.AddWithValue("@advance", advance);
         cmd1.Parameters.AddWithValue("@mandays", mandays);
         cmd1.Parameters.AddWithValue("@ac_mandays", ac_mandays);
         cmd1.Parameters.AddWithValue("@leave_deduction", leave_deduction);
         cmd1.Parameters.AddWithValue("@salary_af_leave_deduc", salary_af_leave_deduc);
         cmd1.Parameters.AddWithValue("@deduc_non_perfor_per", deduc_non_perfor_per);
         cmd1.Parameters.AddWithValue("@deduc_non_perfor_amt", deduc_non_perfor_amt);
         cmd1.Parameters.AddWithValue("@sal_af_perfor_deduc", sal_af_perfor_deduc);
         cmd1.Parameters.AddWithValue("@other_deduc", other_deduc);
         cmd1.Parameters.AddWithValue("@pf_deduc", pf_deduc);
         cmd1.Parameters.AddWithValue("@net_sal", net_sal);
         cmd1.Parameters.AddWithValue("@pending", pending);
         cmd1.Parameters.AddWithValue("@datee", datee);
         cmd1.Parameters.AddWithValue("@month", month);
         cmd1.Parameters.AddWithValue("@year", year);
         cmd1.Parameters.AddWithValue("@vid", vid);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Insert_vrtcle_fund_issue_master(String issue_dt, String issue_by)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_Vrtcl_fund_issue_master";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@issue_dt", issue_dt);
         cmd1.Parameters.AddWithValue("@issue_by", issue_by);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Insert_vrtcle_fund_issue_dtls(Int32 fid, String vid,String amt,String description)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_Vrtcl_fund_issue_master";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@fid", fid);
         cmd1.Parameters.AddWithValue("@vid", Convert.ToInt32(vid));
         cmd1.Parameters.AddWithValue("@amt", Convert.ToDouble(amt));
         cmd1.Parameters.AddWithValue("@description", description);
         i = cmd1.ExecuteNonQuery();
         return i;
     }


      public int Update_emp_attend_daily(String id,String company_name, String vid, String datee, String emp_id, String today_commitment, String attendance, String achivement, String activation_in_no, String activation_revnue, String scanning_in_no, String scanning_revnue, String remark)
      {
          Int32 i;
          cmd1 = new SqlCommand();
          cmd1.CommandType = CommandType.StoredProcedure;
          cmd1.CommandText = "sp_Update_emp_daily_attendance";
          cmd1.Connection = c.OpenMyCon();
          cmd1.Parameters.AddWithValue("@id", id);
          cmd1.Parameters.AddWithValue("@company_name", company_name);
          cmd1.Parameters.AddWithValue("@vid", vid);
          cmd1.Parameters.AddWithValue("@datee", datee);
          cmd1.Parameters.AddWithValue("@emp_id", emp_id);
          cmd1.Parameters.AddWithValue("@today_commitment", today_commitment);
          cmd1.Parameters.AddWithValue("@attendance", attendance);
          cmd1.Parameters.AddWithValue("@achivement", achivement);
          cmd1.Parameters.AddWithValue("@activation_in_no", activation_in_no);
          cmd1.Parameters.AddWithValue("@activation_revnue", activation_revnue);
          cmd1.Parameters.AddWithValue("@scanning_in_no ", scanning_in_no);
          cmd1.Parameters.AddWithValue("@scanning_revnue ", scanning_revnue);
          cmd1.Parameters.AddWithValue("@remark ", remark);
          i = cmd1.ExecuteNonQuery();
          return i;
      }
     public int Update_EmployeeTarget_details(string tdtl_id, string tid, string emp_id, double target_amt)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Update_vEmp_Target_dtls";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@tdid", tdtl_id);
         cmd1.Parameters.AddWithValue("@tid", tid);
         cmd1.Parameters.AddWithValue("@emp_id", emp_id);
         cmd1.Parameters.AddWithValue("@target_amt", target_amt);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Update_user(string user_role, string user_name, string password, Int32 vid)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Update_User";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@user_name", user_name);
         cmd1.Parameters.AddWithValue("@password", password);
         cmd1.Parameters.AddWithValue("@user_role", user_role);
         cmd1.Parameters.AddWithValue("@vid", vid);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Insert_vertical_target(String year, Int32 month, String datee, String remark)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_vertical_target";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@year", year);
         cmd1.Parameters.AddWithValue("@month", month);
         cmd1.Parameters.AddWithValue("@datee", datee);
         cmd1.Parameters.AddWithValue("@remark", remark);
          i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Insert_vertical_target_dtls(Int32 target_id, Int32 vid, Double target_amt)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_vertical_target_dtl";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@target_id", target_id);
         cmd1.Parameters.AddWithValue("@vid", vid);
         cmd1.Parameters.AddWithValue("@target_amt", target_amt);
         i = cmd1.ExecuteNonQuery();
         return i;
     }

     public int Update_status_prod(string p, string p_2, string p_3)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "Update_status_prod";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@p_type", p_2);
         cmd1.Parameters.AddWithValue("@pid", p);
         cmd1.Parameters.AddWithValue("@status", p_3);
         i = cmd1.ExecuteNonQuery();
         return i;
     }

     public int Insert_Purchase_product(Int32 p_id,DateTime p_date ,String remark,String p_vendor)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_purchase_product";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@p_id", p_id);
         cmd1.Parameters.AddWithValue("@p_date", p_date);
         cmd1.Parameters.AddWithValue("@remark", remark);
         cmd1.Parameters.AddWithValue("@p_vendor", p_vendor);
         i = cmd1.ExecuteNonQuery();
         return i;
     }



     public int Insert_Purchase_product_dtl(Int32 purchase_id ,String pid ,String p_rate ,String p_quantity, String p_total)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_purchase_product_dtl";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@purchase_id", purchase_id);
         cmd1.Parameters.AddWithValue("@pid", pid);
         cmd1.Parameters.AddWithValue("@p_rate", p_rate);
         cmd1.Parameters.AddWithValue("@p_quantity", p_quantity);
         cmd1.Parameters.AddWithValue("@p_total", p_total);
         i = cmd1.ExecuteNonQuery();
         return i;
     }

     public int Insert_Product_stock(String purchase_id, String pid, String p_date, String p_quantity)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_product_stock";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@purchase_id", purchase_id);
         cmd1.Parameters.AddWithValue("@pid", pid);
         cmd1.Parameters.AddWithValue("@p_date", p_date);
         cmd1.Parameters.AddWithValue("@p_quantity", p_quantity);
         i = cmd1.ExecuteNonQuery();
         return i;
     }


     public int Insert_Productsale(Int32 sale_id, String p_date, String p_sale_to)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "Insert_Product_sale";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@sale_id", sale_id);
         cmd1.Parameters.AddWithValue("@p_date", p_date);
         cmd1.Parameters.AddWithValue("@p_sale_to", p_sale_to);
         i = cmd1.ExecuteNonQuery();
         return i;
     }

     public int Insert_Productsale_dtl(Int32 sale_id, String pid, String p_rate, String p_quantity, String p_total)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "Insert_Product_sale_dtl";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@sale_id", sale_id);
         cmd1.Parameters.AddWithValue("@pid", pid);
         cmd1.Parameters.AddWithValue("@p_rate", p_rate);
         cmd1.Parameters.AddWithValue("@p_quantity", p_quantity);
         cmd1.Parameters.AddWithValue("@p_total", p_total);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Insert_DRA_Creation(String dra_id, String dra_region, String cont_per_name, String billing_address, String state, String city, String bank_acc_no, String bank_detail, String description)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_DRA_Creation";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@dra_id", dra_id);
         cmd1.Parameters.AddWithValue("@dra_region", dra_region);
         cmd1.Parameters.AddWithValue("@cont_per_name", cont_per_name);
         cmd1.Parameters.AddWithValue("@billing_address", billing_address);
         cmd1.Parameters.AddWithValue("@state", state);
         cmd1.Parameters.AddWithValue("@city", city);
         cmd1.Parameters.AddWithValue("@bank_acc_no", bank_acc_no);
         cmd1.Parameters.AddWithValue("@bank_detail", bank_detail);
         cmd1.Parameters.AddWithValue("@description", description);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Insert_partner_Creation(String comp_id, String comp_name, String c_per_name, String billing_add, String state, String city, String product, String price, String curr_offer,String datee, String remark)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_partner_Creation";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@comp_id", comp_id);
         cmd1.Parameters.AddWithValue("@comp_name", comp_name);
         cmd1.Parameters.AddWithValue("@c_per_name", c_per_name);
         cmd1.Parameters.AddWithValue("@billing_add", billing_add);
         cmd1.Parameters.AddWithValue("@state", state);
         cmd1.Parameters.AddWithValue("@city", city);
         cmd1.Parameters.AddWithValue("@product", product);
         cmd1.Parameters.AddWithValue("@price", price);
         cmd1.Parameters.AddWithValue("@curr_offer", curr_offer);
         cmd1.Parameters.AddWithValue("@datee", datee);
         cmd1.Parameters.AddWithValue("@remark", remark);
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Insert_branch_Creation(String branch_id, String branch_reg, String c_p_name, String billing_add, String state, String city, String bank_acc, String bank_dtl, String descriptioin)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_branch_Creation";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@branch_id", branch_id);
         cmd1.Parameters.AddWithValue("@branch_reg", branch_reg);
         cmd1.Parameters.AddWithValue("@c_p_name", c_p_name);
         cmd1.Parameters.AddWithValue("@billing_add", billing_add);
         cmd1.Parameters.AddWithValue("@state", state);
         cmd1.Parameters.AddWithValue("@city", city);
         cmd1.Parameters.AddWithValue("@bank_acc", bank_acc);
         cmd1.Parameters.AddWithValue("@bank_dtl", bank_dtl);
         cmd1.Parameters.AddWithValue("@descriptioin", descriptioin);
         
         i = cmd1.ExecuteNonQuery();
         return i;
     }
     public int Insert_retail_Creation(String rtl_id, String rtl_reg, String c_p_name, String bill_add, String state, String city, String bank_acc, String bank_dtl, String description)
     {
         Int32 i;
         cmd1 = new SqlCommand();
         cmd1.CommandType = CommandType.StoredProcedure;
         cmd1.CommandText = "sp_Insert_retail_Creation";
         cmd1.Connection = c.OpenMyCon();
         cmd1.Parameters.AddWithValue("@rtl_id", rtl_id);
         cmd1.Parameters.AddWithValue("@rtl_reg", rtl_reg);
         cmd1.Parameters.AddWithValue("@c_p_name", c_p_name);
         cmd1.Parameters.AddWithValue("@bill_add", bill_add);
         cmd1.Parameters.AddWithValue("@state", state);
         cmd1.Parameters.AddWithValue("@city", city);
         cmd1.Parameters.AddWithValue("@bank_acc", bank_acc);
         cmd1.Parameters.AddWithValue("@bank_dtl", bank_dtl);
         cmd1.Parameters.AddWithValue("@description", description);

         i = cmd1.ExecuteNonQuery();
         return i;
     }
}
