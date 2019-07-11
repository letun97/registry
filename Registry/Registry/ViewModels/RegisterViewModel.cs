using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CustomIdentityApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Год рождения")]
        public DateTime? Year { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }

        //_____________________________________________________
        [Required]
        [Display(Name = "Фамилия")]
        public string Famile { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        public int Phone { get; set; }

       
        [Required]
        [Display(Name = "Адресс")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Номер и серия паспорта")]
        public int Papers { get; set; }

        [Required]
        [Display(Name = "Полис")]
        public int Policy { get; set; }

    }
}