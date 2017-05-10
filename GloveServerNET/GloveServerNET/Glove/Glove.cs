using FDTGloveUltraCSharpWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveServerNET
{
    public class Glove
    {
        public CfdGlove fdGlove;
        private string GloveLocation = "USB0";
        private string GloveName = "";
        private string GloveHand = "";
        private string GloveFilmwareVersion = "";

        public Glove()
        {

        }

        public void Init()
        {
            this.fdGlove = new CfdGlove();
            // chkUseCallback.Checked = false; // Update by callback from glove
            this.fdGlove.Open(GloveLocation); // Connect to glove
            // timer.Enabled = true; // Update by timer

            this.GloveName = this.GetGloveFullName();
            this.GloveHand = this.GetGloveHand();
            this.GloveFilmwareVersion = this.GetGloveFilmwareVersion();
        }

        public bool isOpened()
        {
            if (fdGlove != null)
            {
                return fdGlove.IsOpen();
            }
            else
            {
                return false;
            }
        }

        // Get Glove full name
        public string GetGloveFullName()
        {
            // Get Glove full name
            if (this.GloveName == "")
            {
                switch (fdGlove.GetGloveType())
                {
                    case (int)EGloveTypes.FD_GLOVE14UW: return "Data Glove 14 Ultra Wireless";
                    case (int)EGloveTypes.FD_GLOVE14U_USB: return "Data Glove 14 Ultra USB";
                    case (int)EGloveTypes.FD_GLOVE14U: return "Data Glove 14 Ultra";
                    case (int)EGloveTypes.FD_GLOVE16: return "Data Glove 16-sensor";
                    case (int)EGloveTypes.FD_GLOVE16W: return "Data Glove 16-sensor Wireless";
                    case (int)EGloveTypes.FD_GLOVE5U: return "Data Glove 5 Ultra";
                    case (int)EGloveTypes.FD_GLOVE5U_USB: return "Data Glove 5 Ultra USB";
                    case (int)EGloveTypes.FD_GLOVE5UW: return "Data Glove 5 Ultra Wireless";
                    case (int)EGloveTypes.FD_GLOVE7: return "Data Glove 7-sensor";
                    case (int)EGloveTypes.FD_GLOVE7W: return "Data Glove 7-sensor Wireless";
                    case (int)EGloveTypes.FD_GLOVENONE: return "No Glove";
                    default: return "Unknown";
                }
            }
            else
            {
                return this.GloveName;
            }
        }

        // Get Glove hand (right or left)
        public string GetGloveHand()
        {
            if (this.GloveHand == "")
            {
                switch (fdGlove.GetGloveHand())
                {
                    case (int)EGloveHand.FD_HAND_RIGHT: return "Right";
                    case (int)EGloveHand.FD_HAND_LEFT: return "Left";
                    default: return "Unknown";
                }
            }
            else
            {
                return this.GloveHand;
            }
        }

        // Get Glove filmware version
        public string GetGloveFilmwareVersion()
        {
            if (this.GloveFilmwareVersion == "")
            {
                return fdGlove.fdGetFWVersionMajor() + "." + fdGlove.fdGetFWVersionMinor();
            }
            else
            {
                return this.GloveFilmwareVersion;
            }
        }

        // Close Glove
        public void Close()
        {
            if (fdGlove != null) fdGlove.Close();
        }

        // Sensors data
        public float[] GetSensors()
        {
            float[] sensor = new float[5];

            if (this.fdGlove.IsOpen())
            {

                sensor[0] = fdGlove.GetSensorScaled(0);
                sensor[1] = fdGlove.GetSensorScaled(3);
                sensor[2] = fdGlove.GetSensorScaled(6);
                sensor[3] = fdGlove.GetSensorScaled(9);
                sensor[4] = fdGlove.GetSensorScaled(12);
            }

            return sensor;
        }

        public void SetCallBack(EventHandler eh)
        {
            fdGlove.SetCallBack(eh);
        }

        public void RemoveCallBack(EventHandler eh)
        {
            fdGlove.RemoveCallBack(eh);
        }
    }
}
