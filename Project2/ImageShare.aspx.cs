using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Security;
using System.Drawing;



namespace Project2
{
    public partial class ImageShare : System.Web.UI.Page
    {
        string email;
        string username;
        string UserID;
        bool imageInserted = false;
        bool DataInserted = false;
        string sql;
        int imageID;
        string insert_query;    
        string constr = @"Server = tcp:323projectserver.database.windows.net,1433;Initial Catalog = Users; Persist Security Info=False;User ID = projectadmin; Password=Slimkop21%; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        public SqlConnection con;
        public DataSet ds;
        public SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {


            HttpCookie cookie = Request.Cookies["UserInfo"];

            if (cookie != null)
            {
                email = cookie["email"];
                username = cookie["username"];
                UserID = cookie["UserID"];
                lblUserID.Text = UserID;
                lblUsername.Text = username;
        
            }

            imgDisplay.Visible = false;
            lblCamera.Visible = false;
            lblImageTile.Visible = false;
            lblLocation.Visible = false;
            lblTitleData.Visible = false;
            btnInsertData.Visible = false;
            txtCameraType.Visible = false;
            txtImageLocation.Visible = false;
            txtImageTitle.Visible = false;
            lblDeleteTitle.Visible = false;
            lblSearchTitle.Visible = false;
            txtDelete.Visible = false;
            lblViewTitle.Visible = false;
            lblView.Visible = false;
            txtView.Visible = false;
            
            




        }

        private void ImageUpload()
        {
            
            try
            {
                HttpCookie cookie = Request.Cookies["UserInfo"];

                if (cookie != null)
                {
                    UserID = cookie["UserID"];
                    lblUserID.Text = UserID;
                }

                
                if (FileUpload1.HasFile)
                {
                    int imagesfilelenth = FileUpload1.PostedFile.ContentLength;
                    byte[] imageArray = new byte[imagesfilelenth];
                    HttpPostedFile image = FileUpload1.PostedFile;
                    image.InputStream.Read(imageArray, 0, imagesfilelenth);
                    SqlCommand cmd;
                    con = new SqlConnection(constr);
                    sda = new SqlDataAdapter();
                    ds = new DataSet();
                    con.Open();
                    insert_query = @"INSERT INTO Images VALUES(@Image, @UserID)";
                    cmd = new SqlCommand(insert_query, con);                   
                    cmd.Parameters.AddWithValue("@Image", imageArray);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    sda.SelectCommand = cmd;
                    sda.Fill(ds, "Users");
                    con.Close();
                    

                }
                imageInserted = true;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error...')</script>" + ex.Message);
            }

    
           
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {

            

        }

        protected void btnUpload_Click1(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ImageUpload();
            if (imageInserted == true)
            {
                imgDisplay.Visible = true;
                lblCamera.Visible = true;
                lblImageTile.Visible = true;
                lblLocation.Visible = true;
                lblTitleData.Visible = true;
                btnInsertData.Visible = true;
                txtCameraType.Visible = true;
                txtImageLocation.Visible = true;
                txtImageTitle.Visible = true;
                txtView.Visible = true;
                txtDelete.Visible = false;
                
            }
            txtDelete.Visible = false;

        }

        protected void btnInsertData_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                sql = "SELECT ImageID FROM Images WHERE UserID='" + lblUserID.Text + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                imageID = (int)com.ExecuteScalar();
              
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error...')</script>" + ex.Message);
            }



            try
           {
                con = new SqlConnection(constr);
                con.Open();
                SqlCommand comm;
                string insert_query = @"INSERT INTO Metadata VALUES(@ImageID, @ImageTitle, @CameraType, @Location_Of_Image)";
                comm = new SqlCommand(insert_query, con);
                comm.Parameters.AddWithValue("@ImageID", imageID);
                comm.Parameters.AddWithValue("@ImageTitle", txtImageTitle.Text);
                comm.Parameters.AddWithValue("@CameraType", txtCameraType.Text);
                comm.Parameters.AddWithValue("@Location_Of_Image", txtImageLocation.Text);
                comm.ExecuteNonQuery();
                con.Close();
                DataInserted = true;
            }
            
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error...')</script>" + ex.Message);
            }
            

            if (DataInserted == true)
            {
                lblDeleteTitle.Visible = true;
                lblSearchTitle.Visible = true;
                txtDelete.Visible = true;
                lblViewTitle.Visible = true;
                lblView.Visible = true;
                txtView.Visible = true;
                lblCamera.Visible = true;
                lblImageTile.Visible = true;
                lblLocation.Visible = true;
                lblTitleData.Visible = true;
                btnInsertData.Visible = true;
                txtCameraType.Visible = true;
                txtImageLocation.Visible = true;
                txtImageTitle.Visible = true;
                lblDeleteTitle.Visible = true;
                lblSearchTitle.Visible = true;
                txtDelete.Visible = true;
                lblViewTitle.Visible = true;
                lblView.Visible = true;
                txtView.Visible = true;
            }
        }

        protected void txtView_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm;
                con = new SqlConnection(constr);
                con.Open();             
                string view_Image = @"SELECT Image FROM Images, Metadata WHERE ImageTitle='" + txtView.Text + "'";
                comm = new SqlCommand(view_Image, con);
                sda.SelectCommand = comm;
                comm.ExecuteNonQuery();
                con.Close();
           
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('Photo doesn't exist...')</script>" + ex.Message);
            }
        }
    }
}