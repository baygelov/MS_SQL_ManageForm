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
using Oracle.ManagedDataAccess.Client;

namespace TestDBForm
{
    /// <summary>
    /// Interaction logic for Visits.xaml
    /// </summary>
    public partial class Visits : Window
    {
        public Visits()
        {
            InitializeComponent();
        }

        private void AddVisitBtn_Click(object sender, RoutedEventArgs e)
        {
            string visitID = VisitIDTxt.Text;
            string visitDate = VisitDateTxt.Text;
            string diagnosis = DiagnosisTxt.Text;
            string patientID = PatientIDTxt.Text;

            DBLoader.InsertVisitQuery(visitID, visitDate, diagnosis, patientID);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
