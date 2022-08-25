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
using Microsoft.Win32;
using SampleWpfApp.Models;

namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for NotepadApp.xaml
    /// </summary>
    public partial class NotepadApp : Window
    {
        static string filename = string.Empty;
        public NotepadApp()
        {
            InitializeComponent();
        }

        // this method will open a filedialog 
        private void OnOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.ShowDialog();
            filename = dig.FileName;
            txtContent.Text = FileIO.ReadFile(filename);
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                SaveFileDialog dig = new SaveFileDialog();
                bool? fileInfo = dig.ShowDialog();
                filename = dig.FileName;
                if (fileInfo.Value == false)
                    return;
            }
                FileIO.WriteFile(filename, txtContent.Text);
                MessageBox.Show("File is saved to the System");
            
        }

        private void OnNew(object sender, RoutedEventArgs e)
        {
            filename = string.Empty;
            txtContent.Text = string.Empty; // Clear the old content and makes it blank.
        }

        private void OnSaveAs(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dig = new SaveFileDialog();
            bool? fileInfo = dig.ShowDialog();
            filename = dig.FileName;
            if (fileInfo.Value == false) return;
            FileIO.WriteFile(filename, txtContent.Text);
            MessageBox.Show("File is saved to the System");
        }

        private void OnExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
