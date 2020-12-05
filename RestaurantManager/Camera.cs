using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;

namespace RestaurantManager
{
    public delegate void updatePic(bool topmost);
    public partial class Camera : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;
        private VideoCapabilities[] snapshotCapabilities;
        int employeeID;
       
        public event updatePic updatePic;
        public Camera()
        {
            InitializeComponent();
        }
        public Camera(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                videoDevice = new VideoCaptureDevice(videoDevices[cmbCamera.SelectedIndex].MonikerString);
                GetDeviceResolution(videoDevice);
            }
        }

        private void cmbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[cmbResolution.SelectedIndex];

                    vispShoot.VideoSource = videoDevice;
                    vispShoot.Start();
                    EnableControlStatus(false);
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();
            picbPreview.Image = img;
        }

        private void Camera_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    cmbCamera.Items.Add(device.Name);
                }
            }
            else
            {
                cmbCamera.Items.Add("没有找到摄像头");
            }

            cmbCamera.SelectedIndex = 0;
        }

        private void GetDeviceResolution(VideoCaptureDevice videoCaptureDevice)
        {
            cmbResolution.Items.Clear();
            videoCapabilities = videoCaptureDevice.VideoCapabilities;
            foreach (VideoCapabilities capabilty in videoCapabilities)
            {
                cmbResolution.Items.Add($"{capabilty.FrameSize.Width} x {capabilty.FrameSize.Height}");
            }
            cmbResolution.SelectedIndex = 0;
        }
        private void EnableControlStatus(bool status)
        {
            cmbCamera.Enabled = status;
            cmbResolution.Enabled = status;
            btnConnect.Enabled = status;
            btnShoot.Enabled = !status;
            //    btnDisconnect.Enabled = !status;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = GetImageBytes(picbPreview.Image);
         //   string strcon = "Data Source=.;Initial Catalog=TestDB;Integrated Security=True";
            using (MySqlConnection conn = new MySqlConnection(MySQLConnection1.SqlCon))
            {
               
                string UpdateSql = "update staff_info" +
                      " set pic = @ImgData" +                    
                      " where id = '" + employeeID + "'";
             //   string sql = "Insert Into picTest Values (@ImgData) "; 

                using (MySqlCommand cmd = new MySqlCommand(UpdateSql))
                {
                    MySqlParameter param = new MySqlParameter("ImgData", MySqlDbType.VarBinary, imageBytes.Length);
                    param.Value = imageBytes;
                    cmd.Parameters.Add(param);
                    cmd.Connection = conn;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show("success!");
                }
            }
            this.Close();
            updatePic(true);//执行委托实例


        }

        private byte[] GetImageBytes(Image image)
        {
            MemoryStream mstream = new MemoryStream();
            image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byteData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byteData, 0, byteData.Length);
            mstream.Close();
            return byteData;
        }
    }
}
