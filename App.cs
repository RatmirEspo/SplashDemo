using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading;

namespace SplashDemo
{
    /// <summary>
    ///Main 
    /// </summary>
    internal class App: Application
    {
        /// <summary>
        /// 
        /// </summary>
        [STAThread ()]
        private static void Main ()
        {
            Splasher.Splash = new SplashScreen ();
            Splasher.ShowSplash ();

            //Здесь будет проверка модулей при загрузке
            for ( var i = 0; i < 1000; i++ )
            {
                MessageListener.Instance.ReceiveMessage($"Load module {i}");
                Thread.Sleep (1);
            }
            /////////////////////////////////////////////

            Splasher.CloseSplash();
            new App ();
        }
         /// <summary>
        /// 
        /// </summary>
        public App ()
        {         
            StartupUri = new System.Uri ( "MainWindow.xaml", UriKind.Relative );
            Run ();            
        }
    }
}
