using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

public partial class Userpage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=MEGHNA-PC;database=NewHorizon;uid=sa;password=1234");
    String eid;
    public string CalculateMD5Hash(string input)
    {
        MD5 md5 = System.Security.Cryptography.MD5.Create();
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hash = md5.ComputeHash(inputBytes);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            sb.Append(hash[i].ToString("X2"));
        }
        return sb.ToString();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        eid = CalculateMD5Hash(Session["name"].ToString());
        Session["id"] = eid;
        Label2.Text = "Welcome " + Session["name"].ToString();
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Value.Equals("Renew"))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name, Dob, Email, Phone, Gender, Address, Country, Destination, StartDate, EndDate from Visa where eid='" + eid + "'", con);
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                sdr.Read();
                try
                {
                    TextBox1.Text = sdr.GetString(0);
                    TextBox1.Enabled = false;
                    TextBox2.Text = sdr.GetDateTime(1).Year.ToString() + "-" + sdr.GetDateTime(1).Month.ToString() + "-" + sdr.GetDateTime(1).Day.ToString();
                    TextBox2.Enabled = false;
                    TextBox3.Text = sdr.GetString(2);
                    TextBox4.Text = sdr.GetString(3);
                    RadioButtonList2.Enabled = false;
                    if (sdr.GetString(4).Equals("Male"))
                    {
                        RadioButtonList2.Items[0].Selected = true;
                    }
                    else
                    {
                        RadioButtonList2.Items[1].Selected = true;
                    }
                    TextBox6.Text = sdr.GetString(5);
                    TextBox6.Enabled = false;
                    TextBox7.Text = sdr.GetString(6);
                    TextBox8.Text = sdr.GetString(7);
                    TextBox9.Text = sdr.GetDateTime(8).Year.ToString() + "-" + sdr.GetDateTime(8).Month.ToString() + "-" + sdr.GetDateTime(8).Day.ToString();
                    TextBox10.Text = sdr.GetDateTime(9).Year.ToString() + "-" + sdr.GetDateTime(9).Month.ToString() +"-" + sdr.GetDateTime(9).Day.ToString();
                    Button1.Visible = true;
                    Button2.Visible = false;
                }
                catch (Exception ex)
                {
                    RadioButtonList1.Items[0].Selected = true;
                }
            
            }

        }
        else
        {
            TextBox6.Enabled = true;
            TextBox1.Enabled = true;
            TextBox2.Enabled = false;
            RadioButtonList2.Enabled = true;
            TextBox6.Enabled = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            RadioButtonList2.Items[0].Selected = true;
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            Button1.Visible = false;
            Button2.Visible = true;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        String vid = CalculateMD5Hash(CalculateMD5Hash(Session["name"].ToString()));
        SqlCommand cmd = new SqlCommand("insert into Visa values ('" + vid + "','" + eid + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + RadioButtonList2.SelectedItem.Value.ToString() + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "', 0)", con);

        int res = cmd.ExecuteNonQuery();

        if (res > 0)
        { 
            Response.Redirect("EmployeeMessagePage.aspx");     
        }
        else
        {
            Response.Write("<script>alert('Unsuccessful.Please try again after some time')</script>");
        }

        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        String vid = CalculateMD5Hash(CalculateMD5Hash(Session["name"].ToString()));
        SqlCommand cmd = new SqlCommand("update Visa set Email='"+TextBox3.Text+"', Phone='"+TextBox4.Text+"', Address='"+TextBox6.Text+"', Country='"+TextBox7.Text+"', Destination='"+TextBox8.Text+"', StartDate='"+TextBox9.Text+"', EndDate='"+TextBox10.Text+"', Status=0 where Vid='" + vid + "'",con);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            
            Response.Redirect("EmployeeMessagePage.aspx");
          
        }
        else
        {
            Response.Write("<script>alert(' Unsuccessful.Please try again after some time')</script>");
        }

        con.Close();

    }
}