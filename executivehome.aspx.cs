using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class executivehome : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("server=MEGHNA-PC;database=NewHorizon;uid=sa;password=1234");
    protected void Page_Load(object sender, EventArgs e)
    {
        Label14.Text = "Welcome " + Session["name"].ToString();
        if (!IsPostBack)
        {
            bind();
        }
    }
    public void bind()
    {
        SqlCommand cmd = new SqlCommand("select * from Visa where status=0", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("delete from Visa where Vid='" + TextBox2.Text + "'", conn);
        int x = cmd.ExecuteNonQuery();
        if (x > 0)
        {
            Response.Write("<script>alert('Delted')</script>");
        }
        else
        {
            Response.Write("<script>alert('Deletion failed!')</script>");
        }
        conn.Close();
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("update Visa set Status=1 where Vid='" + TextBox2.Text + "'", conn);
        int x = cmd.ExecuteNonQuery();
        if (x > 0)
        {
            Response.Write("<script>alert('Approved!')</script>");
        }
        conn.Close();
        bind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //TODO: add logout logic
        Response.Redirect("Home.aspx");
    }
}