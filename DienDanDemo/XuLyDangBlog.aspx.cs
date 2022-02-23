using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DienDanDemo
{
    public partial class XuLyDangBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = null;
            string userId = null;

            HttpCookie reqCookies = Request.Cookies["userInfo"];
            if (reqCookies != null)
            {
                userName = reqCookies["userName"].ToString();
                userId = reqCookies["userId"].ToString();
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userId))
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

            string content = Request.QueryString["content"];
            
            if (!string.IsNullOrEmpty(content))
            {
                string query = "INSERT INTO [dbo].[Blog] " +
                               "([content] " +
                               ",[user_id]) " +
                               "VALUES " +
                               "(N'" + content + "' " +
                               "," + userId + ")";
                SqlConnection conn = new SqlConnection(ConnectString.constr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Response.Redirect("Blog.aspx");
        }
    }
}