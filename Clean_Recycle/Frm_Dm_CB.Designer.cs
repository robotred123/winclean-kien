
namespace Clean_Recycle
{
    partial class Frm_Dm_CB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dm_CB));
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this._cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this._btnOK = new System.Windows.Forms.Button();
            this.lb_NamePC = new System.Windows.Forms.Label();
            this.lb_Hoten = new System.Windows.Forms.Label();
            this.lb_MAC = new System.Windows.Forms.Label();
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.lb_Chucvu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_dvc1 = new System.Windows.Forms.ComboBox();
            this.cb_dvc2 = new System.Windows.Forms.ComboBox();
            this.cb_dvc3 = new System.Windows.Forms.ComboBox();
            this.cb_dvc4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.ForeColor = System.Drawing.Color.Red;
            this.txt_hoten.Location = new System.Drawing.Point(86, 192);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(196, 22);
            this.txt_hoten.TabIndex = 22;
            // 
            // _cbStartWithWindows
            // 
            this._cbStartWithWindows.AutoSize = true;
            this._cbStartWithWindows.Location = new System.Drawing.Point(15, 264);
            this._cbStartWithWindows.Name = "_cbStartWithWindows";
            this._cbStartWithWindows.Size = new System.Drawing.Size(149, 17);
            this._cbStartWithWindows.TabIndex = 25;
            this._cbStartWithWindows.Text = "Khởi động cùng Windows";
            this._cbStartWithWindows.UseVisualStyleBackColor = true;
            this._cbStartWithWindows.CheckedChanged += new System.EventHandler(this._cbStartWithWindows_CheckedChanged);
            // 
            // _btnOK
            // 
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(111, 298);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 26;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // lb_NamePC
            // 
            this.lb_NamePC.AutoSize = true;
            this.lb_NamePC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamePC.ForeColor = System.Drawing.Color.Red;
            this.lb_NamePC.Location = new System.Drawing.Point(12, 36);
            this.lb_NamePC.Name = "lb_NamePC";
            this.lb_NamePC.Size = new System.Drawing.Size(106, 16);
            this.lb_NamePC.TabIndex = 28;
            this.lb_NamePC.Text = "Computer name:";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.AutoSize = true;
            this.lb_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hoten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Hoten.Location = new System.Drawing.Point(12, 195);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(68, 16);
            this.lb_Hoten.TabIndex = 29;
            this.lb_Hoten.Text = "Họ và tên:";
            // 
            // lb_MAC
            // 
            this.lb_MAC.AutoSize = true;
            this.lb_MAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MAC.ForeColor = System.Drawing.Color.Red;
            this.lb_MAC.Location = new System.Drawing.Point(12, 10);
            this.lb_MAC.Name = "lb_MAC";
            this.lb_MAC.Size = new System.Drawing.Size(83, 16);
            this.lb_MAC.TabIndex = 27;
            this.lb_MAC.Text = "Địa chỉ MAC:";
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chucvu.ForeColor = System.Drawing.Color.Red;
            this.txt_chucvu.Location = new System.Drawing.Point(76, 226);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Size = new System.Drawing.Size(206, 22);
            this.txt_chucvu.TabIndex = 24;
            this.txt_chucvu.TextChanged += new System.EventHandler(this.txt_chucvu_TextChanged);
            // 
            // lb_Chucvu
            // 
            this.lb_Chucvu.AutoSize = true;
            this.lb_Chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Chucvu.Location = new System.Drawing.Point(12, 229);
            this.lb_Chucvu.Name = "lb_Chucvu";
            this.lb_Chucvu.Size = new System.Drawing.Size(58, 16);
            this.lb_Chucvu.TabIndex = 32;
            this.lb_Chucvu.Text = "Chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Đơn vị cấp 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Đơn vị cấp 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Đơn vị cấp 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Đơn vị cấp 4:";
            // 
            // cb_dvc1
            // 
            this.cb_dvc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dvc1.ForeColor = System.Drawing.Color.Red;
            this.cb_dvc1.FormattingEnabled = true;
            this.cb_dvc1.Location = new System.Drawing.Point(102, 65);
            this.cb_dvc1.Name = "cb_dvc1";
            this.cb_dvc1.Size = new System.Drawing.Size(180, 21);
            this.cb_dvc1.TabIndex = 37;
            this.cb_dvc1.SelectedIndexChanged += new System.EventHandler(this.cb_dvc1_SelectedIndexChanged);
            // 
            // cb_dvc2
            // 
            this.cb_dvc2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dvc2.FormattingEnabled = true;
            this.cb_dvc2.Location = new System.Drawing.Point(102, 97);
            this.cb_dvc2.Name = "cb_dvc2";
            this.cb_dvc2.Size = new System.Drawing.Size(180, 21);
            this.cb_dvc2.TabIndex = 38;
            this.cb_dvc2.SelectedIndexChanged += new System.EventHandler(this.cb_dvc2_SelectedIndexChanged);
            // 
            // cb_dvc3
            // 
            this.cb_dvc3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dvc3.FormattingEnabled = true;
            this.cb_dvc3.Location = new System.Drawing.Point(102, 128);
            this.cb_dvc3.Name = "cb_dvc3";
            this.cb_dvc3.Size = new System.Drawing.Size(180, 21);
            this.cb_dvc3.TabIndex = 39;
            this.cb_dvc3.SelectedIndexChanged += new System.EventHandler(this.cb_dvc3_SelectedIndexChanged);
            // 
            // cb_dvc4
            // 
            this.cb_dvc4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dvc4.FormattingEnabled = true;
            this.cb_dvc4.Location = new System.Drawing.Point(102, 159);
            this.cb_dvc4.Name = "cb_dvc4";
            this.cb_dvc4.Size = new System.Drawing.Size(180, 21);
            this.cb_dvc4.TabIndex = 40;
            // 
            // Frm_Dm_CB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 340);
            this.Controls.Add(this.cb_dvc4);
            this.Controls.Add(this.cb_dvc3);
            this.Controls.Add(this.cb_dvc2);
            this.Controls.Add(this.cb_dvc1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_chucvu);
            this.Controls.Add(this.lb_Chucvu);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this._cbStartWithWindows);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this.lb_NamePC);
            this.Controls.Add(this.lb_Hoten);
            this.Controls.Add(this.lb_MAC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Dm_CB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai báo thiết bị";
            this.Load += new System.EventHandler(this.Frm_Dm_CB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.CheckBox _cbStartWithWindows;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Label lb_NamePC;
        private System.Windows.Forms.Label lb_Hoten;
        private System.Windows.Forms.Label lb_MAC;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.Label lb_Chucvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_dvc1;
        private System.Windows.Forms.ComboBox cb_dvc2;
        private System.Windows.Forms.ComboBox cb_dvc3;
        private System.Windows.Forms.ComboBox cb_dvc4;
    }
}