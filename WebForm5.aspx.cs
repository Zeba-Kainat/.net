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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          SqlConnection conn  = new SqlConnection(ConfigurationManager.AppSettings["icraConnectionString"].ToString());
        }

     
        protected void btnsave_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["icraConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            SqlParameter paramname = new SqlParameter();
            paramname.ParameterName = "@name";
            paramname.Value = txt1.Text;
            cmd.Parameters.Add(paramname);


            SqlParameter paramfirstname = new SqlParameter();
            paramfirstname.ParameterName = "@fname";
            paramfirstname.Value = txt2.Text;
            cmd.Parameters.Add(paramfirstname);


            SqlParameter paramlastname = new SqlParameter();
            paramlastname.ParameterName = "@lname";
            paramlastname.Value = txt3.Text;
            cmd.Parameters.Add(paramlastname);


            SqlParameter paramgender = new SqlParameter();
            paramgender.ParameterName = "@gender";
            paramgender.Value = rdbGender.Text;
            cmd.Parameters.Add(paramgender);

            SqlParameter paramcountry = new SqlParameter();
            paramcountry.ParameterName = "@country";
            paramcountry.Value = ddlcountry.Text;
            cmd.Parameters.Add(paramcountry);

            SqlParameter paramstate = new SqlParameter();
            paramstate.ParameterName = "@states";
            paramstate.Value = ddlstate.Text;
            cmd.Parameters.Add(paramstate);

            SqlParameter paramcity = new SqlParameter();
            paramcity.ParameterName = "@city";
            paramcity.Value = ddlcity.Text;
            cmd.Parameters.Add(paramcity);

            SqlParameter paramtech = new SqlParameter();
            paramtech.ParameterName = "@tech";
            paramtech.Value = cbltech.Text;
            cmd.Parameters.Add(paramtech);


            string query = "sp_regis";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Webform6.aspx");
        }

        //protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (ddlcountry.SelectedIndex > 0)
//            {
//                int cid = Convert.ToInt32(ddlcountry.SelectedValue);

//            }
           
           
        }
}