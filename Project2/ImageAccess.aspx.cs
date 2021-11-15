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
    public partial class ImageAccess : System.Web.UI.Page
    {

        string constr = @"Server = tcp:323projectserver.database.windows.net,1433;Initial Catalog = Users; Persist Security Info=False;User ID = projectadmin; Password=Slimkop21%; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        public SqlConnection con;
        public DataSet ds;
        int Update;
        string sql;
        string ImageTitle;
        int SelectedimageID;
        string CameraType;
        string ImageLocation;
        public SqlDataAdapter sda;
        public SqlDataAdapter adapter;
        protected void Page_Load(object sender, EventArgs e)
        {
            
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
                lblImageTitle.Text = ImageTitle;
                con.Close();

                con.Open();
                sql = "SELECT CameraType FROM Metadata WHERE ImageID = '" + ImgID + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                CameraType = (string)com.ExecuteScalar();
                lblCameraType.Text = CameraType;
                con.Close();

                con.Open();
                sql = "SELECT Location_Of_Image FROM Metadata WHERE ImageID = '" + ImgID + "'";
                com = new SqlCommand(sql, con);
                sda.SelectCommand = com;
                ImageLocation = (string)com.ExecuteScalar();
                lblLocation.Text = ImageLocation;
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Photo doesn't exist...')</script>" + ex.Message);
            }
        }

        private void ViewDataGrid()
        {
            con = new SqlConnection(constr);
            sda = new SqlDataAdapter();
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM IMAGES WHERE UserID='" + txtUserID.Text + "'", con);
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


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedimageID = Int32.Parse(GridView1.SelectedRow.Cells[1].Text);
            ViewPhoto(SelectedimageID);
            ViewMetaData(SelectedimageID);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd;
                con = new SqlConnection(constr);
                sda = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();
                sql = @"SELECT * FROM UserAccess WHERE UserID='" + txtUserID.Text + "'";
                cmd = new SqlCommand(sql, con);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Users");
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ViewDataGrid();

                }
                //Insert new user
                else
                {

                    Response.Write("<script>alert('User doesn't have access...')</script>");


                }
            }
            catch
            {
                Response.Write("<script>alert('Error...')</script>");
            }

                ViewDataGrid();
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
                sql = "UPDATE Metadata SET CameraType = '" + txtCamera.Text + "' ,Location_Of_Image = '" + txtLocation.Text + "'  WHERE ImageID ='" + Update + "'";
                comm = new SqlCommand(sql, con);
                sda.SelectCommand = comm;
                comm.ExecuteNonQuery();
                con.Close();

            }

            catch
            {
                Response.Write("<script>alert('Photo doesn't exist...')</script>");
            }
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
                string view_Image = @"DELETE FROM Metadata WHERE ImageTitle='" + txtImageTitle.Text + "'";
                comm = new SqlCommand(view_Image, con);
                comm.ExecuteNonQuery();
                con.Close();
            }

            catch
            {
                Response.Write("<script>alert('Photo doesn't exist...')</script>");
            }
        }
    }
}