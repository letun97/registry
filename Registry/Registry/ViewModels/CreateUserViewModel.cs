using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentityApp.ViewModels
{
    public class CreateUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Year { get; set; }
        public string Famile { get; set; }//фамилия
        public string Name { get; set; }//имя
                                        // public bool Floor { get; set; } //пол
                                        // public DateTime? BirthDate { get; set; }//Дата рождения
        public int Phone { get; set; }//Телефон
        public string Address { get; set; }//Адрес
        public int Papers { get; set; }//Паспорт
        public int Policy { get; set; }// Полис
    }
}
