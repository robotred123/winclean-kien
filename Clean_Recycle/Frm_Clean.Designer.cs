
namespace Clean_Recycle
{
    partial class Frm_Clean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clean));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this._nimRestore = new System.Windows.Forms.ToolStripMenuItem();
            this._nimMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this._nimExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this._notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.m_Minimize = new System.Windows.Forms.PictureBox();
            this.lb_mess = new System.Windows.Forms.Label();
            this.txt_Details = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Bnt_Excute_scripts = new System.Windows.Forms.Button();
            this.dataGV_Scripts = new System.Windows.Forms.DataGridView();
            this.col_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name_policy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name_scripts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_bool_policy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._notifyIconMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Minimize)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Scripts)).BeginInit();
            this.SuspendLayout();
            // 
            // _nimRestore
            // 
            this._nimRestore.Name = "_nimRestore";
            this._nimRestore.Size = new System.Drawing.Size(123, 22);
            this._nimRestore.Text = "Normal";
            this._nimRestore.Click += new System.EventHandler(this._nimRestore_Click);
            // 
            // _nimMinimize
            // 
            this._nimMinimize.Name = "_nimMinimize";
            this._nimMinimize.Size = new System.Drawing.Size(123, 22);
            this._nimMinimize.Text = "Minimize";
            this._nimMinimize.Click += new System.EventHandler(this._nimMinimize_Click);
            // 
            // _nimExit
            // 
            this._nimExit.Name = "_nimExit";
            this._nimExit.Size = new System.Drawing.Size(123, 22);
            this._nimExit.Text = "Exit";
            this._nimExit.Click += new System.EventHandler(this._nimExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // _notifyIconMenu
            // 
            this._notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._nimRestore,
            this._nimMinimize,
            this._nimExit,
            this.toolStripMenuItem1});
            this._notifyIconMenu.Name = "_notifyIconMenu";
            this._notifyIconMenu.Size = new System.Drawing.Size(124, 76);
            // 
            // _notifyIcon
            // 
            this._notifyIcon.ContextMenuStrip = this._notifyIconMenu;
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Text = "Clean Recycle";
            this._notifyIcon.Visible = true;
            this._notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseClick);
            this._notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.m_Minimize);
            this.groupBox1.Controls.Add(this.lb_mess);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 46);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // m_Minimize
            // 
            this.m_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("m_Minimize.Image")));
            this.m_Minimize.Location = new System.Drawing.Point(583, 14);
            this.m_Minimize.Name = "m_Minimize";
            this.m_Minimize.Size = new System.Drawing.Size(20, 20);
            this.m_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_Minimize.TabIndex = 34;
            this.m_Minimize.TabStop = false;
            this.m_Minimize.Click += new System.EventHandler(this._nimMinimize_Click);
            // 
            // lb_mess
            // 
            this.lb_mess.AutoSize = true;
            this.lb_mess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mess.ForeColor = System.Drawing.Color.Blue;
            this.lb_mess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_mess.Location = new System.Drawing.Point(40, 16);
            this.lb_mess.Name = "lb_mess";
            this.lb_mess.Size = new System.Drawing.Size(0, 20);
            this.lb_mess.TabIndex = 23;
            this.lb_mess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Details
            // 
            this.txt_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Details.Location = new System.Drawing.Point(375, 46);
            this.txt_Details.Multiline = true;
            this.txt_Details.Name = "txt_Details";
            this.txt_Details.Size = new System.Drawing.Size(234, 469);
            this.txt_Details.TabIndex = 18;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Bnt_Excute_scripts);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(375, 515);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(234, 39);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // Bnt_Excute_scripts
            // 
            this.Bnt_Excute_scripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bnt_Excute_scripts.Location = new System.Drawing.Point(92, 10);
            this.Bnt_Excute_scripts.Name = "Bnt_Excute_scripts";
            this.Bnt_Excute_scripts.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Excute_scripts.TabIndex = 0;
            this.Bnt_Excute_scripts.Text = "Thực hiện";
            this.Bnt_Excute_scripts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bnt_Excute_scripts.UseVisualStyleBackColor = true;
            this.Bnt_Excute_scripts.Click += new System.EventHandler(this.Bnt_Excute_scripts_Click);
            // 
            // dataGV_Scripts
            // 
            this.dataGV_Scripts.AllowUserToAddRows = false;
            this.dataGV_Scripts.AllowUserToDeleteRows = false;
            this.dataGV_Scripts.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGV_Scripts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Scripts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_check,
            this.col_ID,
            this.col_Name_policy,
            this.col_Details,
            this.col_Name_scripts,
            this.col_bool_policy});
            this.dataGV_Scripts.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGV_Scripts.Location = new System.Drawing.Point(0, 46);
            this.dataGV_Scripts.Name = "dataGV_Scripts";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Scripts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGV_Scripts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Scripts.Size = new System.Drawing.Size(375, 508);
            this.dataGV_Scripts.TabIndex = 16;
            this.dataGV_Scripts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Scripts_CellClick);
            this.dataGV_Scripts.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGV_Scripts_RowPostPaint);
            // 
            // col_check
            // 
            this.col_check.HeaderText = "Chọn";
            this.col_check.Name = "col_check";
            this.col_check.Width = 40;
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.HeaderText = "Mã";
            this.col_ID.Name = "col_ID";
            this.col_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_ID.Visible = false;
            this.col_ID.Width = 28;
            // 
            // col_Name_policy
            // 
            this.col_Name_policy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_Name_policy.DataPropertyName = "Name_policy";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Name_policy.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_Name_policy.HeaderText = "Name Policy";
            this.col_Name_policy.Name = "col_Name_policy";
            this.col_Name_policy.ReadOnly = true;
            this.col_Name_policy.Width = 91;
            // 
            // col_Details
            // 
            this.col_Details.DataPropertyName = "Details";
            this.col_Details.HeaderText = "Details";
            this.col_Details.Name = "col_Details";
            this.col_Details.ReadOnly = true;
            this.col_Details.Visible = false;
            this.col_Details.Width = 64;
            // 
            // col_Name_scripts
            // 
            this.col_Name_scripts.DataPropertyName = "Name_scripts";
            this.col_Name_scripts.HeaderText = "Name scripts";
            this.col_Name_scripts.Name = "col_Name_scripts";
            this.col_Name_scripts.ReadOnly = true;
            this.col_Name_scripts.Visible = false;
            this.col_Name_scripts.Width = 93;
            // 
            // col_bool_policy
            // 
            this.col_bool_policy.DataPropertyName = "bool_policy";
            this.col_bool_policy.HeaderText = "Trạng thái";
            this.col_bool_policy.Name = "col_bool_policy";
            this.col_bool_policy.ReadOnly = true;
            this.col_bool_policy.Visible = false;
            // 
            // Frm_Clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 554);
            this.Controls.Add(this.txt_Details);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGV_Scripts);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Clean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recyle Clean";
            this.Load += new System.EventHandler(this.Frm_Clean_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_Clean_SizeChanged);
            this._notifyIconMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Minimize)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Scripts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem _nimRestore;
        private System.Windows.Forms.ToolStripMenuItem _nimMinimize;
        private System.Windows.Forms.ToolStripMenuItem _nimExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip _notifyIconMenu;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.Label lb_mess;
        private System.Windows.Forms.TextBox txt_Details;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Bnt_Excute_scripts;
        private System.Windows.Forms.DataGridView dataGV_Scripts;
        private System.Windows.Forms.PictureBox m_Minimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name_policy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name_scripts;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_bool_policy;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

