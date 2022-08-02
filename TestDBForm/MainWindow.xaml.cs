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

namespace TestDBForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }      

        private void AddEntryBtn_Click(object sender, RoutedEventArgs e)
        {

            if (TableSelectBox.Text == "Пациенты")
            {
                Patients patientsWintow = new Patients();
                Visibility = Visibility.Hidden;
                patientsWintow.Show();
            }

            if (TableSelectBox.Text == "Посещения")
            {
                Visits visitsWintow = new Visits();
                Visibility = Visibility.Hidden;
                visitsWintow.Show();
            }
            
        }

        private void FindEntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TableSelectBox.Text == "Пациенты")
            {
                FindPatient findPatientsWintow = new FindPatient();
                Visibility = Visibility.Hidden;
                findPatientsWintow.Show();
            }

            if (TableSelectBox.Text == "Посещения")
            {
                FindVisit findVisitsWintow = new FindVisit();
                Visibility = Visibility.Hidden;
                findVisitsWintow.Show();
            }

        }

    }
}
