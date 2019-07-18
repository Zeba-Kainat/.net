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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
                bind();
        }
        private void bind()
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["icraConnectionString"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM registration", conn);
            //da.SelectCommand.Connection = conn;
            //da.SelectCommand.CommandText = "SELECT * FROM Registration";

            da.Fill(ds);
            conn.Close();

            grid1.DataSource = ds;
            grid1.DataBind();
        }

        protected void grid1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grid1.EditIndex = e.NewEditIndex;
            bind();
            Response.Redirect("Webform5.aspx");
           
        }

        protected void grid1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grid1.EditIndex = -1;
            bind();
        }

        protected void grid1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = grid1.Rows[e.RowIndex].FindControl("Label1") as Label;
            String ID = id.Text;
            TextBox FirstName = grid1.Rows[e.RowIndex].FindControl("text1") as TextBox;
            TextBox LastName = grid1.Rows[e.RowIndex].FindControl("text2") as TextBox;

            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["icraConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            SqlParameter paramTD = new SqlParameter();
            paramTD.ParameterName = "@name";
            paramTD.Value = ID;
            cmd.Parameters.Add(paramTD);


            SqlParameter paramfirstname = new SqlParameter();
            paramfirstname.ParameterName = "@fname";
            paramfirstname.Value = FirstName.Text;
            cmd.Parameters.Add(paramfirstname);


            SqlParameter paramlastname = new SqlParameter();
            paramlastname.ParameterName = "@lname";
            paramlastname.Value = LastName.Text;
            cmd.Parameters.Add(paramlastname);

            string query = "sp_Emp_Grid_Update";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            grid1.EditIndex = -1;
            bind();

            

        }
    }
    
}