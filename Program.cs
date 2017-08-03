/*
Name: Montero, Anne Mariel B.
Date: July 31, 2017
Description: This program will emulate windows Notepad with additional features.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_MonteroAMB_Notepad
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Notepad());
		}
	}
}
