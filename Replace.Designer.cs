namespace PE_MonteroAMB_Notepad
{
	partial class Replace
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replace));
			this.pnControl = new System.Windows.Forms.Panel();
			this.btRepAll = new System.Windows.Forms.Button();
			this.btReplace = new System.Windows.Forms.Button();
			this.lbReplace = new System.Windows.Forms.Label();
			this.txtReplace = new System.Windows.Forms.TextBox();
			this.lbFind = new System.Windows.Forms.Label();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.btCancelRep = new System.Windows.Forms.Button();
			this.chkCase = new System.Windows.Forms.CheckBox();
			this.btFind = new System.Windows.Forms.Button();
			this.pnControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnControl
			// 
			this.pnControl.BackColor = System.Drawing.Color.Beige;
			this.pnControl.Controls.Add(this.btRepAll);
			this.pnControl.Controls.Add(this.btReplace);
			this.pnControl.Controls.Add(this.lbReplace);
			this.pnControl.Controls.Add(this.txtReplace);
			this.pnControl.Controls.Add(this.lbFind);
			this.pnControl.Controls.Add(this.txtFind);
			this.pnControl.Controls.Add(this.btCancelRep);
			this.pnControl.Controls.Add(this.chkCase);
			this.pnControl.Controls.Add(this.btFind);
			this.pnControl.Location = new System.Drawing.Point(4, 4);
			this.pnControl.Name = "pnControl";
			this.pnControl.Size = new System.Drawing.Size(584, 280);
			this.pnControl.TabIndex = 0;
			// 
			// btRepAll
			// 
			this.btRepAll.Enabled = false;
			this.btRepAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btRepAll.Location = new System.Drawing.Point(247, 202);
			this.btRepAll.Name = "btRepAll";
			this.btRepAll.Size = new System.Drawing.Size(138, 40);
			this.btRepAll.TabIndex = 15;
			this.btRepAll.Text = "Replace All";
			this.btRepAll.UseVisualStyleBackColor = true;
			this.btRepAll.Click += new System.EventHandler(this.btRepAll_Click);
			// 
			// btReplace
			// 
			this.btReplace.Enabled = false;
			this.btReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btReplace.Location = new System.Drawing.Point(247, 143);
			this.btReplace.Name = "btReplace";
			this.btReplace.Size = new System.Drawing.Size(138, 40);
			this.btReplace.TabIndex = 14;
			this.btReplace.Text = "Replace";
			this.btReplace.UseVisualStyleBackColor = true;
			this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
			// 
			// lbReplace
			// 
			this.lbReplace.AutoSize = true;
			this.lbReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbReplace.Location = new System.Drawing.Point(32, 87);
			this.lbReplace.Name = "lbReplace";
			this.lbReplace.Size = new System.Drawing.Size(89, 25);
			this.lbReplace.TabIndex = 12;
			this.lbReplace.Text = "Replace:";
			// 
			// txtReplace
			// 
			this.txtReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtReplace.Location = new System.Drawing.Point(127, 84);
			this.txtReplace.Name = "txtReplace";
			this.txtReplace.Size = new System.Drawing.Size(413, 32);
			this.txtReplace.TabIndex = 13;
			this.txtReplace.TextChanged += new System.EventHandler(this.txtReplace_TextChanged);
			// 
			// lbFind
			// 
			this.lbFind.AutoSize = true;
			this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFind.Location = new System.Drawing.Point(32, 31);
			this.lbFind.Name = "lbFind";
			this.lbFind.Size = new System.Drawing.Size(56, 25);
			this.lbFind.TabIndex = 7;
			this.lbFind.Text = "Find:";
			// 
			// txtFind
			// 
			this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtFind.Location = new System.Drawing.Point(127, 28);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(413, 32);
			this.txtFind.TabIndex = 8;
			this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
			// 
			// btCancelRep
			// 
			this.btCancelRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btCancelRep.Location = new System.Drawing.Point(402, 202);
			this.btCancelRep.Name = "btCancelRep";
			this.btCancelRep.Size = new System.Drawing.Size(138, 40);
			this.btCancelRep.TabIndex = 10;
			this.btCancelRep.Text = "Cancel";
			this.btCancelRep.UseVisualStyleBackColor = true;
			this.btCancelRep.Click += new System.EventHandler(this.btCancelRep_Click);
			// 
			// chkCase
			// 
			this.chkCase.AutoSize = true;
			this.chkCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.chkCase.Location = new System.Drawing.Point(37, 143);
			this.chkCase.Name = "chkCase";
			this.chkCase.Size = new System.Drawing.Size(131, 26);
			this.chkCase.TabIndex = 11;
			this.chkCase.Text = "Match Case";
			this.chkCase.UseVisualStyleBackColor = true;
			this.chkCase.CheckedChanged += new System.EventHandler(this.chkCase_CheckedChanged);
			// 
			// btFind
			// 
			this.btFind.Enabled = false;
			this.btFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btFind.Location = new System.Drawing.Point(402, 143);
			this.btFind.Name = "btFind";
			this.btFind.Size = new System.Drawing.Size(138, 40);
			this.btFind.TabIndex = 9;
			this.btFind.Text = "Find Next";
			this.btFind.UseVisualStyleBackColor = true;
			this.btFind.Click += new System.EventHandler(this.btFind_Click);
			// 
			// Replace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(593, 289);
			this.Controls.Add(this.pnControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Replace";
			this.Text = "Replace";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Replace_FormClosing);
			this.pnControl.ResumeLayout(false);
			this.pnControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnControl;
		private System.Windows.Forms.Label lbFind;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Button btCancelRep;
		private System.Windows.Forms.CheckBox chkCase;
		private System.Windows.Forms.Button btFind;
		private System.Windows.Forms.Label lbReplace;
		private System.Windows.Forms.TextBox txtReplace;
		private System.Windows.Forms.Button btReplace;
		private System.Windows.Forms.Button btRepAll;
	}
}