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
    /// Interaction logic for Patients.xaml
    /// </summary>
    public partial class Patients : Window
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void AddPacientBtn_Click(object sender, RoutedEventArgs e)
        {
            string patientID = PatientIDTxt.Text;
            string patientSurename = PatientSureNameTxt.Text;
            string patientName = PatientNameTxt.Text;
            string patientMiddlename = PatientMiddleNameTxt.Text;
            string patientBirthDate = PatientBirthDateTxt.Text;
            string patientPhone = PatientPhoneTxt.Text;
            DBLoader.InsertPatientQuery(patientID, patientSurename, patientName, patientMiddlename, patientBirthDate, patientPhone);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
