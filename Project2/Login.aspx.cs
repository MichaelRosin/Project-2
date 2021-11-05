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
    public partial class Login : System.Web.UI.Page
    {
        string email;
        string password;
        bool ValidInfo = false;
        bool Access = false;
        string username;
        string sql;
        int userID;
        string constr = @"Server = tcp:323projectserver.database.windows.net,1433;Initial Catalog = Users; Persist Security Info=False;User ID = projectadmin; Password=Slimkop21%; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        public SqlConnection con;
        public DataSet ds;
        public SqlDataAdapter sda;
    protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public class utils
        {   

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
            //Determine if the account already exists
            try
            {
                SqlCommand cmd;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                sql = @"SELECT * FROM Users WHERE Username='" + txtusername.Text + "' and Password='" + EncryptedString(txtpassword.Text)+ "'";
                cmd = new SqlCommand(sql, con);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Users");
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {                   
                    Response.Write("<script>alert('You alread have an account!')</script>");
                }
                //Insert new user
                else
                {                  
                    con = new SqlConnection(constr);
                    con.Open();
                    SqlCommand comm;
                    string insert_query = @"INSERT INTO Users VALUES(@Username, @Password, @emailAddress)";
                    comm = new SqlCommand(insert_query, con);       
                    comm.Parameters.AddWithValue("@Username", txtusername.Text);
                    comm.Parameters.AddWithValue("@Password", EncryptedString(txtpassword.Text));
                    comm.Parameters.AddWithValue("@emailAddress", txtemail.Text);
                    comm.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Successfully registered in')</script>");
                    ValidInfo = true;
                    
                }
                
        }
         catch (Exception ex)
           {
               Response.Write("<script>alert('Error...')</script>" + ex.Message);
           }

            //Insert data into cookies so that the information can be pull to the next form
              try
             {
                SqlCommand com;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                sql = "SELECT UserID FROM Users WHERE Username='" + txtusername.Text + "' and Password='" + EncryptedString(txtpassword.Text) + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                userID = (int)com.ExecuteScalar();         
                email = txtemail.Text;
                password = txtpassword.Text;
                username = txtusername.Text;


                HttpCookie cookie = new HttpCookie("UserInfo");
                cookie["email"] = txtemail.Text;
                cookie["username"] = txtusername.Text;
                cookie["UserID"] = userID.ToString();
                cookie.Expires = DateTime.Now.AddSeconds(20);
                Response.Cookies.Add(cookie);
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error...')</script>" + ex.Message);
            }
            Response.Redirect("ImageShare.aspx");
        }

       protected void btnAccess_Click(object sender, EventArgs e)
        {
            /*if (ValidInfo == true && Access == true)
            {
                Response.Redirect("ImageAccess.aspx");
            }
            */
            Response.Redirect("ImageAccess.aspx");
        }
    }
}