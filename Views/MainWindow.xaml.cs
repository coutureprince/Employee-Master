using System.Windows;
using System.Windows.Controls;
using WPFDB.Models;
using WPFDB.BusinessLogic;
using WPFDB.Views;

namespace WPFDB
{
    public partial class MainWindow : Window
    {
        EmployeeService _employeeService = new EmployeeService();
                
        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = _employeeService.Get();
        }
        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
        }
        private void UpdateData_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = _employeeService.Get();
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItems.Count > 0 && MessageBox.Show("Подтвержение удаления", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                for (int i = 0; i < DataGrid.SelectedItems.Count; i++)
                {
                    Employee? employee = DataGrid.SelectedItems[i] as Employee;
                    if (employee != null)
                    {
                        _employeeService.Delete(employee);
                    }
                }
            }
        }
        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DataGrid.SelectedItems.Count; i++)
                {
                    Employee? employee = DataGrid.SelectedItems[i] as Employee;
                    if (employee != null)
                    {
                        UpdateForm update = new UpdateForm();
                        update.ShowData(employee);
                        update.Show();
                    }
                }
            }
        }
    }
}