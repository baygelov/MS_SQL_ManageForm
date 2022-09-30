using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestDBForm.Model
{
    [XmlRoot("PersonenListe")]
    [XmlInclude(typeof(Visit))]
    [Table("Посещения")]
    public class Visit
    {
        [Key]
        [Column("ID посещения")]
        public string Id { get; set; }
        [Column("Дата посещения")]
        public string Date { get; set; }
        [Column("Диагноз")]
        public string Diagnosis { get; set; }
        [Column("ID пациента")]
        public string PatientId { get; set; }

        public virtual Patient Patient { get; set; }

    }
}
