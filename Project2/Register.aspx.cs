using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Project2
{
    public partial class Register : System.Web.UI.Page
    {      
        string password;
        bool ValidInfo = false;
        bool Access = false;
        string username;
        string sql;
        string SQL;
        int userID;
        string constr = @"Server = tcp:323projectserver.database.windows.net,1433;Initial Catalog = Users; Persist Security Info=False;User ID = projectadmin; Password=Slimkop21%; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        public SqlConnection con;
        public DataSet ds;
        public SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string EncryptedString(string encrString)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(encrString);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }

        public string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;

            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException fe)
            {
                decrypted = "";
            }
            return decrypted;
        }



        protected void Unnamed4_Click(object sender, EventArgs e)
        {

            //Insert data into cookies so that the information can be pull to the next form
            try
            {
                SqlCommand cmd;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                sql = "SELECT UserID FROM Users WHERE Username='" + txtusername.Text + "' and Password='" + EncryptedString(txtpassword.Text) + "'";
                cmd = new SqlCommand(sql, con);
                sda.SelectCommand = cmd;
                userID = (int)cmd.ExecuteScalar();
                con.Close();
          
                password = txtpassword.Text;
                username = txtusername.Text;

                HttpCookie cookie = new HttpCookie("UserInfo");             
                cookie["username"] = txtusername.Text;
                cookie["UserID"] = userID.ToString();
                cookie.Expires = DateTime.Now.AddSeconds(20);
                Response.Cookies.Add(cookie);

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error...')</script>" + ex.Message);
            }





            //Determine if the account already exists
            try
            {
                SqlCommand cmd;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                sql = @"SELECT * FROM Users WHERE Username='" + txtusername.Text + "' and Password='" + EncryptedString(txtpassword.Text) + "'";
                cmd = new SqlCommand(sql, con);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Users");
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Response.Redirect("ImageShare.aspx");
                                        
                }
                else
                {
                    Response.Redirect("Login.aspx");
                    Response.Write("<script>alert('You don't have an account')</script>");
                }
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                sql = @"SELECT UserID FROM Users WHERE Username='" + txtusername.Text + "' and Password='" + EncryptedString(txtpassword.Text) + "'";
                cmd = new SqlCommand(sql, con);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Users");
                con.Close();                
                password = txtpassword.Text;
                username = txtusername.Text;
                Response.Redirect("ImageShare.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error...')</script>" + ex.Message);
            }
        }
    
    }
}