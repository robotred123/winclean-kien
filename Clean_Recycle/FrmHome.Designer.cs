namespace Clean_Recycle
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.LbHtmlVer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LbHtmlNamePC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LbHtmlMac = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LbHtmlIP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HtmlLbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CleanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TestKeyboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CleanWin";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.normalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.LbHtmlVer);
            this.guna2CustomGradientPanel1.Controls.Add(this.LbHtmlNamePC);
            this.guna2CustomGradientPanel1.Controls.Add(this.LbHtmlMac);
            this.guna2CustomGradientPanel1.Controls.Add(this.LbHtmlIP);
            this.guna2CustomGradientPanel1.Controls.Add(this.HtmlLbName);
            this.guna2CustomGradientPanel1.Controls.Add(this.CleanBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.TestKeyboardBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.RoyalBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(232, 243);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            this.guna2CustomGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2CustomGradientPanel1_MouseDown);
            this.guna2CustomGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2CustomGradientPanel1_MouseMove);
            this.guna2CustomGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2CustomGradientPanel1_MouseUp);
            // 
            // LbHtmlVer
            // 
            this.LbHtmlVer.BackColor = System.Drawing.Color.Transparent;
            this.LbHtmlVer.Location = new System.Drawing.Point(3, 4);
            this.LbHtmlVer.Name = "LbHtmlVer";
            this.LbHtmlVer.Size = new System.Drawing.Size(52, 15);
            this.LbHtmlVer.TabIndex = 35;
            this.LbHtmlVer.Text = "LbHtmlVer";
            // 
            // LbHtmlNamePC
            // 
            this.LbHtmlNamePC.BackColor = System.Drawing.Color.Transparent;
            this.LbHtmlNamePC.Location = new System.Drawing.Point(33, 121);
            this.LbHtmlNamePC.Name = "LbHtmlNamePC";
            this.LbHtmlNamePC.Size = new System.Drawing.Size(78, 15);
            this.LbHtmlNamePC.TabIndex = 34;
            this.LbHtmlNamePC.Text = "LbHtmlNamePC";
            // 
            // LbHtmlMac
            // 
            this.LbHtmlMac.BackColor = System.Drawing.Color.Transparent;
            this.LbHtmlMac.Location = new System.Drawing.Point(33, 96);
            this.LbHtmlMac.Name = "LbHtmlMac";
            this.LbHtmlMac.Size = new System.Drawing.Size(57, 15);
            this.LbHtmlMac.TabIndex = 33;
            this.LbHtmlMac.Text = "LbHtmlMac";
            // 
            // LbHtmlIP
            // 
            this.LbHtmlIP.BackColor = System.Drawing.Color.Transparent;
            this.LbHtmlIP.Location = new System.Drawing.Point(33, 70);
            this.LbHtmlIP.Name = "LbHtmlIP";
            this.LbHtmlIP.Size = new System.Drawing.Size(46, 15);
            this.LbHtmlIP.TabIndex = 32;
            this.LbHtmlIP.Text = "LbHtmlIP";
            // 
            // HtmlLbName
            // 
            this.HtmlLbName.BackColor = System.Drawing.Color.Transparent;
            this.HtmlLbName.Location = new System.Drawing.Point(33, 44);
            this.HtmlLbName.Name = "HtmlLbName";
            this.HtmlLbName.Size = new System.Drawing.Size(64, 15);
            this.HtmlLbName.TabIndex = 31;
            this.HtmlLbName.Text = "LbHtmlName";
            // 
            // CleanBtn
            // 
            this.CleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.CleanBtn.BorderRadius = 20;
            this.CleanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CleanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CleanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CleanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CleanBtn.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.CleanBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanBtn.ForeColor = System.Drawing.Color.White;
            this.CleanBtn.Location = new System.Drawing.Point(20, 150);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(91, 40);
            this.CleanBtn.TabIndex = 30;
            this.CleanBtn.Text = "Clean PC";
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // TestKeyboardBtn
            // 
            this.TestKeyboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.TestKeyboardBtn.BorderRadius = 20;
            this.TestKeyboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TestKeyboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TestKeyboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TestKeyboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TestKeyboardBtn.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.TestKeyboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestKeyboardBtn.ForeColor = System.Drawing.Color.White;
            this.TestKeyboardBtn.Location = new System.Drawing.Point(125, 150);
            this.TestKeyboardBtn.Name = "TestKeyboardBtn";
            this.TestKeyboardBtn.Size = new System.Drawing.Size(95, 40);
            this.TestKeyboardBtn.TabIndex = 29;
            this.TestKeyboardBtn.Text = "Test Keyboard";
            this.TestKeyboardBtn.Click += new System.EventHandler(this.TestKeyboardBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(232, 243);
            this.ControlBox = false;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WinClean";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbHtmlVer;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbHtmlNamePC;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbHtmlMac;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbHtmlIP;
        private Guna.UI2.WinForms.Guna2HtmlLabel HtmlLbName;
        private Guna.UI2.WinForms.Guna2Button CleanBtn;
        private Guna.UI2.WinForms.Guna2Button TestKeyboardBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}