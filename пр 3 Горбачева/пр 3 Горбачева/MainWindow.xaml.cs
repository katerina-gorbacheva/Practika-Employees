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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace пр_3_Горбачева
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Employee> Employees { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Employees = new List<Employee>();
            EmployeesDataGrid.ItemsSource = Employees;
        }

        private void AddEmployeeButton_Clik(object sender, RoutedEventArgs e)
        {
            string employeeName = EmployeeNameTextBox.Text;
            string employeePost = EmployeePostTextBox.Text;
            string employeeZarpataText = EmployeeZarpataTextBox.Text;
            decimal employeeZarpata;


            if (decimal.TryParse(employeeZarpataText, out employeeZarpata))
            {
                Employees.Add(new Employee
                {
                    EmployeeName = EmployeeNameTextBox.Text,
                    EmployeePost = EmployeePostTextBox.Text,
                    EmployeeZarpata = employeeZarpata


                });



                EmployeeNameTextBox.Clear();
                EmployeePostTextBox.Clear();
                EmployeeZarpataTextBox.Clear();
            }
            else
            {

                MessageBox.Show("Зарплата должна быть числом.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public class Employee
        {
            public string EmployeeName { get; set; }
            public string EmployeePost { get; set; }
            public decimal EmployeeZarpata { get; set; }
        }
    }

}

