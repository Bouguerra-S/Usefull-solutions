using MahApps.Metro.Controls;
using System;
using System.Windows.Threading;

namespace CountDownTimer
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public bool startstop=false;//starttrue
        public int remaingtime;

        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.IsEnabled = false;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (startstop)
            {

                lblTime.Content = TimeSpan.FromSeconds(remaingtime).ToString();
                //DateTime.Now.ToLongTimeString();
                remaingtime -= 1;
                if (remaingtime==-1)
                {
                    startstopbutton.Content = "Start";
                    startstop = false;
                    timer.Stop();
                    lblTime.Content = null;
                    TimerUp timerUp = new TimerUp();
                    timerUp.Show();
                }
            }
            else
            {

                lblTime.Content = null;
            }
        }

        private void startstopbutton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            remaingtime = (int)myHours.Value * 3600 + (int)myMinutes.Value * 60 + (int)mySeconds.Value;


            if (startstop)
            {
                startstopbutton.Content = "Start";
                startstop = false;
                timer.Stop();
                lblTime.Content = null;
            }
            else
            {
                startstopbutton.Content = "Stop";
                startstop = true;
                timer.Start();
                lblTime.Content = TimeSpan.FromSeconds(remaingtime).ToString();
            }
        }
    }
}
