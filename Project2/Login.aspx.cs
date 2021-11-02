using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project2
{
    public partial class Login : System.Web.UI.Page
    {
        string email;
        string password;
        string username;
        string sql;
        string userID;
        string constr = @"Server = tcp:323projectserver.database.windows.net,1433;Initial Catalog = Users; Persist Security Info=False;User ID = projectadmin; Password=Slimkop21%; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        public SqlConnection con;
        public DataSet ds;
        public SqlDataAdapter sda;
    protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                userID = @"SELECT UserID FROM Users WHERE Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'";
                cmd1 = new SqlCommand(sql, con);
       
                sda.SelectCommand = cmd1;
                sda.Fill(ds, "Users");
                con.Close();

                email = txtemail.Text;
                password = txtpassword.Text;
                username = txtusername.Text;

                HttpCookie cookie = new HttpCookie("UserInfo");
                cookie["email"] = txtemail.Text;
                cookie["username"] = txtusername.Text;
                cookie["UserID"] = userID;
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error...')</script>" + ex.Message);
            }
        

            int counter = 2;
            try
            {
               



                SqlCommand cmd;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                sql = @"SELECT * FROM Users WHERE Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'";
                cmd = new SqlCommand(sql, con);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Users");
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Response.Redirect("ImageShare.aspx");
                    Response.Write("<script>alert('Successfully loged in')</script>");

                }
                else
                {
                    con = new SqlConnection(constr);
                    con.Open();
                    SqlCommand comm;
                    string insert_query = @"INSERT INTO Users VALUES(@UserID,@Username, @Password, @emailAddress)";
                    comm = new SqlCommand(insert_query, con);
                    comm.Parameters.AddWithValue("@UserID", counter);
                    counter++;
                    comm.Parameters.AddWithValue("@Username", txtusername.Text);
                    comm.Parameters.AddWithValue("@Password",txtpassword.Text);
                    comm.Parameters.AddWithValue("@emailAddress", txtemail.Text);
                    comm.ExecuteNonQuery();
                    con.Close();
                  
                }
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                userID = @"SELECT UserID FROM Users WHERE Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'";
                cmd = new SqlCommand(sql, con);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Users");
                con.Close();
                email = txtemail.Text;
                password = txtpassword.Text;
                username = txtusername.Text;

           
                
            



            }
          catch (Exception ex)
           {
               Response.Write("<script>alert('Error...')</script>" + ex.Message);
           }

         
        }

        protected void btnAccess_Click(object sender, EventArgs e)
        {
            Response.Redirect("ImageAccess.aspx");
        }
    }
}