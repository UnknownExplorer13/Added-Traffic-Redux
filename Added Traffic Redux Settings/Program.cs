using System;
using System.Drawing;
using System.Windows.Forms;
using Added_Traffic_Redux_Settings.Forms;

namespace Added_Traffic_Redux_Settings
{
	internal class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]

		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmSettings());
		}
	}
}