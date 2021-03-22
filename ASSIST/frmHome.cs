using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ASSIST
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //=======================
        //Code for allowing borderless form to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void moveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
               
            }
        }

        //=======================

        //System icon procedures

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //=======================
        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect=new DBConnect();
            dBConnect.Insert("INSERT INTO tblSubject (tblSubjectID, tblSubjectName,tblSubjectGrade) VALUES(1,'gogo', 8)");

        }

        private void mouseHover(object sender, EventArgs e)
        {
           // btnAddTutor.Font = new Font(btnAddTutor.Font, FontStyle.Bold);
            //btnAddTutor.BackColor= Color.FromArgb(181, 229, 251);
        }

      
    }
}
