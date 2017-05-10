using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloveServerNET
{
    static class Program
    {

        public static Main mainForm;
        public static Glove glove;
        public static Server server;

        public static bool IsRun { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            server = new Server();
            glove = new Glove();
            mainForm = new Main();

            Application.Run(mainForm);
        }
    }
}
