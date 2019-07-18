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
    public partial class WebForm4 : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
                bind();
        }
        private void bind()
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(@"Data Source=SDT137\SQLEXPRESS;Initial Catalog=zeba;Integrated Security=true");
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM employeeinfo", conn);
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
            TextBox Name = grid1.Rows[e.RowIndex].FindControl("txtName") as TextBox;
            TextBox Contact = grid1.Rows[e.RowIndex].FindControl("txtMobile") as TextBox;
            

            SqlConnection conn = new SqlConnection(@"Data Source=SDT137\SQLEXPRESS;Initial Catalog=zeba;Integrated Security=true");
            SqlCommand cmd = new SqlCommand();

            SqlParameter paramTD = new SqlParameter();
            paramTD.ParameterName = "@email";
            paramTD.Value = ID;
            cmd.Parameters.Add(paramTD);

            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "@emp_name";
            paramName.Value = Name.Text;
            cmd.Parameters.Add(paramName);

           

            SqlParameter paramPhone = new SqlParameter();
            paramPhone.ParameterName = "@Mobile";
            paramPhone.Value = Contact.Text;
            cmd.Parameters.Add(paramPhone);

            
           
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
