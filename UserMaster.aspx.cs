using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
                bind();
            
        }
        private void bind()
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(dbConnection.connectionstring);
            string query = "Gridviews";


            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            conn.Close();

            grid1.DataSource = ds;
            grid1.DataBind();
        }

        protected void create_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserMasterAddEdit.aspx");
        }




        protected void grid1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {

                int usercode = Convert.ToInt32(e.CommandArgument.ToString());
                Session["id"] = e.CommandArgument.ToString();
               
                Response.Redirect("UserMasterAddEdit.aspx");

            }
            else if (e.CommandName == "View")


            {

                    int usercode = Convert.ToInt32(e.CommandArgument.ToString());
                    Session["id"] = e.CommandArgument.ToString();

                    Response.Redirect("UserDetails.aspx");

                
            }
        }

        protected void grid1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbConnection.connectionstring);
            string query = "deleteviews";
           SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.AddWithValue("@usercode", Convert.ToInt32(grid1.DataKeys[e.RowIndex].Value.ToString()));
            cmd.ExecuteNonQuery();
            bind();

        }

       
            
    }
}