using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
public partial class Login : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (Gender.SelectedItem.Value == "Admin")
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from [loginadmin] where adminid=@name and password=@pass", conn);
                cmd.Parameters.AddWithValue("@name", txtBoxUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtBoxPass.Text);

                SqlDataReader rdr = cmd.ExecuteReader();
                
                if (rdr.HasRows)
                {
                    //Response.Write("<script>alert('You Are Succesfully Logged In!!');</script>");
                    //Server.Transfer("Admin_Dashboard.aspx", true);
                    //Response.Redirect("Admin_Dashboard.aspx");

                    HttpCookie cookie = Request.Cookies["Preferences"];
                    if (cookie == null)
                    {
                        cookie = new HttpCookie("Preferences");
                    }
                    cookie["username"] = "Admin !!";
                    cookie.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(cookie);
                    Response.Write("Cookie created: " + cookie["username"]);
                    ///////////////////////////////////////////////////////////
                    Session["user"] = txtBoxUsername.Text;
                    ScriptManager.RegisterStartupScript(this,this.GetType(),"alert", "alert('You Are Succesfully Logged In!!');window.location ='Admin_Dashboard.aspx';", true);
                    rdr.Close();
                    conn.Close();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Invalid Login!! Try Again');window.location ='Login.aspx';", true);
                    // Response.Redirect(Request.RawUrl);
                    conn.Close();
                }
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

        else if (Gender.SelectedItem.Value == "Customer")
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from [loginuser] where username=@name and password=@pass", conn);
                cmd.Parameters.AddWithValue("@name", txtBoxUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtBoxPass.Text);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    //Server.Transfer("Admin_Dashboard.aspx", true);
                    Session["user"] = txtBoxUsername.Text;
                    Response.Redirect("Customer_Dashboard.aspx?id=" +txtBoxUsername.Text);
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You Are Succesfully Logged In!!');window.location ='Customer_Dashboard.aspx';", true);
                    rdr.Close();
                    conn.Close();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Invalid Login!! Try Again');window.location ='Login.aspx';", true);
                    // Response.Redirect(Request.RawUrl);
                    conn.Close();
                }
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

        else
        {
            Response.Write("<script>alert('You Have to Select Either Admin or Customer!!');</script>");
        }

    }
}