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
 * Resources in Wpf are external files or data that is used to enhance the look and feel of the application.
 * Resources are of 2 types: Object Resources and Assembly Resources.
 * Object Resources are reusable components or objects that can be used across the Application like objects of a class.
 * U could create an instance and associate its property thro path.
 * Assembly resources are the resources that are part of the Assembly and will be loaded by the Wpf before the application is executed.
 * All Xaml files will be assembly resources for the application.
 * The Xaml files are compiled to BAML Files(Binary Markup language Files) which are loaded as Assembly resources for Application.
 * Among Object Resources, U could create a resource in 2 ways: static and Dynamic.
 * 
 */
namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for Resources.xaml
    /// </summary>
    public partial class Resources : Window
    {
        public Resources()
        {
            InitializeComponent();
        }
    }
}
