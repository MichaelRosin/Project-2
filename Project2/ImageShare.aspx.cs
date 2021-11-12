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
        public SqlDataAdapter adapter;
        string email;
        string username;
        string UserID;
        bool imageInserted = false;
        bool DataInserted = false;
        string sql;
        int imageID;
        int SelectedimageID;
        string ImageTitle;
        int delete_member;
        int Update;
        string CameraType;
        string ImageLocation;
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
        }

        private void ViewDataGrid()
        {
            con = new SqlConnection(constr);
            sda = new SqlDataAdapter();
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM IMAGES WHERE UserID='" + lblUserID.Text + "'", con);
            SqlDataReader dr = comm.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void ViewPhoto(int ImageID)
        {


            try
            {
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT Image FROM IMAGES WHERE ImageID= @ImageID", con);
                comm.Parameters.AddWithValue("@ImageID", ImageID);
                byte[] bytes = (byte[])comm.ExecuteScalar();
                string strBase64 = Convert.ToBase64String(bytes);
                imgDisplay.ImageUrl = "data:Image/png;base64," + strBase64;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
                comm.ExecuteNonQuery();
                con.Close();
               imgDisplay.Visible = true;
           } 
              catch (Exception ex)
           {
                Response.Write("<script>alert('Error...')</script>" + ex.Message);
           }

           



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
                txtDelete.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                
                
            }
            txtDelete.Visible = false;
            imgDisplay.Visible = true;
            lblCamera.Visible = true;
            lblImageTile.Visible = true;
            lblLocation.Visible = true;
            lblTitleData.Visible = true;
            btnInsertData.Visible = true;
            txtCameraType.Visible = true;
            txtImageLocation.Visible = true;
            txtImageTitle.Visible = true;
            txtDelete.Visible = false;
            
            btnUpdate.Visible = true;
            lblDeleteTitle.Visible = true;
            lblSearchTitle.Visible = true;
            txtDelete.Visible = true;
            lblViewTitle.Visible = true;
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
            btnDeleteData.Visible = true;
            GridView1.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lblMTitle.Visible = true;
            lblCType.Visible = true;
            lblLImage.Visible = true;
            txtuserAccess.Visible = true;
            btnPermission.Visible = true;
            lblUserAccess.Visible = true;



            ViewDataGrid();
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
            }
        }

        protected void txtView_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
           try
           {
                SqlCommand comm;
                con = new SqlConnection(constr);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                string view_Image = @"DELETE FROM Metadata WHERE ImageTitle='" + txtDelete.Text + "'";
                comm = new SqlCommand(view_Image, con);
                comm.ExecuteNonQuery();
                con.Close();

    
                sda = new SqlDataAdapter();
                con.Open();
                sql = "SELECT ImageID FROM Metadata WHERE ImageTitle='" + txtDelete.Text + "'";
                comm = new SqlCommand(sql, con);
                sda.SelectCommand = comm;
                delete_member = (int)comm.ExecuteScalar();
                con.Close();

                con.Open();
                string delete_image = @"DELETE FROM Images WHERE ImageID='" + delete_member + "'";
                comm = new SqlCommand(view_Image, con);
                comm.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Photo and metadata deleted')</script>");

            }

            catch (Exception ex)
             {
             Response.Write("<script>alert('Photo doesn't exist...')</script>" + ex.Message);
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
        
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                SqlCommand comm;
                sda = new SqlDataAdapter();
                con.Open();
                sql = "SELECT ImageID FROM Metadata WHERE ImageTitle='" + txtImageTitle.Text + "'";
                comm = new SqlCommand(sql, con);
                sda.SelectCommand = comm;
                Update = (int)comm.ExecuteScalar();
                con.Close();


                con = new SqlConnection(constr);
                con.Open();
                sda = new SqlDataAdapter();
                sql = "UPDATE Metadata SET CameraType = '" + txtCameraType.Text + "' ,Location_Of_Image = '" + txtImageLocation.Text + "'  WHERE ImageID ='" + Update+ "'";
                comm = new SqlCommand(sql, con);
                sda.SelectCommand = comm;
                comm.ExecuteNonQuery();
                con.Close();

            }

            catch (Exception ex)
            {
               Response.Write("<script>alert('Photo doesn't exist...')</script>" + ex.Message);
            }
            
        }

        protected void btnViewMetadata_Click(object sender, EventArgs e)
        {
          
        }

        protected void btnDeleteData_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm;
                con = new SqlConnection(constr);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                string view_Image = @"DELETE FROM Metadata WHERE ImageTitle='" + txtImageTitle.Text + "'";
                comm = new SqlCommand(view_Image, con);
                comm.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('Photo doesn't exist...')</script>" + ex.Message);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedimageID = Int32.Parse(GridView1.SelectedRow.Cells[1].Text);
            ViewPhoto(SelectedimageID);
            ViewMetaData(SelectedimageID);

        }

        private void ViewMetaData(int ImgID)
        {
            try
            {
                SqlCommand com;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                sda = new SqlDataAdapter();

                con.Open();
                sql = "SELECT ImageTitle FROM Metadata WHERE ImageID = '" + ImgID + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                ImageTitle = (string)com.ExecuteScalar();
                lblMTitle.Text = ImageTitle;
                con.Close();

                con.Open();
                sql = "SELECT CameraType FROM Metadata WHERE ImageID = '" + ImgID + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                CameraType = (string)com.ExecuteScalar();
                lblCType.Text = CameraType;
                con.Close();

                con.Open();
                sql = "SELECT Location_Of_Image FROM Metadata WHERE ImageID = '" + ImgID + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                ImageLocation = (string)com.ExecuteScalar();
                lblLImage.Text = ImageLocation;
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Photo doesn't exist...')</script>" + ex.Message);
            }
        }

        protected void btnViewMData_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                sda = new SqlDataAdapter();
                
                con.Open();
                sql = "SELECT ImageTitle FROM Metadata WHERE ImageID = '" + SelectedimageID + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                ImageTitle = (string)com.ExecuteScalar();
                lblMTitle.Text = ImageTitle;
                con.Close();

                con.Open();
                sql = "SELECT CameraType FROM Metadata WHERE ImageID = '" + SelectedimageID + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                CameraType = (string)com.ExecuteScalar();
                lblCType.Text = CameraType;
                con.Close();

                con.Open();
                sql = "SELECT Location_Of_Image FROM Metadata WHERE ImageID = '" + SelectedimageID + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                ImageLocation = (string)com.ExecuteScalar();
                lblLImage.Text = ImageLocation;
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Photo doesn't exist...')</script>" + ex.Message);
            }
        }

        protected void btnPermission_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuserAccess.Text != "")
                {

                    con = new SqlConnection(constr);
                    SqlCommand comm;
                    sda = new SqlDataAdapter();
                    con.Open();
                    sql = "SELECT Top (1)  ImageID FROM Images";
                    comm = new SqlCommand(sql, con);
                    sda.SelectCommand = comm;
                    Update = (int)comm.ExecuteScalar();
                    con.Close();

                    con = new SqlConnection(constr);
                    con.Open();
                    string insert_query = @"INSERT INTO UserAccess VALUES(@UserID, @ImageID, @Access)";
                    comm = new SqlCommand(insert_query, con);
                    comm.Parameters.AddWithValue("@UserID", txtuserAccess.Text);
                    comm.Parameters.AddWithValue("@ImageID", Update);
                    comm.Parameters.AddWithValue("@Access", 1);
                    comm.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    Response.Write("<script>alert('Insert UserID')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('User doesn't exist...')</script>" + ex.Message);
            }
           
        }
    }
}