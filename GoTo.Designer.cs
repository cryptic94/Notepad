namespace PE_MonteroAMB_Notepad
{
	partial class GoTo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoTo));
			this.lbLineNum = new System.Windows.Forms.Label();
			this.txtLine = new System.Windows.Forms.TextBox();
			this.btGo = new System.Windows.Forms.Button();
			this.btCancelGo = new System.Windows.Forms.Button();
			this.pnControl = new System.Windows.Forms.Panel();
			this.pnControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbLineNum
			// 
			this.lbLineNum.AutoSize = true;
			this.lbLineNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLineNum.Location = new System.Drawing.Point(25, 25);
			this.lbLineNum.Name = "lbLineNum";
			this.lbLineNum.Size = new System.Drawing.Size(129, 25);
			this.lbLineNum.TabIndex = 0;
			this.lbLineNum.Text = "Line Number:";
			// 
			// txtLine
			// 
			this.txtLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtLine.Location = new System.Drawing.Point(17, 59);
			this.txtLine.Name = "txtLine";
			this.txtLine.Size = new System.Drawing.Size(316, 32);
			this.txtLine.TabIndex = 1;
			this.txtLine.TextChanged += new System.EventHandler(this.txtLine_TextChanged);
			// 
			// btGo
			// 
			this.btGo.Enabled = false;
			this.btGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btGo.Location = new System.Drawing.Point(76, 116);
			this.btGo.Name = "btGo";
			this.btGo.Size = new System.Drawing.Size(116, 40);
			this.btGo.TabIndex = 2;
			this.btGo.Text = "Go To";
			this.btGo.UseVisualStyleBackColor = true;
			this.btGo.Click += new System.EventHandler(this.btGo_Click);
			// 
			// btCancelGo
			// 
			this.btCancelGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btCancelGo.Location = new System.Drawing.Point(217, 116);
			this.btCancelGo.Name = "btCancelGo";
			this.btCancelGo.Size = new System.Drawing.Size(116, 40);
			this.btCancelGo.TabIndex = 3;
			this.btCancelGo.Text = "Cancel";
			this.btCancelGo.UseVisualStyleBackColor = true;
			this.btCancelGo.Click += new System.EventHandler(this.btCancelGo_Click);
			// 
			// pnControl
			// 
			this.pnControl.BackColor = System.Drawing.Color.Beige;
			this.pnControl.Controls.Add(this.lbLineNum);
			this.pnControl.Controls.Add(this.btCancelGo);
			this.pnControl.Controls.Add(this.txtLine);
			this.pnControl.Controls.Add(this.btGo);
			this.pnControl.Location = new System.Drawing.Point(4, 4);
			this.pnControl.Name = "pnControl";
			this.pnControl.Size = new System.Drawing.Size(352, 177);
			this.pnControl.TabIndex = 4;
			// 
			// GoTo
			// 
			this.AcceptButton = this.btGo;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(360, 185);
			this.Controls.Add(this.pnControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "GoTo";
			this.Text = "Go To Line";
			this.pnControl.ResumeLayout(false);
			this.pnControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbLineNum;
		private System.Windows.Forms.TextBox txtLine;
		private System.Windows.Forms.Button btGo;
		private System.Windows.Forms.Button btCancelGo;
		private System.Windows.Forms.Panel pnControl;
	}
}