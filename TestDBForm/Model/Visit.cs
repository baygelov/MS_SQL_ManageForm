using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBForm.Model
{
    public class Visit
    {
        [Key]
        public string Id { get; set; }
        public string Date { get; set; }
        public string Diagnosis { get; set; }
        public string PatientId { get; set; }

        public virtual Patient Patient { get; set; }

    }
}
