using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBForm.Model
{
    [Table("Пациенты")]
    public class Patient
    {
        [Key]
        [Column("ID паниента")]
        public string Id { get; set; }
        [Column("Фамилия")]
        public string SureName { get; set; }
        [Column("Имя")]
        public string Name { get; set; }
        [Column("Отчество")]
        public string MiddleName { get; set; }
        [Column("Дата рождения")]
        public string BirthDate { get; set; }
        [Column("Телефон")]
        public string Phone { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
