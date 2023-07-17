
namespace Clean_Recycle
{
    partial class Frm_AlertBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AlertBox));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Text = new System.Windows.Forms.Label();
            this.LinkTextAlertBox = new System.Windows.Forms.Panel();
            this.timerAlertBox = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_Title.Location = new System.Drawing.Point(63, 8);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(283, 25);
            this.lb_Title.TabIndex = 37;
            this.lb_Title.Text = "Thông báo Clean Recycle";
            // 
            // lb_Text
            // 
            this.lb_Text.AutoSize = true;
            this.lb_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Text.ForeColor = System.Drawing.Color.Crimson;
            this.lb_Text.Location = new System.Drawing.Point(65, 35);
            this.lb_Text.Name = "lb_Text";
            this.lb_Text.Size = new System.Drawing.Size(83, 16);
            this.lb_Text.TabIndex = 38;
            this.lb_Text.Text = "TextAlertBox";
            // 
            // LinkTextAlertBox
            // 
            this.LinkTextAlertBox.BackColor = System.Drawing.Color.Chartreuse;
            this.LinkTextAlertBox.Location = new System.Drawing.Point(3, 59);
            this.LinkTextAlertBox.Name = "LinkTextAlertBox";
            this.LinkTextAlertBox.Size = new System.Drawing.Size(1, 10);
            this.LinkTextAlertBox.TabIndex = 39;
            // 
            // timerAlertBox
            // 
            this.timerAlertBox.Tick += new System.EventHandler(this.timerAlertBox_Tick);
            // 
            // Frm_AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(484, 70);
            this.Controls.Add(this.LinkTextAlertBox);
            this.Controls.Add(this.lb_Text);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AlertBox";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Frm_AlertBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Text;
        private System.Windows.Forms.Panel LinkTextAlertBox;
        private System.Windows.Forms.Timer timerAlertBox;
    }
}