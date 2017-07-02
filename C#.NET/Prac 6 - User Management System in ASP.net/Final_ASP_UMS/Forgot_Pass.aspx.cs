using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;
public partial class Forgot_Pass : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Final_Ok_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [loginuser] SET password=@pass WHERE username=@user", conn);
            cmd.Parameters.AddWithValue("user", txtBoxUser_Forgot.Text);
            cmd.Parameters.AddWithValue("pass", txtBoxresetPass.Text);
            cmd.ExecuteNonQuery();
            
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
    private void setotp(String otp)
    {
        String query = "UPDATE [loginuser] SET OTP=@otp WHERE username=@user;";
        SqlCommand cmd = new SqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@otp",otp);
        cmd.Parameters.AddWithValue("@user",txtBoxUser_Forgot.Text);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    protected void Btn_OTP_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [loginuser] WHERE username=@user", conn);
            cmd.Parameters.AddWithValue("user", txtBoxUser_Forgot.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            string email = null;
            Random rnd = new Random();
            int otp = rnd.Next(1000, 10000);
            conn.Open();
            setotp(otp.ToString());

            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                email = Convert.ToString(dt.Rows[0][2]);
                MailMessage mail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("sonimonish01@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Forgotten Password - OTP";
                mail.Body = "This is Your Automatically Generated One Time password --> " + otp;
                smtpserver.Port = 587;
                smtpserver.Credentials = new System.Net.NetworkCredential("sonimonish01@gmail.com", "m@27081995");
                smtpserver.EnableSsl = true;
                smtpserver.Send(mail);
            }
            txtBox_OTP.Enabled = true;
            //else
            //{
            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Invalid Username');window.location ='Admin_Dashboard.aspx';", true);
            //}
            
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

    protected void btnGO_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [loginuser] WHERE username=@user AND OTP=@otp", conn);
            cmd.Parameters.AddWithValue("user", txtBoxUser_Forgot.Text);
            cmd.Parameters.AddWithValue("otp", txtBox_OTP.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtBoxresetPass.Enabled = true;
                //setotp(null);
                 
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