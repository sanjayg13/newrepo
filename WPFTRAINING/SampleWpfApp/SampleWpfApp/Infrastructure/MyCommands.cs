using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWpfApp.Infrastructure
{
    public static class MyCommands
    {
        private static RoutedUICommand _saveAs; // my custom command...
        private static RoutedUICommand _exit;
        // Invoked once and only once during the execution of program.
        static MyCommands()
        {
            InputGestureCollection collection = new InputGestureCollection();
            InputGestureCollection collection1 = new InputGestureCollection();
            collection.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl + B"));
            _saveAs = new RoutedUICommand("Save As", "SaveAs", typeof(MyCommands), collection);
            collection1.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl + E"));
            _exit = new RoutedUICommand("Exit", "Exit", typeof(MyCommands), collection1);
        }
        public static RoutedUICommand SaveAs => _saveAs;
        public static RoutedUICommand Exit => _exit;
    }
}
