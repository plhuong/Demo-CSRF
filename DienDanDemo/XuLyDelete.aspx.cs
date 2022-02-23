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
    public partial class XuLyDelete : System.Web.UI.Page
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

            string id = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(id))
            {
                string query = "SELECT [user_id] FROM [dbo].[Blog] WHERE [id] = " + id;
                SqlConnection conn = new SqlConnection(ConnectString.constr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    int blogUserId = (int)dt.Rows[0]["user_id"];
                    if(blogUserId.ToString().Equals(userId))
                    {
                        string deleteQuery = "DELETE FROM [dbo].[Blog] WHERE id = " + id;
                        cmd.CommandText = deleteQuery;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Response.Redirect("Blog.aspx");
                    }
                    else
                    {
                        Response.Write("No permission");
                        return;
                    }
                }
            }
            Response.Write("No permission");
        }
    }
}