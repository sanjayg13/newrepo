using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
/*
 * Triggers are sp kind of actions which can be done on elements of the window. With Trigger we could anticipate the action and
 * perform some changes to the UI of the window.
 * There are 3 kinds of triggers:
 * 1. Property Triggers: Raised when a certain property changes
 * 2. Event Triggers: Actions are done on the object.
 * 3. Data Triggers: When the associated source of data modifies.
 */
namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for Trigger.xaml
    /// </summary>
    public partial class Trigger : Window
    {
        public Trigger()
        {
            InitializeComponent();
        }
    }
}
