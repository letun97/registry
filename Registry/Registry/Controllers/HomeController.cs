using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using CustomIdentityApp.ViewModels;
using Microsoft.AspNetCore.Identity;



namespace CustomIdentityApp.Controllers
{
    
    public class HomeController : Controller
    {

        ApplicationContext _context;
        
        public HomeController(ApplicationContext context)
        {
            _context = context;
        }
        //главная страница
        public IActionResult Index()
        {
            return View();
        }

        
        //список докторов
        public IActionResult ConDoctor()
       
        {
            var doctor = _context.Doctors.ToList();
            return View(doctor);
        }
        //________________________________
        //список докторов для просмотра заявок
        
        [Authorize(Roles = "doctor")]
        public IActionResult ConDoctorAut()
        {
            var doctor = _context.Doctors.ToList();
            return View(doctor);
        }
        //просмотр записаных к доктору пациентов
        
        [Authorize(Roles = "doctor")]
        [HttpGet]
        public IActionResult DocReception(int? id)
        {

            ViewBag.DoctorId = id;//отправка id в представление
            return View(_context.Receptions.ToList());
        }
        //Оформление заявки пациентом
        [HttpGet]
        public IActionResult Reception(int? id)
        {

            ViewBag.DoctorId = id;//отправка id в представление
            return View();
        }
        
        [HttpPost]
        public IActionResult Reception(Reception reception)
        {

            _context.Receptions.Add(reception);
            
            // сохраняем в бд все изменения
            _context.SaveChanges();
            return RedirectToAction("СomRec", reception);
        }
        //Сообщение о оформленой заявки
        [HttpGet]
        public IActionResult СomRec(Reception reception)
        {
            ViewBag.ReceptionDate = reception.ReceptionDate;
            ViewBag.Time = reception.Time;
            return View();
        }
        [HttpPost]
        public IActionResult СomRec()
        {

            return View("ConDoctor");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Help()
        {
            return View();
        }
    }
}
