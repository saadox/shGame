namespace changeByte
{
	partial class BytesChanger
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
			this.Confirm = new System.Windows.Forms.Button();
			this.NopCheck = new System.Windows.Forms.RadioButton();
			this.UnNopCheck = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// Confirm
			// 
			this.Confirm.Location = new System.Drawing.Point(105, 12);
			this.Confirm.Name = "Confirm";
			this.Confirm.Size = new System.Drawing.Size(58, 43);
			this.Confirm.TabIndex = 0;
			this.Confirm.Text = "Confirm";
			this.Confirm.UseVisualStyleBackColor = true;
			this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
			// 
			// NopCheck
			// 
			this.NopCheck.AutoSize = true;
			this.NopCheck.Location = new System.Drawing.Point(14, 14);
			this.NopCheck.Name = "NopCheck";
			this.NopCheck.Size = new System.Drawing.Size(48, 17);
			this.NopCheck.TabIndex = 4;
			this.NopCheck.TabStop = true;
			this.NopCheck.Text = "NOP";
			this.NopCheck.UseVisualStyleBackColor = true;
			// 
			// UnNopCheck
			// 
			this.UnNopCheck.AutoSize = true;
			this.UnNopCheck.Location = new System.Drawing.Point(14, 35);
			this.UnNopCheck.Name = "UnNopCheck";
			this.UnNopCheck.Size = new System.Drawing.Size(57, 17);
			this.UnNopCheck.TabIndex = 5;
			this.UnNopCheck.TabStop = true;
			this.UnNopCheck.Text = "unNop";
			this.UnNopCheck.UseVisualStyleBackColor = true;
			// 
			// BytesChanger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(173, 65);
			this.Controls.Add(this.UnNopCheck);
			this.Controls.Add(this.NopCheck);
			this.Controls.Add(this.Confirm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "BytesChanger";
			this.Text = "NopBytes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Confirm;
		private System.Windows.Forms.RadioButton NopCheck;
		private System.Windows.Forms.RadioButton UnNopCheck;
	}
}

