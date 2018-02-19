using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using DataLayer;
using BussinessLayer;

public partial class AddRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   
        fillGrid();
    }

    public void fillGrid()
    {
        List<person> lst = Person_Service.getAll();
        GridView1.DataSource = lst;
        GridView1.DataBind();

    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        Person_Service ps = new Person_Service();
        ps.AddRecord(txtName.Text, Convert.ToInt32(txtAge.Text));
        Response.Redirect("DisplayData.aspx");
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["Id"]);
        TextBox nm = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtName");
        TextBox age = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtAge");


    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        fillGrid();
    }
}