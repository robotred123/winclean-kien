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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CleanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TestKeyboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HtmlLbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LbHtmlIP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LbHtmlMac = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LbHtmlNamePC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LbHtmlVer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.LbHtmlVer);
            this.panel1.Controls.Add(this.LbHtmlNamePC);
            this.panel1.Controls.Add(this.LbHtmlMac);
            this.panel1.Controls.Add(this.LbHtmlIP);
            this.panel1.Controls.Add(this.HtmlLbName);
            this.panel1.Controls.Add(this.CleanBtn);
            this.panel1.Controls.Add(this.TestKeyboardBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 243);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // CleanBtn
            // 
            this.CleanBtn.BorderRadius = 25;
            this.CleanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CleanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CleanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CleanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CleanBtn.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.CleanBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanBtn.ForeColor = System.Drawing.Color.White;
            this.CleanBtn.Location = new System.Drawing.Point(20, 149);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(200, 40);
            this.CleanBtn.TabIndex = 22;
            this.CleanBtn.Text = "Clean PC";
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // TestKeyboardBtn
            // 
            this.TestKeyboardBtn.BorderRadius = 25;
            this.TestKeyboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TestKeyboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TestKeyboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TestKeyboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TestKeyboardBtn.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.TestKeyboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestKeyboardBtn.ForeColor = System.Drawing.Color.White;
            this.TestKeyboardBtn.Location = new System.Drawing.Point(20, 195);
            this.TestKeyboardBtn.Name = "TestKeyboardBtn";
            this.TestKeyboardBtn.Size = new System.Drawing.Size(200, 40);
            this.TestKeyboardBtn.TabIndex = 21;
            this.TestKeyboardBtn.Text = "Test Keyboard";
            this.TestKeyboardBtn.Click += new System.EventHandler(this.TestKeyboardBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HtmlLbName
            // 
            this.HtmlLbName.BackColor = System.Drawing.Color.Transparent;
            this.HtmlLbName.Location = new System.Drawing.Point(33, 43);
            this.HtmlLbName.Name = "HtmlLbName";
            this.HtmlLbName.Size = new System.Drawing.Size(64, 15);
            this.HtmlLbName.TabIndex = 23;
            this.HtmlLbName.Text = "LbHtmlName";
            // 
            // LbHtmlIP
            // 
            this.LbHtmlIP.BackColor = System.Drawing.Color.Transparent;
            this.LbHtmlIP.Location = new System.Drawing.Point(33, 69);
            this.LbHtmlIP.Name = "LbHtmlIP";
            this.LbHtmlIP.Size = new System.Drawing.Size(46, 15);
            this.LbHtmlIP.TabIndex = 24;
            this.LbHtmlIP.Text = "LbHtmlIP";
            // 
            // LbHtmlMac
            // 
            this.LbHtmlMac.BackColor = System.Drawing.Color.Transparent;
            this.LbHtmlMac.Location = new System.Drawing.Point(33, 95);
            this.LbHtmlMac.Name = "LbHtmlMac";
            this.LbHtmlMac.Size = new System.Drawing.Size(57, 15);
            this.LbHtmlMac.TabIndex = 25;
            this.LbHtmlMac.Text = "LbHtmlMac";
            // 
            // LbHtmlNamePC
            // 
            this.LbHtmlNamePC.BackColor = System.Drawing.Color.Transparent;
            this.LbHtmlNamePC.Location = new System.Drawing.Point(33, 120);
            this.LbHtmlNamePC.Name = "LbHtmlNamePC";
            this.LbHtmlNamePC.Size = new System.Drawing.Size(78, 15);
            this.LbHtmlNamePC.TabIndex = 26;
            this.LbHtmlNamePC.Text = "LbHtmlNamePC";
            // 
            // LbHtmlVer
            // 
            this.LbHtmlVer.BackColor = System.Drawing.Color.Transparent;
            this.LbHtmlVer.Location = new System.Drawing.Point(3, 3);
            this.LbHtmlVer.Name = "LbHtmlVer";
            this.LbHtmlVer.Size = new System.Drawing.Size(52, 15);
            this.LbHtmlVer.TabIndex = 27;
            this.LbHtmlVer.Text = "LbHtmlVer";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(232, 243);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button TestKeyboardBtn;
        private Guna.UI2.WinForms.Guna2Button CleanBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel HtmlLbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbHtmlIP;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbHtmlMac;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbHtmlNamePC;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbHtmlVer;
    }
}