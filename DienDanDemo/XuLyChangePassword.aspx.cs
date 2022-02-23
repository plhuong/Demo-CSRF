using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DienDanDemo
{
    public partial class XuLyChangePassword : System.Web.UI.Page
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
                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userId))
                {
                    hello_user.InnerHtml = "Xin chào <b>" + userName + "</b>";

                    string password = Request.QueryString["password"];
                    string cfpassword = Request.QueryString["cfpassword"];
                    if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(cfpassword) && password.Equals(cfpassword))
                    {
                        string query = @"UPDATE [dbo].[User] " +
                                                "SET [password] = '" + password + "'" +
                                                " WHERE [username] like '" + userName + "'";
                        SqlConnection conn = new SqlConnection(ConnectString.constr);
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = query;
                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i != 0)
                        {
                            result_text.InnerText = "Đổi mật khẩu thành công";
                            return;
                        }
                    }
                    result_text.InnerText = "Đổi mật khẩu thất bại";
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}