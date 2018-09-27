/*
 * Created by SharpDevelop.
 * User: Michel Gutardo Ramos de Lima
 * Date: 01/11/2017
 * Time: 17:38
 */
using System;
using System.Windows.Forms;

namespace PagerLRS
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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmNotification());
		}
		
	}
}
