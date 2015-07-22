using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

public partial class centralregistration : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("server=MEGHNA-PC;database=NewHorizon;uid=sa;password=1234");
    protected void Page_Load(object sender, EventArgs e)
    {
        //634462
    }
    public string CalculateMD5Hash(string input)
    {
        MD5 md5 = MD5.Create();
        byte[] inputBytes = Encoding.ASCII.GetBytes(input);
        byte[] hash = md5.ComputeHash(inputBytes);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            sb.Append(hash[i].ToString("X2"));
        }
        return sb.ToString();
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Value.Equals("Admin"))
        {
            Label2.Visible = false;
            TextBox4.Visible = false;
            Label2.Enabled= false;
            TextBox4.Enabled = false;
            RequiredFieldValidator3.Enabled = false;
        }
        else if (RadioButtonList1.SelectedItem.Value.Equals("Employee"))
        {
            Label2.Visible = true;
            TextBox4.Visible = true;
            Label2.Enabled = true;
            TextBox4.Enabled = true;
            RequiredFieldValidator3.Enabled = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn.Open();
        if (RadioButtonList1.SelectedItem.Value.Equals("Employee"))
        {
            String id = CalculateMD5Hash(TextBox1.Text);
            SqlCommand
                cmd = new SqlCommand("insert into emp values('" + id + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "')", conn);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                //TODO make the JS alert work
                Response.Write("<script>alert('Inserted successfully')</script>");
            }
        }
        else
        {

            String id = CalculateMD5Hash(TextBox1.Text);
            SqlCommand cmd = new SqlCommand("insert into admin values('" + id + "','" + TextBox1.Text + "','" + TextBox2.Text + "')", conn);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                //TODO make the JS alert work
                Response.Write("<script>alert('Inserted successfully')</script>");
            } 
        }
        Response.Redirect("Home.aspx");
        conn.Close();
    }
}