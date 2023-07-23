using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        calci.Calculator obj = new calci.Calculator();
        int a = int.Parse(txtBox_a.Text);
        int b = int.Parse(txtbox_b.Text);
        Lbl_Answer.Text = obj.Add(a, b).ToString();
        
    }

    protected void Btn_Sub_Click(object sender, EventArgs e)
    {
        calci.Calculator obj = new calci.Calculator();
        int a = int.Parse(txtBox_a.Text);
        int b = int.Parse(txtbox_b.Text);
        Lbl_Answer.Text = obj.Subtract(a, b).ToString();
    }

    protected void Btn_Mul_Click(object sender, EventArgs e)
    {
        calci.Calculator obj = new calci.Calculator();
        int a = int.Parse(txtBox_a.Text);
        int b = int.Parse(txtbox_b.Text);
        Lbl_Answer.Text = obj.Multiply(a, b).ToString();
    }

    protected void Btn_Divide_Click(object sender, EventArgs e)
    {
        calci.Calculator obj = new calci.Calculator();
        int a = int.Parse(txtBox_a.Text);
        int b = int.Parse(txtbox_b.Text);
        Lbl_Answer.Text = obj.Divide(a, b).ToString();
    }
}