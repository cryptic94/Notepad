namespace PE_MonteroAMB_Notepad
{
	partial class Find
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
			this.lbFind = new System.Windows.Forms.Label();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.btCancelFind = new System.Windows.Forms.Button();
			this.btFindNext = new System.Windows.Forms.Button();
			this.chkCase = new System.Windows.Forms.CheckBox();
			this.rbUp = new System.Windows.Forms.RadioButton();
			this.rbDown = new System.Windows.Forms.RadioButton();
			this.gbDirection = new System.Windows.Forms.GroupBox();
			this.pnControl = new System.Windows.Forms.Panel();
			this.gbDirection.SuspendLayout();
			this.pnControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbFind
			// 
			this.lbFind.AutoSize = true;
			this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFind.Location = new System.Drawing.Point(20, 30);
			this.lbFind.Name = "lbFind";
			this.lbFind.Size = new System.Drawing.Size(56, 25);
			this.lbFind.TabIndex = 1;
			this.lbFind.Text = "Find:";
			// 
			// txtFind
			// 
			this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtFind.Location = new System.Drawing.Point(82, 28);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(333, 32);
			this.txtFind.TabIndex = 2;
			this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
			// 
			// btCancelFind
			// 
			this.btCancelFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btCancelFind.Location = new System.Drawing.Point(290, 156);
			this.btCancelFind.Name = "btCancelFind";
			this.btCancelFind.Size = new System.Drawing.Size(125, 40);
			this.btCancelFind.TabIndex = 5;
			this.btCancelFind.Text = "Cancel";
			this.btCancelFind.UseVisualStyleBackColor = true;
			this.btCancelFind.Click += new System.EventHandler(this.btCancelFind_Click);
			// 
			// btFindNext
			// 
			this.btFindNext.Enabled = false;
			this.btFindNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btFindNext.Location = new System.Drawing.Point(290, 91);
			this.btFindNext.Name = "btFindNext";
			this.btFindNext.Size = new System.Drawing.Size(125, 40);
			this.btFindNext.TabIndex = 4;
			this.btFindNext.Text = "Find Next";
			this.btFindNext.UseVisualStyleBackColor = true;
			this.btFindNext.Click += new System.EventHandler(this.btFind_Click);
			// 
			// chkCase
			// 
			this.chkCase.AutoSize = true;
			this.chkCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.chkCase.Location = new System.Drawing.Point(88, 77);
			this.chkCase.Name = "chkCase";
			this.chkCase.Size = new System.Drawing.Size(131, 26);
			this.chkCase.TabIndex = 6;
			this.chkCase.Text = "Match Case";
			this.chkCase.UseVisualStyleBackColor = true;
			this.chkCase.CheckedChanged += new System.EventHandler(this.chkCase_CheckedChanged);
			// 
			// rbUp
			// 
			this.rbUp.AutoSize = true;
			this.rbUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rbUp.Location = new System.Drawing.Point(41, 28);
			this.rbUp.Name = "rbUp";
			this.rbUp.Size = new System.Drawing.Size(58, 26);
			this.rbUp.TabIndex = 7;
			this.rbUp.Text = "Up";
			this.rbUp.UseVisualStyleBackColor = true;
			this.rbUp.CheckedChanged += new System.EventHandler(this.rbUp_CheckedChanged);
			// 
			// rbDown
			// 
			this.rbDown.AutoSize = true;
			this.rbDown.Checked = true;
			this.rbDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rbDown.Location = new System.Drawing.Point(41, 62);
			this.rbDown.Name = "rbDown";
			this.rbDown.Size = new System.Drawing.Size(81, 26);
			this.rbDown.TabIndex = 8;
			this.rbDown.TabStop = true;
			this.rbDown.Text = "Down";
			this.rbDown.UseVisualStyleBackColor = true;
			this.rbDown.CheckedChanged += new System.EventHandler(this.rbDown_CheckedChanged);
			// 
			// gbDirection
			// 
			this.gbDirection.Controls.Add(this.rbUp);
			this.gbDirection.Controls.Add(this.rbDown);
			this.gbDirection.Location = new System.Drawing.Point(82, 109);
			this.gbDirection.Name = "gbDirection";
			this.gbDirection.Size = new System.Drawing.Size(163, 105);
			this.gbDirection.TabIndex = 9;
			this.gbDirection.TabStop = false;
			this.gbDirection.Text = "Direction";
			// 
			// pnControl
			// 
			this.pnControl.BackColor = System.Drawing.Color.Beige;
			this.pnControl.Controls.Add(this.lbFind);
			this.pnControl.Controls.Add(this.gbDirection);
			this.pnControl.Controls.Add(this.txtFind);
			this.pnControl.Controls.Add(this.btCancelFind);
			this.pnControl.Controls.Add(this.chkCase);
			this.pnControl.Controls.Add(this.btFindNext);
			this.pnControl.Location = new System.Drawing.Point(4, 4);
			this.pnControl.Name = "pnControl";
			this.pnControl.Size = new System.Drawing.Size(449, 248);
			this.pnControl.TabIndex = 10;
			// 
			// Find
			// 
			this.AcceptButton = this.btFindNext;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(457, 257);
			this.Controls.Add(this.pnControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Find";
			this.Text = "Find";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Find_FormClosing);
			this.gbDirection.ResumeLayout(false);
			this.gbDirection.PerformLayout();
			this.pnControl.ResumeLayout(false);
			this.pnControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbFind;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Button btCancelFind;
		private System.Windows.Forms.Button btFindNext;
		private System.Windows.Forms.CheckBox chkCase;
		private System.Windows.Forms.RadioButton rbUp;
		private System.Windows.Forms.RadioButton rbDown;
		private System.Windows.Forms.GroupBox gbDirection;
		private System.Windows.Forms.Panel pnControl;
	}
}