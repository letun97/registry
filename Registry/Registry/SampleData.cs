using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomIdentityApp.Models;

namespace CustomIdentityApp
{
    public class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Doctors.Any())
            {
                context.Doctors.AddRange(
                    new Doctor
                    {
                        //DocId = Guid.NewGuid(),
                        Famile = "Иванов",
                        Name = "Иван",
                        Profession = "Терапевт",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Иванов",
                        Name = "Петр",
                        Profession = "Хирург",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Курякова",
                        Name = "Татьяна",
                        Profession = "Инфекционист",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Свеклушина",
                        Name = "Светлана",
                        Profession = "Нарколог",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Емельянова",
                        Name = "Екатерина",
                        Profession = "Невролог",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Петров",
                        Name = "Николай",
                        Profession = "Неотложная помощь",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Зайцева",
                        Name = "Эльза",
                        Profession = "Онколог",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Лобанов",
                        Name = "Виктор",
                        Profession = "Оторинголог",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Золотухина",
                        Name = "Анастасия",
                        Profession = "Офтальмолог",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Потапова",
                        Name = "Надежда",
                        Profession = "Психиатор",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Лебеев",
                        Name = "Данил",
                        Profession = "Стоматология",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Зарубина",
                        Name = "Наталия",
                        Profession = "Уролог",
                    },
                    new Doctor
                    {
                        //DocId =Guid.NewGuid(),
                        Famile = "Черепанова",
                        Name = "Мария",
                        Profession = "Эндокринолог",
                    }
                );
                context.SaveChanges();
            }
        }
    }

}
