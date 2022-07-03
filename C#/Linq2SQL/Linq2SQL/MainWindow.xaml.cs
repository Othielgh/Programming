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
using System.Configuration;

namespace Linq2SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Linq2SQL.Properties.Settings.TutorialDBConnectionString1"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

        }


        public void InsertUniversities_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                University uni = new University();
                //Console.WriteLine("Please enter a University to add to the list: ");
                uni.Name = myTextBox.Text;
                dataContext.Universities.InsertOnSubmit(uni);
                dataContext.SubmitChanges();

                MainDataGrid.ItemsSource = dataContext.Universities;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            } 

        }

        public void InsertStudents_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Student student = new Student();
                //Console.WriteLine("Please enter a Student to add to the list: ");
                student.Name = myTextBox.Text;
                dataContext.Students.InsertOnSubmit(student);
                dataContext.SubmitChanges();

                MainDataGrid.ItemsSource = dataContext.Universities;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
