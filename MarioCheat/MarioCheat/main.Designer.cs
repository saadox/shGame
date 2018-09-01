namespace MarioCheat
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnTime = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnPis = new System.Windows.Forms.Button();
            this.btnLife = new System.Windows.Forms.Button();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.txtPis = new System.Windows.Forms.TextBox();
            this.txtLife = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTime.Location = new System.Drawing.Point(129, 10);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(79, 33);
            this.btnTime.TabIndex = 0;
            this.btnTime.Text = "SET TIME";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(12, 17);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 3;
            // 
            // btnGold
            // 
            this.btnGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGold.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGold.Location = new System.Drawing.Point(129, 64);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(79, 33);
            this.btnGold.TabIndex = 4;
            this.btnGold.Text = "SET GOLD";
            this.btnGold.UseVisualStyleBackColor = true;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnPis
            // 
            this.btnPis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPis.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPis.Location = new System.Drawing.Point(129, 117);
            this.btnPis.Name = "btnPis";
            this.btnPis.Size = new System.Drawing.Size(79, 33);
            this.btnPis.TabIndex = 5;
            this.btnPis.Text = "SET PIS";
            this.btnPis.UseVisualStyleBackColor = true;
            this.btnPis.Click += new System.EventHandler(this.btnPis_Click);
            // 
            // btnLife
            // 
            this.btnLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLife.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLife.Location = new System.Drawing.Point(129, 175);
            this.btnLife.Name = "btnLife";
            this.btnLife.Size = new System.Drawing.Size(79, 33);
            this.btnLife.TabIndex = 6;
            this.btnLife.Text = "SET LIFES";
            this.btnLife.UseVisualStyleBackColor = true;
            this.btnLife.Click += new System.EventHandler(this.btnLife_Click);
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(12, 71);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(100, 20);
            this.txtGold.TabIndex = 7;
            // 
            // txtPis
            // 
            this.txtPis.Location = new System.Drawing.Point(12, 124);
            this.txtPis.Name = "txtPis";
            this.txtPis.Size = new System.Drawing.Size(100, 20);
            this.txtPis.TabIndex = 8;
            // 
            // txtLife
            // 
            this.txtLife.Location = new System.Drawing.Point(12, 182);
            this.txtLife.Name = "txtLife";
            this.txtLife.Size = new System.Drawing.Size(100, 20);
            this.txtLife.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(223, 222);
            this.Controls.Add(this.txtLife);
            this.Controls.Add(this.txtPis);
            this.Controls.Add(this.txtGold);
            this.Controls.Add(this.btnLife);
            this.Controls.Add(this.btnPis);
            this.Controls.Add(this.btnGold);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnTime);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "SaadZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.Button btnPis;
        private System.Windows.Forms.Button btnLife;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.TextBox txtPis;
        private System.Windows.Forms.TextBox txtLife;
    }
}

