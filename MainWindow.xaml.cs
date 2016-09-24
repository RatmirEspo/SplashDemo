using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SplashDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( )
        {
            InitializeComponent ( );
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Тут проверка авторизации
            bool flag = SplashDemo.Properties.Settings.Default.FirstStart;
            if (flag)
            {
                View.ServerForm sf = new View.ServerForm(this);
                sf.Show();
                this.Hide();
            }
            else
            {
                View.SetingForm setForm = new View.SetingForm(this);
                setForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
