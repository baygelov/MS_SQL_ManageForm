using System.Collections.Generic;
using System.Linq;
using TestDBForm.Model;

namespace TestDBForm
{
    public class DBLoader
    {
        // Add entry to Patients table
        public static void InsertPatientQuery(string id, string surename, string name, string middlename, string birthDate, string phone)
        {
            using (var context = new MyDbContext())
            {
                var patient = new Patient()
                {
                    Id = id,
                    SureName = surename,
                    Name = name,
                    MiddleName = middlename,
                    BirthDate = birthDate,
                    Phone = phone
                };
                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }
        // Add entry to Visits table
        public static void InsertVisitQuery(string Vid, string date, string diagnosis, string Pid)
        {
            
            using (var context = new MyDbContext())
            {
                var visit = new Visit()
                {
                    Id = Vid,
                    Date = date,
                    Diagnosis = diagnosis,
                    PatientId = Pid
                };

                context.Visits.Add(visit);
                context.SaveChanges();
            }
        }
        // Get entryes from Patient table
        public static List<Patient> SelectPatientQuery(string param, string value)
        {
            using (var context = new MyDbContext())
            {
                List<Patient> patients =
                    (
                    param == "ID паниента" ? 
                        context.Patients.Where(b => b.Id.Contains(value)).ToList() :
                    param == "Фамилия" ? 
                        context.Patients.Where(b => b.SureName.Contains(value)).ToList() :
                    param == "Имя" ? 
                        context.Patients.Where(b => b.Name.Contains(value)).ToList() :
                    param == "Отчество" ? 
                        context.Patients.Where(b => b.MiddleName.Contains(value)).ToList() :
                    param == "Дата рождения" ? 
                        context.Patients.Where(b => b.BirthDate.Contains(value)).ToList() :
                    param == "Телефон" ? 
                        context.Patients.Where(b => b.Phone.Contains(value)).ToList() : 
                        new List<Patient>()
                    );

                return patients;
            }
        }
        // Get entryes from Visits table
        public static List<Visit> SelectVisitQuery(string param, string value)
        {
            using (var context = new MyDbContext())
            {
                List<Visit> visits =
                    (
                    param == "ID посещения" ?
                        context.Visits.Where(b => b.Id.Contains(value)).ToList() :
                    param == "Дата посещения" ?
                        context.Visits.Where(b => b.Date.Contains(value)).ToList() :
                    param == "Диагноз" ?
                        context.Visits.Where(b => b.Diagnosis.Contains(value)).ToList() :
                    param == "ID пациента" ?
                        context.Visits.Where(b => b.PatientId.Contains(value)).ToList() :
                        new List<Visit>()
                    );

                return visits;
            }
        }
    }
}
