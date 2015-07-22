using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server= MEGHNA-PC; database = NewHorizon; uid = sa; password=1234");
    SqlCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {

       if (DropDownList1.SelectedItem.Value.Equals("Employee"))
       {
           con.Open();
           cmd = new SqlCommand("select count(ID) from emp where ename = '" + UserName.Text + "' and password = '" + Password.Text + "'", con);

           int res = (Int32)cmd.ExecuteScalar();

           if (res > 0)
           {
               Session["name"] = UserName.Text;
               Response.Redirect("EmployeePage.aspx");
           }
           else
               Response.Write("<script>alert('Login Failed')</script>");

           con.Close();


       }

       else if (DropDownList1.SelectedItem.Value.Equals("Manager"))
       {
           con.Open();
           cmd = new SqlCommand("select count(ID) from admin where uname = '" + UserName.Text + "' and password = '" + Password.Text + "'", con);

           int res = (Int32)cmd.ExecuteScalar();

           if (res > 0)
           {
               Session["name"] = UserName.Text;
               Response.Redirect("Manager.aspx");
           }
           else
               Response.Write("<script>alert('Login Failed')</script>");

           con.Close();

       }


       else if (DropDownList1.SelectedItem.Value.Equals("Executive"))
       {

           con.Open();
           cmd = new SqlCommand("select count(ID) from exec1 where uname = '" + UserName.Text + "' and password = '" + Password.Text + "'", con);

           int res = (Int32)cmd.ExecuteScalar();

           if (res > 0)
           {
               Session["name"] = UserName.Text;
               Response.Redirect("executivehome.aspx");
           }
           else
               Response.Write("<script>alert('Login Failed')</script>");

           con.Close();

       }

    }
}