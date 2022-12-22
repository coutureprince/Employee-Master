using System.Windows;
using WPFDB.BusinessLogic;
using WPFDB.Models;

namespace WPFDB.Views
{
    public partial class AddForm : Window
    {
        EmployeeService _employeeService = new EmployeeService();
        public AddForm()
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _employeeService.Add(new Employee { Name = TextBoxName.Text, Position = TextBoxPosition.Text, Salary = TextBoxSalary.Text });
            TextBoxName.Clear();
            TextBoxPosition.Clear();
            TextBoxSalary.Clear();
        }
    }
}