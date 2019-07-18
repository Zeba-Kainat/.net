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
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            
            {
                fillcompetency();
                fillstatus();
                fillcountry();
                fillradio();


            }
            //Session value is assign on the text box  
            if (Session["id"] != null)
            {

                SqlConnection con = new SqlConnection(dbConnection.connectionstring);
                SqlDataAdapter da = new SqlDataAdapter("edit", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@usercode", SqlDbType.Int).Value = Convert.ToInt32(Session["id"].ToString());
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtid.Text = dt.Rows[0]["userid"].ToString();
  
                    
                txtfirstname.Text = dt.Rows[0]["firstname"].ToString();
                txtmiddlename.Text = dt.Rows[0]["middlename"].ToString();
                txtlastname.Text = dt.Rows[0]["lastname"].ToString();
                rdbGender.Text = dt.Rows[0]["gendercode"].ToString();
              //  ddlcompetency.Text = dt.Rows[0]["competencycode"].ToString();
                ddlcompetency.SelectedValue= dt.Rows[0]["competencycode"].ToString();
                ddlcountry.SelectedValue = dt.Rows[0]["countrycode"].ToString();
                ddlstatus.SelectedValue= dt.Rows[0]["statuscode"].ToString();
                Session["id"] = null;
                    btn_save.Visible = false;
                btn_update.Visible = true;
                
                               
            }
            





        }
        private void fillcompetency()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["icraConnectionString"].ToString());
            string comp = "spcompetency";
            SqlDataAdapter adpt = new SqlDataAdapter(comp, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            ddlcompetency.DataSource = dt;
            ddlcompetency.DataTextField = "competencyname";
            ddlcompetency.DataValueField = "id";
            ddlcompetency.DataBind();
            ddlcompetency.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        private void fillstatus()
        {

            SqlConnection conn = new SqlConnection(dbConnection.connectionstring);
            string stat = "spstatus";
            SqlDataAdapter adpt = new SqlDataAdapter(stat, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            ddlstatus.DataSource = dt;
            ddlstatus.DataTextField = "status";
            ddlstatus.DataValueField = "id";
            ddlstatus.DataBind();
            ddlstatus.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        private void fillcountry()
        {

            SqlConnection conn = new SqlConnection(dbConnection.connectionstring);
            string coun = "spcountrys";
            SqlDataAdapter adpt = new SqlDataAdapter(coun, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            ddlcountry.DataSource = dt;
            ddlcountry.DataTextField = "countryname";
            ddlcountry.DataValueField = "id";
            ddlcountry.DataBind();
            ddlcountry.Items.Insert(0, new ListItem("--Select--", "0"));
        }



        protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            int CountryID = Convert.ToInt32(ddlcountry.SelectedValue);
            if (ddlcountry.SelectedIndex > 0)
            {
                FillState(CountryID);
            }
          


        }
        public void FillState(int CountryId)
        {
            SqlConnection con = new SqlConnection(dbConnection.connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("spstates", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
           da.SelectCommand.Parameters.Add("@cid", SqlDbType.Int).Value = CountryId;
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddlstate.DataSource = dt;
            ddlstate.DataTextField = "statename";
            ddlstate.DataValueField = "statecode";
            ddlstate.DataBind();
            ddlstate.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        public void FillCity(int StateId)
        {
            SqlConnection con = new SqlConnection(dbConnection.connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("spcitys", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@sid", SqlDbType.Int).Value = StateId;
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddlcity.DataSource = dt;
            ddlcity.DataTextField = "cityname";
            ddlcity.DataValueField = "citycode";
            ddlcity.DataBind();
            ddlcity.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StateID = Convert.ToInt32(ddlstate.SelectedValue);
            if (ddlstate.SelectedIndex > 0)
            {
                FillCity(StateID);
            }
        }
        private void fillradio()
        {

            SqlConnection conn = new SqlConnection(dbConnection.connectionstring);
            string gen = "spgender";
            SqlDataAdapter adpt = new SqlDataAdapter(gen, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            rdbGender.DataSource = dt;
            rdbGender.DataTextField = "gender";
            rdbGender.DataValueField = "id";
            rdbGender.DataBind();

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbConnection.connectionstring);
            SqlCommand cmd = new SqlCommand();

            SqlParameter paramname = new SqlParameter();
            paramname.ParameterName = "@userid";
            paramname.Value = txtid.Text;
            cmd.Parameters.Add(paramname);


            SqlParameter paramfirstname = new SqlParameter();
            paramfirstname.ParameterName = "@firstname";
            paramfirstname.Value = txtfirstname.Text;
            cmd.Parameters.Add(paramfirstname);


            SqlParameter parammiddlename = new SqlParameter();
            parammiddlename.ParameterName = "@middlename";
            parammiddlename.Value = txtmiddlename.Text;
            cmd.Parameters.Add(parammiddlename);

            SqlParameter paramlastname = new SqlParameter();
            paramlastname.ParameterName = "@lastname";
            paramlastname.Value = txtlastname.Text;
            cmd.Parameters.Add(paramlastname);

            SqlParameter paramcompetency = new SqlParameter();
            paramcompetency.ParameterName = "@competencycode";
            paramcompetency.Value = ddlcompetency.SelectedValue;
            cmd.Parameters.Add(paramcompetency);



            SqlParameter paramgender = new SqlParameter();
            paramgender.ParameterName = "@gendercode";
            paramgender.Value = rdbGender.SelectedValue;
            cmd.Parameters.Add(paramgender);

            SqlParameter paramcountry = new SqlParameter();
            paramcountry.ParameterName = "@countrycode";
            paramcountry.Value = ddlcountry.SelectedValue;
            cmd.Parameters.Add(paramcountry);

            SqlParameter paramstate = new SqlParameter();
            paramstate.ParameterName = "@statecode";
            paramstate.Value = ddlstate.SelectedValue;
            cmd.Parameters.Add(paramstate);

            SqlParameter paramcity = new SqlParameter();
            paramcity.ParameterName = "@citycode";
            paramcity.Value = ddlcity.SelectedValue;
            cmd.Parameters.Add(paramcity);

            SqlParameter paramstatus = new SqlParameter();
            paramstatus.ParameterName = "@statuscode";
            paramstatus.Value = ddlstatus.SelectedValue;
            cmd.Parameters.Add(paramstatus);


            string query = "UserInfo";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            object objName = cmd.ExecuteScalar();
            conn.Close();
            
            
            
        }

        protected void btn_reset_Click(object sender, EventArgs e)
        {

            Response.Redirect("UserMasterAddEdit.aspx");
        }



        protected void txtid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["icraConnectionString"].ToString());

            SqlCommand cmd = new SqlCommand();

            SqlParameter paramname = new SqlParameter();
            paramname.ParameterName = "@userid";
            paramname.Value = txtid.Text;
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
                Label1.Text = "This has already been used.please select another one!!";
                btn_save.Visible = false;
            }

            else
            {
                btn_save.Visible = true;
                Label1.Text = "Available";

            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbConnection.connectionstring);
            SqlCommand cmd = new SqlCommand();

            SqlParameter paramname = new SqlParameter();
            paramname.ParameterName = "@userid";
            paramname.Value = txtid.Text;
            cmd.Parameters.Add(paramname);


            SqlParameter paramfirstname = new SqlParameter();
            paramfirstname.ParameterName = "@firstname";
            paramfirstname.Value = txtfirstname.Text;
            cmd.Parameters.Add(paramfirstname);


            SqlParameter parammiddlename = new SqlParameter();
            parammiddlename.ParameterName = "@middlename";
            parammiddlename.Value = txtmiddlename.Text;
            cmd.Parameters.Add(parammiddlename);

            SqlParameter paramlastname = new SqlParameter();
            paramlastname.ParameterName = "@lastname";
            paramlastname.Value = txtlastname.Text;
            cmd.Parameters.Add(paramlastname);

            SqlParameter paramcompetency = new SqlParameter();
            paramcompetency.ParameterName = "@competencycode";
            paramcompetency.Value = ddlcompetency.SelectedValue;
            cmd.Parameters.Add(paramcompetency);



            SqlParameter paramgender = new SqlParameter();
            paramgender.ParameterName = "@gendercode";
            paramgender.Value = rdbGender.SelectedValue;
            cmd.Parameters.Add(paramgender);

            SqlParameter paramcountry = new SqlParameter();
            paramcountry.ParameterName = "@countrycode";
            paramcountry.Value = ddlcountry.SelectedValue;
            cmd.Parameters.Add(paramcountry);

            SqlParameter paramstate = new SqlParameter();
            paramstate.ParameterName = "@statecode";
            paramstate.Value = ddlstate.SelectedValue;
            cmd.Parameters.Add(paramstate);

            SqlParameter paramcity = new SqlParameter();
            paramcity.ParameterName = "@citycode";
            paramcity.Value = ddlcity.SelectedValue;
            cmd.Parameters.Add(paramcity);

            SqlParameter paramstatus = new SqlParameter();
            paramstatus.ParameterName = "@statuscode";
            paramstatus.Value = ddlstatus.SelectedValue;
            cmd.Parameters.Add(paramstatus);

            string query = "updateuserdetails";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            object objName = cmd.ExecuteScalar();
            conn.Close();
        }

       
    }

    }  
