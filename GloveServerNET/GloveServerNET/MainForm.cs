using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.GlyphRecognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloveServerNET
{
    public partial class Main : Form
    {

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        // create glyph recognizer for 5x5 glyphs
        private GlyphRecognizer recognizer;
        // create glyph database for 5x5 glyphs
        private GlyphDatabase glyphDatabase;
        private GlyphTracker glyphTracker;

        private float aZ, aX;

        public Main()
        {
            InitializeComponent();

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cbCam.Items.Add(Device.Name);
            }
            cbCam.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            glyphDatabase = new GlyphDatabase(5);
            glyphDatabase.Add(new Glyph("Fly", new byte[5, 5] {
                                { 0, 0, 0, 0, 0 },
                                { 0, 1, 0, 0, 0 },
                                { 0, 0, 1, 0, 0 },
                                { 0, 1, 0, 1, 0 },
                                { 0, 0, 0, 0, 0 } }));
            recognizer = new GlyphRecognizer(glyphDatabase);
            glyphTracker = new GlyphTracker();
            glyphTracker.GlyphSize = 70;

            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                tbIP.Text = endPoint.Address.ToString();
                tbPort.Text = "8333";
            }

            cbModels.SelectedIndex = 0;
            cbCamModes.SelectedIndex = 0;

            Program.IsRun = true;

            TextBox.CheckForIllegalCrossThreadCalls = false;

            Thread mythread = new Thread(Update);
            mythread.Start();
        }

        private static void Update()
        {
            do
            {
                if (!Program.glove.isOpened())
                {
                    Program.glove.Init();
                    Program.mainForm.GetTBGloveStatus().Text = "Opened: " + Program.glove.isOpened() +
                        ", name: " + Program.glove.GetGloveFullName();
                }
                else
                {
                    String fingers = "";

                    foreach (float f in Program.glove.GetSensors())
                    {
                        fingers += Math.Round(f, 1) + "-";
                    }

                    Program.mainForm.GetTBFingers().Text = fingers.Substring(0, fingers.Length - 1);
                }

                if (Program.glove.isOpened())
                    System.Threading.Thread.Sleep(40);
                else
                    System.Threading.Thread.Sleep(1000);
            } while (Program.IsRun);
        }
        
        public String GetStateAsJSON()
        {
            return "{\"CamsMode\": \"" + cbCamModes.SelectedItem + "\","
                    + "\"Model\": \"" + cbModels.SelectedItem + "\","
                    + "\"Lattice\": " + (cbLattice.Checked ? 1 : 0) + ","
                    + "\"Rot\": " + (cbAutoRot.Checked ? 1 : 0) + ","
                    + "\"Transparency\": " + ((float)trackBar.Value/(float)trackBar.Maximum).ToString().Replace(',', '.') + ","
                    + "\"FINGERS\": " + GetMidOFFingers().ToString().Replace(',', '.') + ","
                    + "\"VAR\": " + aX.ToString().Replace(',', '.') + ","
                    + "\"HAR\": " + aZ.ToString().Replace(',', '.') + "}";
        }

        private float GetMidOFFingers()
        {
            float sum = 0;

            foreach (float f in Program.glove.GetSensors())
            {
                sum += f;
            }

            return sum / 5;
        }

        public TextBox GetTBGloveStatus()
        {
            return this.tbGloveStatus;
        }

        public TextBox GetTBFingers()
        {
            return this.tbFingers;
        }

        private void cbLattice_CheckedChanged(object sender, EventArgs e)
        {
            trackBar.Enabled = cbLattice.Checked;
        }

        private void cbAutoRot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbIP.Enabled = false;
            tbPort.Enabled = false;
            btnStop.Enabled = true;
            btnStart.Enabled = false;

            Program.server.RunServer(tbIP.Text, tbPort.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            tbIP.Enabled = true;
            tbPort.Enabled = true;
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            Program.IsRun = false;
            Program.server.StopServer();

            if (FinalFrame.IsRunning)
            {
                FinalFrame.Stop();
            }
            
        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbCam.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            btnStartCam.Enabled = false;
            FinalFrame.Start();
        }

         void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbVideo.Image = (Bitmap)eventArgs.Frame.Clone();

            // process an image and find glyphs in it
            List<ExtractedGlyphData> glyphs = recognizer.FindGlyphs((Bitmap)eventArgs.Frame.Clone());
            glyphTracker.TrackGlyphs(glyphs);

            String str = "";
            // process all found glyphs
            foreach (ExtractedGlyphData glyphData in glyphs)
            {
                float[] matrixTr = glyphData.TransformationMatrix.ToArray();
                // Для x
                float cosX = matrixTr[5];
                float sinX = matrixTr[6];
                // Для y
                float cosY = matrixTr[0];
                float sinY = -matrixTr[2];
                // Для z
                float cosZ = matrixTr[0];
                float sinZ = matrixTr[1];

                aZ = (float)(cosZ < 0 ? Math.Asin(sinZ) + Math.PI / 2 : Math.Asin(sinZ));
                aX = (float)(cosX < 0 ? -Math.Asin(sinX) + Math.PI : Math.Asin(sinX));

                tbAngles.Text = "(" + Math.Round(aZ, 2) + ", " + Math.Round(aX, 2) + ")";

                str += "X: " + RadianToDegree(cosX < 0? -Math.Asin(sinX) + Math.PI : Math.Asin(sinX)) + Environment.NewLine +
                        "Y: " + RadianToDegree(cosY < 0? Math.Asin(sinY) + Math.PI / 2 : Math.Asin(sinY)) + Environment.NewLine +
                        "Z: " + RadianToDegree(cosZ < 0 ? Math.Asin(sinZ) + Math.PI / 2 : Math.Asin(sinZ));
                
            }
            if (str!="")
            tbMatrix.Text = str;
        }

         private double DegreeToRadian(double angle)
         {
             return Math.PI * angle / 180.0;
         }

         private double RadianToDegree(double angle)
         {
             return angle * (180.0 / Math.PI);
         }
    }
}
