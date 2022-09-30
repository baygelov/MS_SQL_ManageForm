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
using System.Xml.Serialization;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;

namespace TestDBForm
{
    /// <summary>
    /// Interaction logic for FindVisit.xaml
    /// </summary>
    public partial class FindVisit : Window
    {
        public FindVisit()
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

        private List<Visit> showQueryData(int num)
        {
            string param = ParamBox.Text;
            string value = ValueTxt.Text;

            List<Visit> visits = DBLoader.SelectVisitQuery(param, value);
            VisitIDTxt.Text = visits[num].Id;
            VisitDateTxt.Text = visits[num].Date;
            DiagnosisTxt.Text = visits[num].Diagnosis;
            PatientIDTxt.Text = visits[num].PatientId;

            return visits;
        }
        private void FindVisitBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Visit> visits = showQueryData(number);
            int entryesCount = visits.Count;
            EntryesCountLbl.Content = $"{number + 1}/{entryesCount}";
        }

        private void NextEntryBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                number++;
                List<Visit> visits = showQueryData(number);
                int entryesCount = visits.Count;
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
                List<Visit> visits = showQueryData(number);
                int entryesCount = visits.Count;
                EntryesCountLbl.Content = $"{number + 1}/{entryesCount}";
            }
            catch (Exception ex)
            {
                number++;
                Console.WriteLine(ex);
            }

        }


        private void ToXML_Click(object sender, RoutedEventArgs e)
        {
            List<Visit> visits = showQueryData(number);
            using (var stream = new FileStream("C:\\Users\\bayge\\source\\repos\\MS_SQL_ManageForm\\Visits.xml", FileMode.Create))
            {
                var xml = new XElement("Visits", visits.Select(x => new XElement("visit",
                    new XAttribute("Id", x.Id),
                    new XAttribute("Дата_Посещения", x.Date),
                    new XAttribute("Диагноз", x.Diagnosis),
                    new XAttribute("Id_Пациента", x.PatientId))));
                xml.Save(stream);
            }
        }
    }
}
