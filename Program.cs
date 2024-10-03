using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cognex;
using Cognex.Vision;
using Hitachi_Astemo.Models;

namespace Hitachi_Astemo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cognex.Vision.Startup.Initialize(Startup.ProductKey.VProX);
            Control.CheckForIllegalCrossThreadCalls = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ToolEdit("aaa"));
        }
    }
}
