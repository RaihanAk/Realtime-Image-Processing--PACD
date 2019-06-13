using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using DirectShowLib;
using System.Drawing.Imaging;

/* Realtime Image Processing
 * =================================================
 * Muhammad Raihan Akbar 
 * 140810160013
 * UAS PACD -- Pengolahan dan Analisis Citra Digital
 * 12-6-2019
 */

namespace RealtimeImageProcessing
{
    /* Packages used :
     * EMGU.CV.4.1.0.3420
     * ZedGraph.5.1.7
     * DirectShowLib.1.0.0
     * 
     * Install with Project > Manage NuGet Packages...
     */
    public partial class Form1 : Form
    {
        DsDevice[] videoDevices;
        private VideoCapture grabber;
        Image<Bgr, Byte> ImageFrame, img, ret;

        public Form1()
        {
            InitializeComponent();
            videoDevices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (int i = 1, n = videoDevices.Length; i <= n; i++)
            {
                string CameraName = i + ":" + videoDevices[i - 1].Name;
                cbCamera.Items.Add(CameraName);
            }
            colorCB.SelectedIndex = 0;
            cbCamera.SelectedIndex = 0;

            /* Color settings. 
             * Source : https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.colordialog?view=netframework-4.8
             */
            colorRes1.BackColor = colorDialog1.Color;
            colorRes2.BackColor = colorDialog2.Color;
            colorResAlter.BackColor = colorDialogAlter.Color;
        }

        #region Event Systems, like onClick
        private void btStart_Click(object sender, EventArgs e)
        {
            grabber = new VideoCapture(cbCamera.SelectedIndex);
            btStop.Enabled = true;
            btStart.Enabled = false;
            Application.Idle += ProsesFrame;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            grabber.Dispose();
            btStart.Enabled = true;
            btStop.Enabled = false;
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            if (grabber != null) grabber.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void color1btn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorRes1.BackColor = colorDialog1.Color;
        }

        private void color2btn_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            colorRes2.BackColor = colorDialog2.Color;
        }

        private void colorAlterbtn_Click(object sender, EventArgs e)
        {
            colorDialogAlter.ShowDialog();
            colorResAlter.BackColor = colorDialogAlter.Color;
        }

        private void brightness_trackBar_Scroll(object sender, EventArgs e)
        {
            brightnessValue.Value = brightness_trackBar.Value;
        }

        private void brightnessValue_ValueChanged(object sender, EventArgs e)
        {
            brightness_trackBar.Value = (int)brightnessValue.Value;
        }

        private void binary_trackBar_Scroll(object sender, EventArgs e)
        {
            ThresholdValue.Value = binary_trackBar.Value;
        }

        private void ThresholdValue_ValueChanged(object sender, EventArgs e)
        {
            binary_trackBar.Value = (int)ThresholdValue.Value;
        }

        #endregion

        #region Camera Process
        private void ProsesFrame(object sender, EventArgs arg)
        {
            // Color Detection
            if (tabControl.SelectedTab == tabColorDetect)
            {
                /* Source : 
                 * http://www.emgu.com/wiki/files/2.0.0.0/html/07eff70b-f81f-6313-98a9-02d508f7c7e0.htm
                 * http://www.emgu.com/wiki/files/2.4.0/document/html/0309f41d-aa02-2c0d-767f-3d7d8ccc9212.htm
                 * https://stackoverflow.com/questions/17303512/emgu-cv-color-detection-and-replace#38651641
                 */

            if (grabber.QueryFrame() != null)
                {
                    ImageFrame = grabber.QueryFrame().ToImage<Bgr, byte>();
                    img = ImageFrame.Clone();
                    ret = img;

                    // Apparently, Emgu CV loves to use BGR format
                    var image = img.InRange(new Bgr(colorDialog1.Color), new Bgr(colorDialog2.Color));
                    var mat = img.Mat;
                    mat.SetTo(new MCvScalar(
                        colorDialogAlter.Color.B,
                        colorDialogAlter.Color.G,
                        colorDialogAlter.Color.R), image);
                    mat.CopyTo(ret);
                }
                
                // Render
                imageBox.Image = ret;
            }


            // Image Processing
            if (tabControl.SelectedTab == tabImageProcess)
            {
                // Source : Project from Setiawan Hadi Sensei

                if (grabber.QueryFrame() != null)
                {
                    // COLOR CHANNEL
                    ImageFrame = grabber.QueryFrame().ToImage<Bgr, byte>();
                    img = ImageFrame.Clone();
                    if (rbColor.Checked)
                    {
                        if (colorCB.SelectedItem.ToString() == "R")
                            for (int v = 0; v < img.Height; v++)
                            {
                                for (int u = 0; u < img.Width; u++)
                                {
                                    img.Data[v, u, 0] = 0;
                                    img.Data[v, u, 1] = 0;
                                }
                            }
                        if (colorCB.SelectedItem.ToString() == "G")
                            for (int v = 0; v < img.Height; v++)
                            {
                                for (int u = 0; u < img.Width; u++)
                                {
                                    img.Data[v, u, 0] = 0;
                                    img.Data[v, u, 2] = 0;
                                }
                            }
                        if (colorCB.SelectedItem.ToString() == "B")
                            for (int v = 0; v < img.Height; v++)
                            {
                                for (int u = 0; u < img.Width; u++)
                                {
                                    img.Data[v, u, 1] = 0;
                                    img.Data[v, u, 2] = 0;
                                }
                            }
                    }
                }

                if (rbGrey.Checked)
                {                
                    // SET GRAY
                    for (int v = 0; v < img.Height; v++)
                    {
                        for (int u = 0; u < img.Width; u++)
                        {
                            byte b = img.Data[v, u, 0];
                            byte g = img.Data[v, u, 1];
                            byte r = img.Data[v, u, 2];
                            float hasil = ((float)b + (float)g + (float)r) / 3;
                            img.Data[v, u, 0] = (byte)hasil;
                            img.Data[v, u, 1] = (byte)hasil;
                            img.Data[v, u, 2] = (byte)hasil;

                        }
                    }
                }

                if (rbBinary.Checked)
                {
                    // BINARIZE
                    for (int v = 0; v < img.Height; v++)
                    {
                        for (int u = 0; u < img.Width; u++)
                        {
                            byte b = img.Data[v, u, 0];
                            byte g = img.Data[v, u, 1];
                            byte r = img.Data[v, u, 2];
                            float hasil = ((float)b + (float)g + (float)r) / 3;
                            if ((int)hasil > ThresholdValue.Value)
                            {
                                img.Data[v, u, 0] = (byte)255;
                                img.Data[v, u, 1] = (byte)255;
                                img.Data[v, u, 2] = (byte)255;
                            }
                            else
                            {
                                img.Data[v, u, 0] = (byte)0;
                                img.Data[v, u, 1] = (byte)0;
                                img.Data[v, u, 2] = (byte)0;

                            }

                        }
                    }
                }

                if (rbInvert.Checked)
                {
                    // INVERSION
                    for (int v = 0; v < img.Height; v++)
                    {
                        for (int u = 0; u < img.Width; u++)
                        {
                            byte b = img.Data[v, u, 0];
                            byte g = img.Data[v, u, 1];
                            byte r = img.Data[v, u, 2];

                            img.Data[v, u, 0] = (byte)(255 - (float)b);
                            img.Data[v, u, 1] = (byte)(255 - (float)g);
                            img.Data[v, u, 2] = (byte)(255 - (float)r);

                        }
                    }
                }

                if (rbBrightness.Checked)
                {
                    // SCALE THE BRIGHTNESS
                    float value = (float)brightnessValue.Value;
                    for (int v = 0; v < img.Height; v++)
                    {
                        for (int u = 0; u < img.Width; u++)
                        {
                            byte b = img.Data[v, u, 0];
                            byte g = img.Data[v, u, 1];
                            byte r = img.Data[v, u, 2];

                            img.Data[v, u, 0] = (byte)((b + value) > 255 ? 255 :
                                (b + value) < 0 ? 0 : (b + value));
                            img.Data[v, u, 1] = (byte)((g + value) > 255 ? 255 :
                                (g + value) < 0 ? 0 : (g + value));
                            img.Data[v, u, 2] = (byte)((r + value) > 255 ? 255 :
                                (r + value) < 0 ? 0 : (r + value));

                            /* These codes translates to : 
                             * b + value, is it > 255 ? 
                             *  if yes make the result 255,
                             *  if no
                             *   b + value, is it < 0 ?
                             *    if yes make the result 0,
                             *    if no (its between 0 - 255) set the result accordingly
                             */
                        }
                    }
                }

                // Render
                imageBox.Image = img;
            }            
        }
        #endregion

    }
}
