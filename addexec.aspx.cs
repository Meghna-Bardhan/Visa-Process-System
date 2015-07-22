using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;

public partial class addexec : System.Web.UI.Page
{
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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=MEGHNA-PC;database=NewHorizon;uid=sa;password=1234");

        con.Open();
        String id = CalculateMD5Hash(TextBox2.Text);
        SqlCommand cmd = new SqlCommand("insert into exec1 values('" + id + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox6.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", con);
        int res = cmd.ExecuteNonQuery(); 

        if (res > 0)
        {
            Response.Write("<script>alert('Inserted successfully')</script>");
            Response.Redirect("Manager.aspx");
        }
        else
        {
            Response.Write("<script>alert('Unsuccessful')</script>");
        }
        con.Close();

    }
}