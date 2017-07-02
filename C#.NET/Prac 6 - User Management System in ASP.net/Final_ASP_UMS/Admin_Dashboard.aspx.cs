using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
public partial class Admin_Dashboard : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        HttpCookie cookie = Request.Cookies["Preferences"];
        if (cookie == null)
        {
            Label_Last_Visit.Text = "<b>You Have Never Visited This Page Admin</b>";
        }
        else
        {
            //Logic to Show Last Visited Time in Label
            Response.Cookies["username"].Value = Label_Last_Visit.Text;
            Response.Cookies["username"].Value = DateTime.Now.ToString();
            Response.Cookies["username"].Expires = DateTime.Now.AddDays(1);
            if(Request.Cookies["username"] != null)

                Label_Last_Visit.Text = Request.Cookies["username"].Value;
        }
    }
    

    protected void btn_Logout_Admin_Click(object sender, EventArgs e)
    {
        //Server.Transfer("Login.aspx",true);
        Session.Abandon();
        Session.Clear();
        Session.RemoveAll();
        System.Web.Security.FormsAuthentication.SignOut();
        Response.Redirect("Home.aspx");

    }

    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        //Here We Will Begin to Create New User
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
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Admin - You have Successfully Created New User');window.location ='Admin_Dashboard.aspx';", true);
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

    protected void btn_Admin_Del_User_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from [loginuser] where username=@user", conn);
            cmd.Parameters.AddWithValue("user", txtBox_Admin_Del_User.Text);
            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('User Deleted Succesfully !! YOHO');window.location ='Admin_Dashboard.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Invalid User!!Try Again');window.location ='Admin_Dashboard.aspx';", true);
            }
            conn.Close();
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

    protected void btn_Reset_pass_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [loginuser] SET password=@pass where username=@user", conn);
            cmd.Parameters.AddWithValue("user", txtBox_Admin_Update_User.Text);
            cmd.Parameters.AddWithValue("pass", txtBox_Admin_Update_ResetPass.Text);

            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Password Updated Succefully');window.location ='Admin_Dashboard.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Invalid Username');window.location ='Admin_Dashboard.aspx';", true);
            }
            conn.Close();
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

    protected void Button_Admin_Logout_Click(object sender, EventArgs e)
    {
        //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Password Updated Succefully');window.location ='Login.aspx';", true);
        
    }
}