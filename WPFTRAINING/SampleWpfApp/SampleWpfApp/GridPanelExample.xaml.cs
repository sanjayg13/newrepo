using System;
using System.Windows;
using System.Windows.Controls;
using SampleWpfApp.Models;
namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for GridPanelExample.xaml
    /// </summary>
    public partial class GridPanelExample : Window
    {
        static EmpRepository empDemo = new EmpRepository();
        public GridPanelExample()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstNames.ItemsSource = null;
            lstNames.ItemsSource = empDemo.GetAll();
            lstNames.DisplayMemberPath = "EmpName";
        }
        //This method is called when the User changes the selected Item...
        private void OnSelect(object sender, SelectionChangedEventArgs e)
        {
            var emp = lstNames.SelectedItem as Employee;
            if (emp == null)
            {
                MessageBox.Show("No Employee is selected");
                return;
            }
            txtName.Text = emp.EmpName;
            txtPhone.Text = emp.EmpContact.ToString();
            txtEmail.Text = emp.EmpAddress;
            txtSalary.Text = emp.EmpSalary.ToString();
        }

        private void OnSaveChanges(object sender, RoutedEventArgs e)
        {
            var emp = new Employee
            {
                EmpName = txtName.Text,
                EmpAddress = txtEmail.Text,
                EmpContact = long.Parse(txtPhone.Text),
                EmpSalary = int.Parse(txtSalary.Text)
                
            };
            var emp1 = lstNames.SelectedItem as Employee;
            emp.EmpID = emp1.EmpID;
            try
            {
                empDemo.UpdateEmployee(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}