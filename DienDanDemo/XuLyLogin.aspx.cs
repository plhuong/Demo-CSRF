using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DienDanDemo
{
    public partial class XuLyLogin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.Form["username"];
            string password = Request.Form["password"];

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                Response.Redirect("Login.aspx");
                return;
            }

            SqlConnection conn = new SqlConnection(ConnectString.constr);
            string query = "SELECT [id] FROM [dbo].[User] WHERE username like '" + userName + "' AND password like '" + password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            int i = adapter.Fill(dt);
            if(i != 0)
            {
                HttpCookie reqCookies = new HttpCookie("userInfo");
                reqCookies["userName"] = userName;
                reqCookies["userId"] = dt.Rows[0]["id"].ToString();
                reqCookies.Expires.AddDays(15);
                Response.Cookies.Add(reqCookies);
                Response.Redirect("Blog.aspx");
                return;
            }

            Response.Redirect("Login.aspx");
        }
    }
}