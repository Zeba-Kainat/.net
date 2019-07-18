using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {

                SqlConnection con = new SqlConnection(dbConnection.connectionstring);
                SqlDataAdapter da = new SqlDataAdapter("viewcompetency", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@usercode", SqlDbType.Int).Value = Convert.ToInt32(Session["id"].ToString());
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbluserid.Text = dt.Rows[0]["userid"].ToString();


                lblfirstname.Text = dt.Rows[0]["firstname"].ToString();
                lblmiddlename.Text = dt.Rows[0]["middlename"].ToString();
                lbllastname.Text = dt.Rows[0]["lastname"].ToString();
                lblgender.Text = dt.Rows[0]["gender"].ToString();
                lblcompetency.Text = dt.Rows[0]["competencyname"].ToString();
                lblcountry.Text = dt.Rows[0]["countryname"].ToString();
                lblstate.Text = dt.Rows[0]["statename"].ToString();
                lblcity.Text = dt.Rows[0]["cityname"].ToString();
                lblstatus.Text = dt.Rows[0]["status"].ToString();
            }


        }

    }
}