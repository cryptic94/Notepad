//Description: This form allows the user to input a string to find in the textbox.
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
	public partial class Find : Form
	{
		//Class constructor
		public Find(Notepad nt)
		{
			InitializeComponent();
			note = nt;
		}

		#region Class Properties
		private readonly Notepad note;
		private string textToFind;
		private bool check = false;
		private bool searchDown = true;
		private int selectionStart;
		private int selectionEnd;
		private int index;
		private string textInBox;

		public string TextToFind { get { return textToFind; } set { textToFind = value; } }
		public string TextInBox { get { return textInBox; } set { textInBox = value; } }
		public bool Check { get { return check; } set { check = value; } }
		public bool SearchDown { get { return searchDown; } set { searchDown = value; } }
		public int SelectionStart { get { return selectionStart; } set { selectionStart = value; } }
		public int SelectionEnd { get { return selectionEnd; } set { selectionEnd = value; } }
		public int Index { get { return index; } set { index = value; } }
		#endregion

		//Gets text from the Notepad
		public void GetText(string text)
		{
			textInBox = text;
		}

		#region Button Events
		//Stores inputed text and calls the search method
		private void btFind_Click(object sender, EventArgs e)
		{
			TextToFind = txtFind.Text; SearchText();
		}
		//Closes form
		private void btCancelFind_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		#region Checkbox & Radio Button Events
		//Sets the value of the bool check
		private void chkCase_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCase.Checked)
				Check = true;
			else
				Check = false;
		}
		//Determines the search direction
		private void rbUp_CheckedChanged(object sender, EventArgs e)
		{
			if (rbUp.Checked)
				SearchDown = false;
			else
				SearchDown = true;
		}
		//Determines the search direction
		private void rbDown_CheckedChanged(object sender, EventArgs e)
		{
			if (rbDown.Checked)
				SearchDown = true;
			else
				SearchDown = false;
		}
		#endregion

		//Method to search text according to direction and case
		public void SearchText()
		{
			var stringCompare = Check ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

			if (SearchDown)
			{
				Index = TextInBox.IndexOf(TextToFind, SelectionEnd, stringCompare);
			}
			else
			{
				if(SelectionStart - 1 != -1)
					Index = TextInBox.LastIndexOf(TextToFind, SelectionStart - 1,stringCompare);
				else
					MessageBox.Show("Cannot find \"" + TextToFind + "\".", "Notepad#");
			}

			if (Index == -1)
			{
				MessageBox.Show("Cannot find \"" + TextToFind + "\".", "Notepad#");
			}
			else
			{
				SelectionStart = Index;
				SelectionEnd = Index + TextToFind.Length;
				note.rtbInput.SelectionStart = Index;
				note.rtbInput.SelectionLength = TextToFind.Length;
				note.rtbInput.Focus();
				base.Show();
			}
		}
		//Event when form closes
		private void Find_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			TextToFind = "";
			Check = false;
			SearchDown = true;
			SelectionStart = note.rtbInput.TextLength;
			SelectionEnd = 0;
			Index = 0;
			TextInBox = "";
			Hide();
		}
		//Enables button only when there is an input
		private void txtFind_TextChanged(object sender, EventArgs e)
		{
			if (txtFind.TextLength != 0)
				btFindNext.Enabled = true;
			else
				btFindNext.Enabled = false;
		}
	}
}
