using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace WebApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=SDT137\SQLEXPRESS;Initial Catalog=zeba;Integrated Security=true");

            SqlCommand cmd = new SqlCommand();

            SqlParameter paramname = new SqlParameter();
            paramname.ParameterName = "@emp_name";
            paramname.Value = txtname.Text;
            cmd.Parameters.Add(paramname);

            SqlParameter paramaddress = new SqlParameter();
            paramaddress.ParameterName = "@emp_address";
            paramaddress.Value = txtadd.Text;
            cmd.Parameters.Add(paramaddress);

            SqlParameter paramcity = new SqlParameter();
            paramcity.ParameterName = "@city";
            paramcity.Value = TextBox1.Text;
            cmd.Parameters.Add(paramcity);

            SqlParameter parammobile = new SqlParameter();
            parammobile.ParameterName = "@mobile";
            parammobile.Value = TextBox2.Text;
            cmd.Parameters.Add(parammobile);

            SqlParameter paramemail = new SqlParameter();
            paramemail.ParameterName = "@email";
            paramemail.Value = TextBox3.Text;
            cmd.Parameters.Add(paramemail);

            SqlParameter paramdate_of_joining = new SqlParameter();
            paramdate_of_joining.ParameterName = "@date_of_joining";
            paramdate_of_joining.Value = TextBox4.Text;
            cmd.Parameters.Add(paramdate_of_joining);

            SqlParameter paramgrade = new SqlParameter();
            paramgrade.ParameterName = "@grade";
            paramgrade.Value = TextBox5.Text;
            cmd.Parameters.Add(paramgrade);

            SqlParameter paramdepartment = new SqlParameter();
            paramdepartment.ParameterName = "@department";
            paramdepartment.Value = ddldept.Text;
            cmd.Parameters.Add(paramdepartment);

            SqlParameter paramdesignation = new SqlParameter();
            paramdesignation.ParameterName = "@designation";
            paramdesignation.Value = TextBox7.Text;
            cmd.Parameters.Add(paramdesignation);

            SqlParameter paramgender= new SqlParameter();
            paramgender.ParameterName = "@gender";
            paramgender.Value = rdbGender.Text;
            cmd.Parameters.Add(paramgender);

            SqlParameter paramprofile_picture = new SqlParameter();
            paramprofile_picture.ParameterName = "@profile_picture";
            paramprofile_picture.Value = file1.FileName;
            cmd.Parameters.Add(paramprofile_picture);

            file1.SaveAs(Server.MapPath("~/image/" + file1.FileName));
            img1.ImageUrl = "~/image/" + file1.FileName;


            SqlParameter paramsalary= new SqlParameter();
            paramsalary.ParameterName = "@salary";
            paramsalary.Value = TextBox10.Text;
            cmd.Parameters.Add(paramsalary);

            string query = "sp_enployeeinfo";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();














        }
    }
}