//Desription: This form allows the user to choose a specific line number.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_MonteroAMB_Notepad
{
	public partial class GoTo : Form
	{
		public GoTo()
		{
			InitializeComponent();
		}

		private int parsedValue = 0;

		public int ParsedValue { get { return parsedValue; } set { parsedValue = value; } }
		//Closes the form
		private void btCancelGo_Click(object sender, EventArgs e)
		{
			Close();
		}
		//Validates and stores the number entered
		private void btGo_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtLine.Text, out parsedValue))
			{
				MessageBox.Show("You can only input integers.", "Error"); return;
			}
			else
			{
				ParsedValue = int.Parse(txtLine.Text);
				Close();
			}
		}
		//Enables go to button when there is an input
		private void txtLine_TextChanged(object sender, EventArgs e)
		{
			if (txtLine.TextLength != 0)
				btGo.Enabled = true;
			else
				btGo.Enabled = false;
		}
	}
}
