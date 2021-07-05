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

namespace SpeakingClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
      // System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();system.window
        System.Windows.Threading.DispatcherTimer dispachertimer = new System.Windows.Threading.DispatcherTimer();
        System.Speech.Synthesis.SpeechSynthesizer SpeakingClock = new System.Speech.Synthesis.SpeechSynthesizer();
        int minute = 0;
        int second = 0;

private void dispatcherTimer_Tick(object sender, EventArgs e)
{
  // code goes here
}
        public MainWindow()
        {
            InitializeComponent();
            dispachertimer.Tick+=new EventHandler(dispachertimer_Tick);
            dispachertimer.Interval = new TimeSpan(0,0,1);
            dispachertimer.Start();
            //dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //dispatcherTimer.Interval = new TimeSpan(0, 5, 0);
            //dispatcherTimer.Start();
        }

        private void dispachertimer_Tick(object sender, EventArgs e)
        {
           
            DateTime dt = DateTime.Now;
            second = second + 1;
            this.btnstartspeakingclock.Content = minute.ToString();
            if (minute < 59&& second==59)
            {
                SpeakingClock.Speak("You have Completed"+second+"Minute");
                
                minute = minute + 1;
                second = 0;
           }
        }
        private void btnstartspeakingclock_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
