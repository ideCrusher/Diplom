namespace lolSHTO
{
    partial class Astranaar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tavern = new System.Windows.Forms.PictureBox();
            this.TownHall = new System.Windows.Forms.PictureBox();
            this.TradeShop = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tavern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TownHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeShop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Торговая лавка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Таверна";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ратуша";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 161);
            this.button1.TabIndex = 6;
            this.button1.Text = "Покинуть Деревню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(249, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 136);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Tavern
            // 
            this.Tavern.BackColor = System.Drawing.Color.Transparent;
            this.Tavern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tavern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tavern.Location = new System.Drawing.Point(31, 172);
            this.Tavern.Name = "Tavern";
            this.Tavern.Size = new System.Drawing.Size(162, 161);
            this.Tavern.TabIndex = 2;
            this.Tavern.TabStop = false;
            this.Tavern.Click += new System.EventHandler(this.Tavern_Click);
            this.Tavern.MouseEnter += new System.EventHandler(this.Tavern_MouseEnter);
            this.Tavern.MouseLeave += new System.EventHandler(this.Tavern_MouseLeave);
            this.Tavern.MouseHover += new System.EventHandler(this.Tavern_MouseHover);
            this.Tavern.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tavern_MouseMove);
            // 
            // TownHall
            // 
            this.TownHall.BackColor = System.Drawing.Color.Transparent;
            this.TownHall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TownHall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TownHall.Location = new System.Drawing.Point(429, 172);
            this.TownHall.Name = "TownHall";
            this.TownHall.Size = new System.Drawing.Size(162, 161);
            this.TownHall.TabIndex = 1;
            this.TownHall.TabStop = false;
            this.TownHall.Click += new System.EventHandler(this.TownHall_Click);
            this.TownHall.MouseEnter += new System.EventHandler(this.TownHall_MouseEnter);
            this.TownHall.MouseLeave += new System.EventHandler(this.TownHall_MouseLeave);
            // 
            // TradeShop
            // 
            this.TradeShop.BackColor = System.Drawing.Color.Transparent;
            this.TradeShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TradeShop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TradeShop.Location = new System.Drawing.Point(231, 172);
            this.TradeShop.Name = "TradeShop";
            this.TradeShop.Size = new System.Drawing.Size(162, 161);
            this.TradeShop.TabIndex = 0;
            this.TradeShop.TabStop = false;
            this.TradeShop.Click += new System.EventHandler(this.TradeShop_Click);
            this.TradeShop.MouseEnter += new System.EventHandler(this.TradeShop_MouseEnter);
            this.TradeShop.MouseLeave += new System.EventHandler(this.TradeShop_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(451, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // Astranaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 358);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tavern);
            this.Controls.Add(this.TownHall);
            this.Controls.Add(this.TradeShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Astranaar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astranaar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Astranaar_FormClosed);
            this.Load += new System.EventHandler(this.Astranaar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tavern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TownHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TradeShop;
        private System.Windows.Forms.PictureBox TownHall;
        private System.Windows.Forms.PictureBox Tavern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}