using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBForm.Model
{
    public class Patient
    {
        [Key]
        public string Id { get; set; }
        public string SureName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
