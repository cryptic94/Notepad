//Description: This form will let the user input a text to be replaced in the Notepad.
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
	public partial class Replace : Form
	{
		//Class constructor
		public Replace(Notepad nt)
		{
			InitializeComponent();
			note = nt;
		}

		#region Class Properties and Fields
		private readonly Notepad note;
		private string textToFind;
		private string textToReplace;
		private bool check = false;
		private int selectionEnd;
		private int index;
		private string textInBox;

		public string TextToFind { get { return textToFind; } set { textToFind = value; } }
		public string TextToReplace { get { return textToReplace; } set { textToReplace = value; } }
		public string TextInBox { get { return textInBox; } set { textInBox = value; } }
		public bool Check { get { return check; } set { check = value; } }
		public int SelectionEnd { get { return selectionEnd; } set { selectionEnd = value; } }
		public int Index { get { return index; } set { index = value; } }
		#endregion

		//Gets the text from the rich text box
		public void GetText(string text)
		{
			TextInBox = text;
		}
		//Only hides form when closed
		private void Replace_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			SelectionEnd = 0;
			TextToFind = "";
			TextToReplace = "";
			Check = false;
			Index = 0;
			TextInBox = "";
			Hide();
		}

		#region Button Events
		//Triggers form closing event
		private void btCancelRep_Click(object sender, EventArgs e)
		{
			Close();
		}
		//Calls the replace all text method
		private void btRepAll_Click(object sender, EventArgs e)
		{
			TextToFind = txtFind.Text; TextToReplace = txtReplace.Text; ReplaceAllText();
		}
		//Calls the replace text method
		private void btReplace_Click(object sender, EventArgs e)
		{
			TextToFind = txtFind.Text; TextToReplace = txtReplace.Text; ReplaceText();
		}
		//Calls the search text method
		private void btFind_Click(object sender, EventArgs e)
		{
			TextToFind = txtFind.Text; SearchText();
		}
		#endregion

		//Changes the value of the bool check
		private void chkCase_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCase.Checked)
				Check = true;
			else
				Check = false;
		}

		#region Textbox Events
		//Enables find button when textbox is not empty
		private void txtFind_TextChanged(object sender, EventArgs e)
		{
			if (txtFind.TextLength != 0)
				btFind.Enabled = true;
			else
				btFind.Enabled = false;
		}
		//Enables replace buttons when textbox is not empty
		private void txtReplace_TextChanged(object sender, EventArgs e)
		{
			if(txtReplace.TextLength !=0)
			{ btReplace.Enabled = true; btRepAll.Enabled = true; }
			else
			{ btReplace.Enabled = false; btRepAll.Enabled = false; }
		}
		#endregion

		#region Method for Text Replacement
		//Searches for the text in the file
		public void SearchText()
		{
			//Comparison culture
			var stringCompare = Check ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

			Index = TextInBox.IndexOf(TextToFind, SelectionEnd, stringCompare);

			if (Index == -1)
			{
				MessageBox.Show("Cannot find \"" + TextToFind + "\".", "Notepad#");
			}
			else
			{
				SelectionEnd = Index + TextToFind.Length;
				note.rtbInput.SelectionStart = Index;
				note.rtbInput.SelectionLength = TextToFind.Length;
				note.rtbInput.Focus();
				base.Show();
			}
		}
		//Replaces currently selected text
		private void ReplaceText()
		{
			SearchText();
			note.rtbInput.SelectedText = note.rtbInput.SelectedText.Replace(TextToFind, TextToReplace);
			TextInBox = note.rtbInput.Text;
			base.Show();
		}
		//Replaces all occurences of selected text
		private void ReplaceAllText()
		{
			var stringCompare = Check ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

			Index = TextInBox.IndexOf(TextToFind, SelectionEnd, stringCompare);

			if (Index == -1)
			{
				MessageBox.Show("Cannot find \"" + TextToFind + "\".", "Notepad#");
			}
			else
			{
				note.rtbInput.Text = note.rtbInput.Text.Replace(TextToFind, TextToReplace);
				MessageBox.Show("All occurences replaced successfully.", "Notepad#");
				TextInBox = note.rtbInput.Text;
				base.Show();
			}
		}
		#endregion
	}
}
