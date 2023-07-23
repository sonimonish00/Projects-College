using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
public partial class Customer_Dashboard : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
           
        }
        lbl_Customer.Text = Request.QueryString["id"].ToString();
        TextBox_View_User.Text = lbl_Customer.Text;

    }

    protected void btn_Logout_Customer_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Session.RemoveAll();
        System.Web.Security.FormsAuthentication.SignOut();
        Response.Redirect("Home.aspx");
    }

    protected void Btn_Refresh_Click(object sender, EventArgs e)
    {
        SqlDataReader rdr = null;
        try
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [loginuser] where username=@user;", conn);
            cmd.Parameters.AddWithValue("user",lbl_Customer.Text);
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                TextBox_View_Email.Text = rdr[2].ToString();
                TextBox_View_Phone.Text = rdr[3].ToString();
                TextBox_View_Full.Text = rdr[4].ToString();
                TextBox_View_gender.Text = rdr[5].ToString();
                TextBox_View_Martial.Text = rdr[6].ToString();
                TextBox_View_address.Text = rdr[7].ToString();
                
            }
            rdr.Close();
            conn.Close();

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            conn.Close();
        }
    }

    protected void Btn_Edit_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [loginuser] set password=@pass , email=@em, phone=@ph, fullname=@full, gender=@gen, marital=@mar,address=@add where username=@user", conn);
            cmd.Parameters.AddWithValue("user", lbl_Customer.Text);
            cmd.Parameters.AddWithValue("pass", Txtbox_Edit_NewPass.Text);
            cmd.Parameters.AddWithValue("em", TextBox_Edit_Email0.Text);
            cmd.Parameters.AddWithValue("ph", TxtBox_Edit_Phone.Text);
            cmd.Parameters.AddWithValue("full", TextBox_Edit_Full0.Text);
            cmd.Parameters.AddWithValue("gen", TextBox_Edit_gender0.Text);
            cmd.Parameters.AddWithValue("mar", TextBox_Edit_Martial0.Text);
            cmd.Parameters.AddWithValue("add", TextBox_Edit_address0.Text);

            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Profile Updated Successfully');window.location ='Customer_Dashboard.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Sorry Error Occured');window.location ='Customer_Dashboard.aspx';", true);

            }
            
        }
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