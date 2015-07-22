using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class viewexec : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=MEGHNA-PC;database=NewHorizon;uid=sa;password=1234");
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack){ 
            bind();
        }
    }

    public void bind()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from exec1", con);
        SqlDataReader dr = cmd.ExecuteReader(); 
        GridView1.DataSource = dr; 
        GridView1.DataBind();
        con.Close();
    }




    
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        Label id = (Label)row.FindControl("Label1");
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from exec1 where id='" + id.Text + "'", con);
        GridView1.EditIndex = -1;
        cmd.ExecuteNonQuery();
        con.Close();
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
       GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];

       Label id = (Label)row.FindControl("Label1");
        
        TextBox uname = (TextBox)row.FindControl("Textbox2");
        TextBox pwd = (TextBox)row.FindControl("Textbox3");
        TextBox fname = (TextBox)row.FindControl("Textbox4");
        TextBox pnum = (TextBox)row.FindControl("Textbox1");
        con.Open();
        SqlCommand cmd = new SqlCommand("update exec1 set uname='" + uname.Text + "',password='" + pwd.Text + "',fullname='" + fname.Text + "',phonenum='" + pnum.Text + "' where ID='" + id.Text + "'", con);
        GridView1.EditIndex = -1;
        cmd.ExecuteNonQuery();
        con.Close();
        bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
