using System.Windows;
using WPFDB.BusinessLogic;
using WPFDB.Models;

namespace WPFDB.Views
{
    public partial class UpdateForm : Window
    {
        EmployeeService _employeeService = new EmployeeService();
        Employee _employeeToUpdate;
        public UpdateForm()
        {
            InitializeComponent();
        }
        public void ShowData(Employee employee)
        {
            TextBoxName.Text = employee.Name;
            TextBoxPosition.Text = employee.Position;
            TextBoxSalary.Text = employee.Salary;
            _employeeToUpdate = employee;
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            _employeeToUpdate.Name = TextBoxName.Text;
            _employeeToUpdate.Position = TextBoxPosition.Text;
            _employeeToUpdate.Salary = TextBoxSalary.Text;
            _employeeService.Update(_employeeToUpdate);
            Close();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}