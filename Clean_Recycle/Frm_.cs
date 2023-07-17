using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clean_Recycle
{
    public partial class Frm_AlertBox : Form
    {
        public static string Name_scriptc;
        public Frm_AlertBox()
        {
            InitializeComponent();
        }

        public string TitleAlertBox
        {
            get { return lb_Title.Text; }
            set { lb_Title.Text = value; }
        }

        public string TextAlertBox
        {
            get { return lb_Text.Text; }
            set { lb_Text.Text = value; }
        }

        private void PositionAlertBox()
        {
            int xPos = 0; int yPos = 0;
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);
        }

        private void Frm_AlertBox_Load(object sender, EventArgs e)
        {
            PositionAlertBox();
            for (int i = 0; i < 500; i++)
            {
                timerAlertBox.Start();
            }
        }

        private void timerAlertBox_Tick(object sender, EventArgs e)
        {
            LinkTextAlertBox.Width = LinkTextAlertBox.Width + 2;
            if (LinkTextAlertBox.Width >= 490)
            { this.Hide(); }
            if (LinkTextAlertBox.Width >= 470)
            { TextAlertBox = Frm_Clean.thongbao_hile; }
            else { TextAlertBox = Name_scriptc + " đang thực hiện."; }
        }
    }
}
