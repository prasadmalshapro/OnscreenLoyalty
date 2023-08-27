using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnscreenLoyalty
{
    public partial class Form1 : Form
    {
        private const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }


        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x112 && (int)m.WParam == SC_CLOSE)
        //    {
        //        return; 
        //    }

        //    base.WndProc(ref m);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            Left = screenWidth - 300;
            Top = screenHeight - 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(); 
            customer.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle == FormBorderStyle.None ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
        }
    }
}
