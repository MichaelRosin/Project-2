using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class ImageShare : System.Web.UI.Page
    {
        string email;
        string username;
        string UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];

            if (cookie != null)
            {
                email = cookie["email"];
                username = cookie["username"];
                UserID = cookie["UserID"];
                txtUserID.Text = UserID;
                txtUsername.Text = username;
                txtemail.Text = email;
            }
           
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];

            if (cookie != null)
            {
                txtemail.Text = cookie["email"];
                txtemail.Text = Session["email"].ToString();
                txtUsername.Text = cookie["username"];
                UserID = cookie["UserID"];
                txtUserID.Text = UserID;
                
                
            }
        }
    }
}