using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DienDanDemo
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = null;

            HttpCookie reqCookies = Request.Cookies["userInfo"];
            if (reqCookies != null)
            {
                userName = reqCookies["userName"].ToString();
                if (userName == null)
                {
                    Response.Redirect("Login.aspx");
                    return;
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
                return;
            }

            hello_user.InnerHtml = "Xin chào <b>" + userName + "</b>";
        }
    }
}