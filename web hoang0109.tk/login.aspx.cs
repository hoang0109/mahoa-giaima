using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string _username = txt_user.Text;
        string _password = txt_pass.Text;
            if (_username=="123456" && _password=="654321")
            {
                Session["id"] = "123456";
                
                Response.Redirect("default.aspx");
            }
        else
	        {
                Response.Write("<script>alert('Đang nhập không thành công')</script>");
	        }
   
    }
}