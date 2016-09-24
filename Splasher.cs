using System.Windows;

namespace SplashDemo
{
    /// <summary>
    /// Helper to show or close given splash window
    /// </summary>
    public static class Splasher
    {
        /// <summary>
        /// 
        /// </summary>
        private static Window _mSplash;

        /// <summary>
        /// Get or set the splash screen window
        /// </summary>
        public static Window Splash
        {
            get
            {
                return _mSplash;
            }
            set
            {
                _mSplash = value;
            }
        }

        /// <summary>
        /// Show splash screen
        /// </summary>
        public static void ShowSplash ( )
        {
            _mSplash?.Show ();
        }
        /// <summary>
        /// Close splash screen
        /// </summary>
        public static void CloseSplash ( )
        {
            _mSplash?.Close ( );
        }
    }
}
