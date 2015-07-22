using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class EmployeeMessagePage : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("server=MEGHNA-PC;database=NewHorizon;uid=sa;password=1234");
    protected void Page_Load(object sender, EventArgs e)
    {
        String eid = Session["id"].ToString();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select Vid, status from Visa where Eid='" + eid + "'", conn);
        using (SqlDataReader sdr = cmd.ExecuteReader())
        {
            sdr.Read();
            Label3.Text = sdr.GetString(0);
            String stat = sdr.GetInt32(1).ToString();
            if (stat.Equals("0"))
            {
                Label2.Text = "PENDING";
            }
            else if (stat.Equals("1"))
            {
                Label2.Text = "APPOVED";
            }
            else if (stat.Equals("2"))
            {
                Label2.Text = "EXPIRED";
            }
        }

        conn.Close();
    }
}