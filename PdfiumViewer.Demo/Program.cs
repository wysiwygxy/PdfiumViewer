using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PdfiumViewer.Demo
{
    static class Program
    {
		/// <summary>
		/// The main entry point for the application.
		/// change from Bluegrams' original code: inserted line 17-19 and line 24-26 to enable DPI awareness.
		/// </summary>
		[STAThread]
        static void Main()
        {
			if (Environment.OSVersion.Version.Major >= 6)
				SetProcessDPIAware();

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
		// This function is used to set the process DPI awareness to "system DPI aware"
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
