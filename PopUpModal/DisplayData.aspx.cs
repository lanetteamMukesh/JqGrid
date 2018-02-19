using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using DataLayer;
using BussinessLayer;

public partial class DisplayData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillGrid();
        }
    }

    public void fillGrid()
    {
        List<person> lst = Person_Service.getAll();
        GridView1.DataSource = lst;
        GridView1.DataBind();

    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Person_Service ps = new Person_Service();
        int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Id"]);
        ps.DeleteRecord(Id);
        Response.Redirect("DisplayData.aspx");
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillGrid();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        fillGrid();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillGrid();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Id"]);
      //  Label lblId = (Label)GridView1.Rows[e.RowIndex].FindControl("lblId");
      //  TextBox Name = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
        TextBox Name = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtName"));
        int Age = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtAge")).Text);
      //  Response.Write("<script>alert('"+Name.Text+"');</script>");
        Person_Service ps = new Person_Service();
        ps.Updaterecord(Id, Name.Text, Age);
        GridView1.EditIndex=-1;
        fillGrid();
    }

    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
       
    }
}