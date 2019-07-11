using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CustomIdentityApp.Models
{
    public class Reception
    {
        [Key]
        public int ReceptionId { get; set; }
        public DateTime? ReceptionDate { get; set; }//дата заявки (год, месяц, день)


        public int Time { get; set; } //время заявки (часы)
        public int Doctor { get; set; }//Id доктора

        public string Patient { get; set; }//Id пациента
    }
}
