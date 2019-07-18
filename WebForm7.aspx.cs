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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void check_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["icraConnectionString"].ToString());

            SqlCommand cmd = new SqlCommand();

            SqlParameter paramname = new SqlParameter();
            paramname.ParameterName = "@name";
            paramname.Value = txt1.Text;
            cmd.Parameters.Add(paramname);

            string query = "sp_checking";

            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();


            object objName = cmd.ExecuteScalar();
            conn.Close();
            if (objName != null)
            {
                string name = objName.ToString(); // convert from object variable to string
                Session["LoggedInName"] = name;
                Label1.Text = "This has already been used";
            }
            else
            {


                Response.Redirect("Webform5.aspx");

            }

        }
    }
}