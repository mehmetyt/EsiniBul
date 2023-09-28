namespace EsiniBul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlKartlar = new Panel();
            gboYeniOyun = new GroupBox();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            btnOyunuBaslat = new Button();
            menuStrip1 = new MenuStrip();
            oyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.Location = new Point(12, 51);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(600, 600);
            pnlKartlar.TabIndex = 0;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Location = new Point(191, 217);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(249, 277);
            gboYeniOyun.TabIndex = 0;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "Yeni Oyun";
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.Location = new Point(77, 171);
            rb5.Name = "rb5";
            rb5.Size = new Size(80, 24);
            rb5.TabIndex = 5;
            rb5.TabStop = true;
            rb5.Text = "Çok zor";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(77, 141);
            rb4.Name = "rb4";
            rb4.Size = new Size(53, 24);
            rb4.TabIndex = 4;
            rb4.TabStop = true;
            rb4.Text = "Zor";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.Location = new Point(77, 111);
            rb3.Name = "rb3";
            rb3.Size = new Size(59, 24);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(77, 81);
            rb2.Name = "rb2";
            rb2.Size = new Size(67, 24);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(77, 51);
            rb1.Name = "rb1";
            rb1.Size = new Size(96, 24);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Çok Kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Location = new Point(54, 220);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(127, 29);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { oyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(629, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            oyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            oyunToolStripMenuItem.Size = new Size(57, 24);
            oyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(181, 26);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(629, 666);
            Controls.Add(gboYeniOyun);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul Oyunu";
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox gboYeniOyun;
        private Button btnOyunuBaslat;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}