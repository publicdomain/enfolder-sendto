
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Enfolder;

namespace EnfolderSendTo
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // Set application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check arguments for context menu start
            if (args.Length > 0)
            {
                // By the system
                Application.Run(new EnfolderForm(new List<string>(args)));
            }
            else // By user
            {
                // Run main form
                Application.Run(new MainForm());
            }
        }

    }
}
