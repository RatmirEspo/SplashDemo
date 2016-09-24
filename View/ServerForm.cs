using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplashDemo.View
{
    public partial class ServerForm : Form
    {
        MainWindow fr;
        public ServerForm(MainWindow f)
        {
            InitializeComponent();
            fr = f;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            //notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Программа запущена";
            notifyIcon1.BalloonTipText = "СЕРВЕР ЗАПУЩЕН !!!";
            //notifyIcon1.ShowBalloonTip(100);
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr.Close();
            Application.Exit();

            /*this.Close();
            fr.Show();*/
        }
    }
}
