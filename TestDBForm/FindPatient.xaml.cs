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
using System.Xml.Linq;
using System.IO;
using TestDBForm.Model;

namespace TestDBForm
{
    /// <summary>
    /// Interaction logic for FindPatient.xaml
    /// </summary>
    public partial class FindPatient : Window
    {
        public FindPatient()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
        int number = 0;

        private List<Patient> showQueryData(int num)
        {
            string param = ParamBox.Text;
            string value = ValueTxt.Text;
           
            List<Patient> patients = DBLoader.SelectPatientQuery(param, value);
            PatientIDTxt.Text = patients[num].Id;
            PatientSureNameTxt.Text = patients[num].SureName;
            PatientNameTxt.Text = patients[num].Name;
            PatientMiddleNameTxt.Text = patients[num].MiddleName;
            PatientBirthDateTxt.Text = patients[num].BirthDate;
            PatientPhoneTxt.Text = patients[num].Phone;

            return patients;
        }
        private void FindPacientBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Patient> patients = showQueryData(number);
            int entryesCount = patients.Count;
            EntryesCountLbl.Content = $"{number + 1}/{entryesCount}";
        }

        private void NextEntryBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                number++;
                List<Patient> patients = showQueryData(number);
                int entryesCount = patients.Count;
                EntryesCountLbl.Content = $"{number + 1}/{entryesCount}";
            }
            catch (Exception ex)
            {
                number--;
                Console.WriteLine(ex);
            }
        }

        private void PreviousEntryBtn_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                number--;
                List<Patient> patients = showQueryData(number);
                int entryesCount = patients.Count;
                EntryesCountLbl.Content = $"{number+1}/{entryesCount}";
            }
            catch (Exception ex)
            {
                number++;
                Console.WriteLine(ex);
            }
        }

        private void ToXML_Click(object sender, RoutedEventArgs e)
        {
            List<Patient> visits = showQueryData(number);
            using (var stream = new FileStream("C:\\Users\\bayge\\source\\repos\\MS_SQL_ManageForm\\Visits.xml", FileMode.Create))
            {
                var xml = new XElement("Visits", visits.Select(x => new XElement("visit",
                    new XAttribute("Id", x.Id),
                    new XAttribute("Фамилия", x.SureName),
                    new XAttribute("Имя", x.Name),
                    new XAttribute("Отчество", x.MiddleName),
                    new XAttribute("Дата_рождения", x.BirthDate),
                    new XAttribute("Телефон", x.Phone))));
                xml.Save(stream);
            }
        }
    }
}
