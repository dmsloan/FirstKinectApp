using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Kinect;

//using Coding4Fun.Kinect.WinForm;
 
namespace FirstKinectApp
{
    public partial class frmKinect : Form
    {
        private KinectSensor kSensor;

        public frmKinect()
        {
            InitializeComponent();
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            if (btnStream.Text == "Stream")
            {
                if (KinectSensor.KinectSensors.Count > 0)
                {
                    this.btnStream.Text = "Stop";
                    kSensor = KinectSensor.KinectSensors[0];
                    KinectSensor.KinectSensors.StatusChanged += KinectSensors_StatusChanged;
                }

                kSensor.Start();
                this.lblConnectionID.Text = kSensor.DeviceConnectionId;
                kSensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
               kSensor.ColorFrameReady += KSensor_ColorFrameReady;
            }
            else
            {
                if (kSensor != null && kSensor.IsRunning)
                {
                    kSensor.Stop();
                    this.btnStream.Text = "Stream";
//                    //this.
                }
            }
        }

        private void KSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            using (var frame = e.OpenColorImageFrame())
            {
                if (frame != null)
                {
                    KinectStream.Image = CreateBitmapFromSensor(frame);
                }
            }
        }

        private void KinectSensors_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            this.lblStatus.Text= kSensor.Status.ToString();
        }

        private Bitmap CreateBitmapFromSensor(ColorImageFrame frame)
        {
            var pixelData = new byte[frame.PixelDataLength];
            frame.CopyPixelDataTo(pixelData);
 
            var stride = frame.Width * frame.BytesPerPixel;
            var bmpFrame = new Bitmap(frame.Width, frame.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            var bmpData = bmpFrame.LockBits(new Rectangle(0, 0, frame.Width, frame.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, bmpFrame.PixelFormat);

            System.Runtime.InteropServices.Marshal.Copy(pixelData, 0, bmpData.Scan0, frame.PixelDataLength);

            bmpFrame.UnlockBits(bmpData);
            return bmpFrame;

        }
    }
}
