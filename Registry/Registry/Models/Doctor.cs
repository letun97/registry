using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Identity;

namespace CustomIdentityApp.Models
{
    public class Doctor 
    {//база данных доктора
        [Key]
        public int DocId { get; set; }
        public string Famile { get; set; }//фамилия
        public string Name { get; set; }//имя
        public string Profession { get; set; } //професия
    }
}
