//Description: This file contains the events of the Notepad.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PE_MonteroAMB_Notepad
{
	public partial class Notepad : Form
	{
		//Constructor
		public Notepad()
		{
			InitializeComponent();
			Clipboard.Clear();
			tabMenu.SelectedIndex = 1;
			//Document to be printed for print event
			document.PrintPage += new PrintPageEventHandler(document_PrintPage);
			rtbInput.Focus();
		}

		#region Class Properties and Fields
		private Find fn;
		private Replace rep;
		private string currText;
		private string fileName = "N/A";
		PrintDocument document = new PrintDocument();

		public string CurrText { get { return currText; } set { currText = value; } }
		public string FileName { get { return fileName; } set { fileName = value; } }
		#endregion

		#region Notepad# Updates and Closing
		//Confirmations when notepad closes
		private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
		{
			tabMenu.SelectedIndex = 0;
			if (rtbInput.Text.Length == 0 || CurrText == rtbInput.Text)
			{
				switch (MessageBox.Show("Are you sure?", "Notepad#", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					case DialogResult.No:
						e.Cancel = true;
						break;
					default:
						break;
				}
			}
			else
			{
				switch (MessageBox.Show("Do you want to save changes to file?", "Notepad#", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
				{
					case DialogResult.Yes:
						btSave.PerformClick();
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
					default:
						break;
				}
			}
		}
		//Notepad updates according to text changes in textbox
		private void rtbInput_TextChanged(object sender, EventArgs e)
		{
			if (rtbInput.Text.Length == rtbInput.MaxLength)
				MessageBox.Show("Cannot enter anymore characters.", "Maximum Reached");
			//Button states according to text in file
			if (rtbInput.Text.Length != 0)
			{
				btCopy.Enabled = true;
				btCut.Enabled = true;
				btUndo.Enabled = true;
				btFind.Enabled = true;
				btReplace.Enabled = true;
			}
			else
			{
				btCopy.Enabled = false;
				btCut.Enabled = false;
				btFind.Enabled = false;
				btReplace.Enabled = false;
			}
			//Button states according to clipboard data
			if (Clipboard.ContainsText())
			{
				btCopy.Enabled = false;
				btCut.Enabled = false;
				btPaste.Enabled = true;
			}
			string count = rtbInput.Text;
			tslWord.Text = String.Concat("Words: ", (count.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length).ToString());
			tslCharacter.Text = String.Concat("Characters: ", rtbInput.Text.Length);
			tslLines.Text = String.Concat("Lines: ", rtbInput.Lines.Length);
		}
		//Undo stack to store word by word for undo/redo button
		private void rtbInput_KeyDown(object sender, KeyEventArgs e)
		{
			RichTextBox rtb = sender as RichTextBox;
			if (e.KeyCode == Keys.Space)
			{
				this.SuspendLayout();
				rtb.Undo();
				rtb.Redo();
				this.ResumeLayout();
			}
			if (e.KeyCode == Keys.Enter)
				rtbInput.SelectionIndent = 0;
		}
		#endregion

		#region File Tab Buttons
		//Exits the program
		private void btExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		#region Document Settings
		//Creates a new instance of the Notepad
		private void btNew_Click(object sender, EventArgs e)
		{
			//If textbox is empty, nothing happens
			if (rtbInput.Text.Length == 0)
			{
				rtbInput.SelectionBullet = false; return;
			}
			else
			{
				//If current text is changed and current file has been saved
				if (CurrText != rtbInput.Text)
				{
					DialogResult result = MessageBox.Show("Do you want to save changes to file?", "Notepad#", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
					switch (result)
					{
						case DialogResult.Yes:
							btSave.PerformClick(); rtbInput.Text = ""; rtbInput.SelectionBullet = false; break;
						case DialogResult.Cancel:
							return; break;
						default:
							rtbInput.Text = ""; rtbInput.SelectionBullet = false; break;
					}
				}
				else
				{
					rtbInput.Text = "";
					rtbInput.SelectionBullet = false;
				}
				//Clears directory in save dialog
				FileName = "N/A";
				sfdText.FileName = "";
			}
		}
		//Opens an existing file
		private void btOpen_Click(object sender, EventArgs e)
		{
			ofdNote.FileName = "";
			DialogResult dr = ofdNote.ShowDialog();
			if (ofdNote.FileName != "" && dr == DialogResult.OK)
			{
				rtbInput.Text = File.ReadAllText(ofdNote.FileName);
			}
			sfdText.FileName = ofdNote.FileName;
			FileName = ofdNote.FileName;
			CurrText = rtbInput.Text;
		}
		//Saves the current document
		private void btSave_Click(object sender, EventArgs e)
		{
			if (FileName != sfdText.FileName)
			{
				DialogResult dr = sfdText.ShowDialog();
				if (sfdText.FileName != "" && dr == DialogResult.OK)
				{
					File.WriteAllText(sfdText.FileName, rtbInput.Text);
				}
			}
			else
			{
				File.WriteAllText(sfdText.FileName, rtbInput.Text);
			}
			CurrText = rtbInput.Text;
			if (sfdText.FileName == "")
				FileName = "N/A";
			else
				FileName = sfdText.FileName;
		}
		//Saves current document as a new file
		private void btSaveAs_Click(object sender, EventArgs e)
		{
			sfdText.FileName = "";
			DialogResult dr = sfdText.ShowDialog();
			if (sfdText.FileName != "" && dr == DialogResult.OK)
			{
				File.WriteAllText(sfdText.FileName, rtbInput.Text);
			}
			CurrText = rtbInput.Text;
			if (sfdText.FileName == "")
				FileName = "N/A";
			else
				FileName = sfdText.FileName;
		}
		#endregion

		#region Print Settings
		//Print settings for document
		void document_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawString(rtbInput.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
		}
		//Shows the print dialog and prints file when confirmed
		private void btPrint_Click(object sender, EventArgs e)
		{
			DialogResult result = pdNote.ShowDialog();
			if (result == DialogResult.OK)
			{
				pdNote.Document = document;
				document.Print();
			}
		}
		//Shows page setup dialog
		private void btPage_Click(object sender, EventArgs e)
		{
			psdText.Document = document;
			psdText.ShowDialog();
		}
		#endregion

		#endregion

		#region Edit Tab Buttons
		#region Clipboard Buttons
		//Copies selected text to clipboard
		private void btCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rtbInput.SelectedText, TextDataFormat.UnicodeText);
			btCopy.Enabled = false;
			btCut.Enabled = false;
			btPaste.Enabled = true;
		}
		//Pastes the text in the clipboard
		private void btPaste_Click(object sender, EventArgs e)
		{
			rtbInput.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
		}
		//Cuts the selected text and puts it in the clipboard
		private void btCut_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rtbInput.SelectedText, TextDataFormat.UnicodeText);
			btCopy.Enabled = false;
			btCut.Enabled = false;
			btPaste.Enabled = true;
			rtbInput.Text = rtbInput.Text.Replace(rtbInput.SelectedText, "");
		}
		#endregion

		#region Text Settings
		//Selects all text in the input box
		private void btSelect_Click(object sender, EventArgs e)
		{
			rtbInput.SelectAll();
			rtbInput.Focus();
		}
		//Goes to the specified line number
		private void btGoTo_Click(object sender, EventArgs e)
		{
			GoTo gt = new GoTo();
			gt.ShowDialog();

			if (gt.ParsedValue > rtbInput.Lines.Count() && gt.ParsedValue != 0)
			{
				MessageBox.Show("Maximum number of lines reached.", "Notepad#"); btGoTo.PerformClick();
			}
			if (rtbInput.Lines.Length != 0)
			{
				try
				{
					rtbInput.SelectionStart = rtbInput.Find(rtbInput.Lines[gt.ParsedValue - 1]);
					rtbInput.ScrollToCaret();
					rtbInput.Focus();
				}
				catch(ArgumentOutOfRangeException)
				{
					MessageBox.Show("Unexpected error occured.", "Notepad#");
				}
			}
		}
		//Initiates the find dialog
		private void btFind_Click(object sender, EventArgs e)
		{
			if (fn == null)
				fn = new Find(this);

			fn.GetText(rtbInput.Text);

			if (!fn.Visible)
				fn.Show();
			else
				fn.Hide();
		}
		//Initiates the replace text dialog
		private void btReplace_Click(object sender, EventArgs e)
		{
			if (rep == null)
				rep = new Replace(this);

			rep.GetText(rtbInput.Text);

			if (!rep.Visible)
				rep.Show();
			else
				rep.Hide();
		}
		#endregion

		//Performs undo operation
		private void btUndo_Click(object sender, EventArgs e)
		{
			rtbInput.Undo();
			btRedo.Enabled = true;
		}
		//Performs redo operation
		private void btRedo_Click(object sender, EventArgs e)
		{
			rtbInput.Redo();
		}

		#endregion

		#region Home Tab Buttons
		#region Font Settings
		//Opens the font dialog
		private void btFont_Click(object sender, EventArgs e)
		{
			fontDialogNote.Font = rtbInput.SelectionFont;
			fontDialogNote.ShowDialog();
			rtbInput.SelectionFont = fontDialogNote.Font;
			rtbInput.Focus();
		}
		//Opens the color dialog
		private void btColor_Click(object sender, EventArgs e)
		{
			colorDialogNote.Color = rtbInput.SelectionColor;
			colorDialogNote.ShowDialog();
			rtbInput.SelectionColor = colorDialogNote.Color;
			rtbInput.Focus();
		}
		//Makes selected text bold
		private void btBold_Click(object sender, EventArgs e)
		{
            try
            {
                if (!rtbInput.SelectionFont.Bold)
                    rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.SelectionFont.SizeInPoints, FontStyle.Bold);
                else
                    rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.SelectionFont.SizeInPoints, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Unexpected error occured.", "Notepad#");
                return;
            }
			rtbInput.Focus();
		}
		//Makes text italicized
		private void btItalic_Click(object sender, EventArgs e)
		{
            try
            {
                if (!rtbInput.SelectionFont.Italic)
                    rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.SelectionFont.SizeInPoints, FontStyle.Italic);
                else
                    rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.SelectionFont.SizeInPoints, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Unexpected error occured.", "Notepad#");
                return;
            }
			rtbInput.Focus();
		}
		//Makes text strikedthrough
		private void btStrike_Click(object sender, EventArgs e)
		{
            try
            {
                if (!rtbInput.SelectionFont.Strikeout)
                    rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.SelectionFont.SizeInPoints, FontStyle.Strikeout);
                else
                    rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.SelectionFont.SizeInPoints, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Unexpected error occured.", "Notepad#");
                return;
            }
			rtbInput.Focus();
		}
		//Makes text underlined
		private void btUnderline_Click(object sender, EventArgs e)
		{
            try
            {
                if (!rtbInput.SelectionFont.Underline)
                    rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.SelectionFont.SizeInPoints, FontStyle.Underline);
                else
                    rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.SelectionFont.SizeInPoints, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Unexpected error occured.", "Notepad#");
                return;
            }
			rtbInput.Focus();
		}
		//Makes text superscripted
		private void btSuperscript_Click(object sender, EventArgs e)
		{
            try
            {
                // Set the CharOffset to display superscript text.
                if (rtbInput.SelectionCharOffset == 0)
                {
                    rtbInput.SelectionCharOffset = 10; rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, 10);
                }
                else if (rtbInput.SelectionCharOffset == -10)
                {
                    rtbInput.SelectionCharOffset = 0; rtbInput.SelectionCharOffset = 10; rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, 10);
                }
                else
                {
                    rtbInput.SelectionCharOffset = 0; rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.Font.Size);
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error occured.", "Notepad#");
                return;
            }
			rtbInput.Focus();
		}
		//Makes text subscripted
		private void btSubscript_Click(object sender, EventArgs e)
		{
            try
            {
                // Set the CharOffset to display subscript text.
                if (rtbInput.SelectionCharOffset == 0)
                {
                    rtbInput.SelectionCharOffset = -10; rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, 10);
                }
                else if (rtbInput.SelectionCharOffset == 10)
                {
                    rtbInput.SelectionCharOffset = 0; rtbInput.SelectionCharOffset = -10; rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, 10);
                }
                else
                {
                    rtbInput.SelectionCharOffset = 0; rtbInput.SelectionFont = new Font(rtbInput.SelectionFont.FontFamily, rtbInput.Font.Size);
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error occured.", "Notepad#");
                return;
            }
			rtbInput.Focus();
		}
		#endregion

		#region Paragraph Settings
		//Activates the bullet list property of the textbox
		private void btList_Click(object sender, EventArgs e)
		{
			if (!rtbInput.SelectionBullet)
			{
				rtbInput.SelectionBullet = true; rtbInput.BulletIndent = 25;
			}
			else
				rtbInput.SelectionBullet = false;
			rtbInput.Focus();
		}
		//Indents text to the right by 40
		private void btIncIndent_Click(object sender, EventArgs e)
		{
			rtbInput.SelectionIndent += 40;
			rtbInput.Focus();
		}
		//Indents text to the left by 40
		private void btDecIndent_Click(object sender, EventArgs e)
		{
			if (rtbInput.SelectionIndent != 0)
			{
				rtbInput.SelectionIndent -= 40;
				rtbInput.Focus();
			}
		}
		//Makes the text align to the left
		private void btLeft_Click(object sender, EventArgs e)
		{
			rtbInput.SelectionAlignment = HorizontalAlignment.Left;
			rtbInput.Focus();
		}
		//Makes the text align to the center
		private void btCenter_Click(object sender, EventArgs e)
		{
			rtbInput.SelectionAlignment = HorizontalAlignment.Center;
			rtbInput.Focus();
		}
		//Makes the text align to the right
		private void btRight_Click(object sender, EventArgs e)
		{
			rtbInput.SelectionAlignment = HorizontalAlignment.Right;
			rtbInput.Focus();
		}
		#endregion

		#endregion

		#region View Tab Buttons
		//Sets the word wrap state of the textbox
		private void btWrap_Click(object sender, EventArgs e)
		{
			if (rtbInput.WordWrap)
			{
				btGoTo.Enabled = true;
				rtbInput.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
				rtbInput.WordWrap = false; btWrap.ImageIndex = 18;
			}
			else
			{
				btGoTo.Enabled = false;
				rtbInput.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
				rtbInput.WordWrap = true; btWrap.ImageIndex = 17;
			}
		}
		//Sets the visibility state of the status
		private void btStatusBar_Click(object sender, EventArgs e)
		{
			if(statusText.Visible)
			{
				statusText.Visible = false; rtbInput.Height += statusText.Height;
				btStatusBar.ImageIndex = 18;
			}
			else
			{
				statusText.Visible = true; rtbInput.Height -= statusText.Height;
				btStatusBar.ImageIndex = 17;
			}
		}
		//Add the current system data time to the textbox
		private void btDateTime_Click(object sender, EventArgs e)
		{
			rtbInput.Text = String.Concat(rtbInput.Text,DateTime.Now);
		}
		#endregion

		private void btAbout_Click(object sender, EventArgs e)
		{
			AboutUs au = new AboutUs();
			au.ShowDialog();
		}
	}
}
