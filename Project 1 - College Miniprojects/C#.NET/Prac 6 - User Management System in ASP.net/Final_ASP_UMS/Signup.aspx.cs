using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
public partial class Signup : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into [loginuser] (username,password,email,phone,fullname,gender,marital,address) values (@user,@pass,@em,@ph,@full,@gen,@mar,@add)", conn);
            cmd.Parameters.AddWithValue("user", TextBox_username.Text.ToString());
            cmd.Parameters.AddWithValue("pass", TextBox_pass.Text.ToString());
            cmd.Parameters.AddWithValue("em", TextBox_email.Text.ToString());
            cmd.Parameters.AddWithValue("ph", TextBox_phone.Text.ToString());
            cmd.Parameters.AddWithValue("full", TextBox_fullname.Text.ToString());
            cmd.Parameters.AddWithValue("gen", RadioButtonList_gender.SelectedItem.Text.ToString());
            cmd.Parameters.AddWithValue("mar", MartialDropDown.SelectedItem.Text.ToString());
            cmd.Parameters.AddWithValue("add", TextBox_Address.Text.ToString());
            cmd.ExecuteNonQuery();
            
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You have Successfully Signed Up - Now You Can Login');window.location ='Login.aspx';", true);
            conn.Close();

        } //End of Try
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            conn.Close();
        }
        finally
        {
            conn.Close();
        }
    }
}