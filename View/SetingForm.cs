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
    public partial class SetingForm : Form
    {
        private MainWindow f;
        public SetingForm(MainWindow f)
        {
            InitializeComponent();
            this.f = f;
        }
        
        private void SetingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}
