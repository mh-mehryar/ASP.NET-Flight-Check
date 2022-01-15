using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Flight.Models;
using Flight;


namespace Flight
{
    public class HomeController : Controller
    {
        public readonly Connect _Connect;
        public static Flight_info f_id;
        public static User u_id;
        public HomeController(Connect Connect)
        {
            _Connect = Connect;
        }

        // public IActionResult Index()
        // {
        //     var flight_List = _Connect.flights_tbl.ToList();

        //     return View(flight_List);
        // }
        [HttpPost]
        public IActionResult Index(String SearchText)
        {


            if (SearchText != "" && SearchText != null)
            {

                var fl = _Connect.flights_tbl.Where(i => i.Flight_Date == SearchText.ToGeorgianDateTime()).ToList();
                return View(fl);
            }

            return View();
        }

        public IActionResult Index()
        {
            var f2 = _Connect.flights_tbl.Where(i => i.Capacity > 0).ToList();
            return View(f2);
        }
        //GET
        public IActionResult Add_Flight()
        {

            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add_Flight(Flight_info fl)
        {
            // Flight_info fly = new Flight_info()
            // {
            //     Flight_Date = fl.Flight_Date,
            //     Flight_Time = fl.Flight_Time,
            //     Airline = fl.Airline,
            //     From = fl.From,
            //     To = fl.To,
            //     Capacity = fl.Capacity,
            // };


            _Connect.flights_tbl.Add(fl);
            _Connect.SaveChanges();

            // return View();
            return RedirectToAction("Index");
        }


        public IActionResult Reserve(int id)
        {
            var res = _Connect.flights_tbl.Where(a => a.Id == id).SingleOrDefault();

            f_id = res;

            // return View(res);

            return View("reserve");
        }
        // [HttpGet]
        // public IActionResult login()
        // {
        //     return View();
        // }
        [HttpPost]
        public IActionResult login_check(User user)
        {
            bool IsPhoneValid = _Connect.users_tbl.Any(u => u.Phone_Number == user.Phone_Number);

            if (IsPhoneValid)
            {
                u_id = _Connect.users_tbl.Where(u => u.Phone_Number == user.Phone_Number).SingleOrDefault();
                return View("login");
            }
            else
            {
                return View("register");
            }
        }
        public IActionResult login_check_all(User user)
        {
            bool IsPhoneValid = _Connect.users_tbl.Any(u => u.Phone_Number == user.Phone_Number);
            bool IsPasswordValid = _Connect.users_tbl.Any(u => u.Password == user.Password);
            if (IsPhoneValid && IsPasswordValid)
            {
                u_id = _Connect.users_tbl.Where(u => u.Phone_Number == user.Phone_Number).SingleOrDefault();
                return View("payment");
            }
            else
            {
                // return View("login_error");
                ViewBag.login_Error = "You Enterd Wrong Password";
                return View("login");
            }

        }

        public IActionResult Register(User user)
        {
            user.Name = user.Name;
            user.Family = user.Family;
            user.Identity_Number = user.Identity_Number;
            user.Phone_Number = user.Phone_Number;
            user.Password = user.Password;


            _Connect.users_tbl.Add(user);
            _Connect.SaveChanges();

            u_id = _Connect.users_tbl.Where(u => u.Phone_Number == user.Phone_Number).SingleOrDefault();

            return View("payment");

        }
        public IActionResult Payment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Payment(int a)
        {
            Reserve rev = new Reserve();
            rev.Flight_Id = f_id.Id;
            rev.Passenger_Id = u_id.Id;

            _Connect.reserves_tbl.Add(rev);
            _Connect.SaveChanges();

            return View();
        }




    }
}
