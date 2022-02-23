using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DienDanDemo
{
    public partial class Detail : System.Web.UI.Page
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

            string id = Request.QueryString["id"].ToString();
            if (string.IsNullOrEmpty(id))
            {
                Response.Write("File not found");
                return ;
            }
            string query = "SELECT [dbo].[Blog].[id] " +
                                      ",[content] " +
                                      ",[user_id] " +
                                      ",[username] " +
                                  "FROM[dbo].[Blog] " +
                                  "INNER JOIN[dbo].[User] on[dbo].[User].id = [dbo].[Blog].[user_id] " +
                                  "WHERE [dbo].[Blog].[id] = " + id;

            SqlConnection conn = new SqlConnection(ConnectString.constr);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                content.InnerHtml += row["username"] + " - " + row["content"];
            }
        }
    }
}