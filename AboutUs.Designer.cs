namespace PE_MonteroAMB_Notepad
{
	partial class AboutUs
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btOk = new System.Windows.Forms.Button();
			this.pbIcon = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(303, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 64);
			this.label1.TabIndex = 0;
			this.label1.Text = "Notepad#";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(303, 89);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(335, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "A Notepad clone written in C# Windows Forms";
			// 
			// btOk
			// 
			this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btOk.Location = new System.Drawing.Point(526, 300);
			this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btOk.Name = "btOk";
			this.btOk.Size = new System.Drawing.Size(112, 35);
			this.btOk.TabIndex = 2;
			this.btOk.Text = "OK";
			this.btOk.UseVisualStyleBackColor = true;
			this.btOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// pbIcon
			// 
			this.pbIcon.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.BigIcon;
			this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbIcon.Location = new System.Drawing.Point(25, 25);
			this.pbIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(270, 270);
			this.pbIcon.TabIndex = 3;
			this.pbIcon.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(303, 109);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(195, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "by Anne Mariel B. Montero";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btOk);
			this.panel1.Controls.Add(this.pbIcon);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 363);
			this.panel1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(303, 184);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(321, 111);
			this.label4.TabIndex = 5;
			this.label4.Text = "This program is created for educational purposes.\r\nAll copyright material used ar" +
    "e for non-profit.\r\nAny paid distribution of this application is not genuine.";
			// 
			// AboutUs
			// 
			this.AcceptButton = this.btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.CancelButton = this.btOk;
			this.ClientSize = new System.Drawing.Size(673, 372);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutUs";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Notepad#";
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btOk;
		private System.Windows.Forms.PictureBox pbIcon;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
	}
}