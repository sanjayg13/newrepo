using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for EventHandling.xaml
    /// </summary>
    public partial class EventHandling : Window
    {
        private int eventCounter = 0;
        public EventHandling()
        {
            InitializeComponent();
        }
        // Events in Wpf are of 2 types: Bubbling and Tunneling. Bubbling is more like a water bubble which funnels up to Above Element
        // while it handles in the current
        // Tunneling is where the Event is triggered from top to bottom.
        // Bubbling is more like a water bubble which moves towards the upper direction, so that event is called as Bubbling Event.
        // All Events in Wpf are Bubbling Events Tunnelling events are those with a prefix called preview.m
        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            eventCounter++;
            string msg = string.Format($"Counter# {eventCounter}: \r\n");
            msg += string.Format("sender:{0} \r\n Source: {1}\r\n OriginalSource:{2}\r\n", sender, e.Source, e.OriginalSource);
            lstMessages.Items.Add(msg);
            e.Handled = (bool)ckHandled.IsChecked;
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            lstMessages.Items.Clear();
            eventCounter = 0;
        }

        private void BeforeMouseUp(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("About to Click the " + e.Source);
            Thread.Sleep(1000);
        }
    }
}
