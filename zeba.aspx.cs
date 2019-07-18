using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace WebApp
{
    public partial class zeba : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
    {

    }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=SDT137\SQLEXPRESS;Initial Catalog=zeba;Integrated Security=true");
            SqlCommand cmd = new SqlCommand();
           
            SqlParameter paramEmail = new SqlParameter();
            paramEmail.ParameterName = "@Email";
            paramEmail.Value = txtEmail.Text;
            cmd.Parameters.Add(paramEmail);

            SqlParameter paramPassword = new SqlParameter();
            paramPassword.ParameterName = "@Password";
            paramPassword.Value = txtPwd.Text;
            cmd.Parameters.Add(paramPassword);

          

            string query = "SELECT name FROM login WHERE email=@Email and password=@password";
            cmd.CommandText = query;
            //  cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            conn.Open();
            object objName = cmd.ExecuteScalar();
            conn.Close();
            if (objName != null)
            {
                string name = objName.ToString(); // convert from object variable to string
                Session["LoggedInName"] = name;
                Response.Redirect("default.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
            }

        }
    }
}