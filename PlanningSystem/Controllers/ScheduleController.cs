﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PlanningSystem.Controllers {
    public class ScheduleController : Controller {
        // GET: Schedule
        public ActionResult CreateClassroom() {
            //PlanningSysteemEntities context = new PlanningSysteemEntities();
            //List<Models.Schedule> CreateSchedule = new List<Models.Schedule>();
            //List<Schedule> schedule = context.Account.Where(a => a.isDisabled == false).ToList(); // list classnaam listnaam voorwaarde en ophalen

            //var context = new PlanningSysteemEntities();
            //List<Models.StudentClass> AllClasses = new List<Models.StudentClass>();
            //var studentclasses = context.StudentClass.ToList();

            //foreach (StudentClass i in studentclasses)
            //{
            //Models.StudentClass studentclass = new Models.StudentClass()
            //{
            //ClassID = i.ClassID
            //};
            //AllClasses.Add(studentclass);
            //}


            PlanningSysteemEntities context = new PlanningSysteemEntities();
            List<StudentClass> AllClasses = context.StudentClass.ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (StudentClass Classes in AllClasses)
                items.Add(new SelectListItem {
                    Text = Classes.ClassID,
                    Value = Classes.ClassID
                });
            ViewData["ListItemsStudentClasses"] = items;

            List<SchoolYears> AllYears = context.SchoolYears.ToList();
            List<SelectListItem> items2 = new List<SelectListItem>();
            foreach (SchoolYears years in AllYears)
                items2.Add(new SelectListItem
                {
                    Text = years.SchoolYear,
                    Value = years.SchoolYear
                });
            ViewData["ListItemsYears"] = items2;

            List<Months> AllMonths = context.Months.ToList();
            List<SelectListItem> items3 = new List<SelectListItem>();
            foreach (Months months in AllMonths)
                items3.Add(new SelectListItem
                {
                    Text = months.Month,
                    Value = months.Month
                });
            ViewData["ListItemsMonths"] = items3;

            return View();

            //return View(AllClasses);
        }

        [HttpPost]
        // POST: Account/Create
        public ActionResult CreateScheduleClassroom(Models.Schedule sched) {
            PlanningSysteemEntities context = new PlanningSysteemEntities();
            Schedule newSchedule = new Schedule {
                //Schoolyear = "18/19",
                SchoolYear = Request.Form["StudentYear"],
                Month = Request.Form["StudentMonth"],
                SchoolweekNumber = 22,
                Day = "Ma",
                courseId = 1,
                userId = 3, //sched.userId,
                

                
                //DayDate = "2018, 9, 10, 9, 0, 0",
                ClassroomID = "loka1",
                //username = account.username,
                //password = account.password,
                ClassID = Request.Form["StudentClass"]
                //firstLogin = account.firstLogin = true,
                //isResetted = account.isResetted = false,
                //createdAt = account.createdAt = DateTime.Now,
                //isDisabled = account.isDisabled = false
            };
            context.Schedule.Add(newSchedule);
            context.SaveChanges();
            return RedirectToAction("Overview", "Account");
        }
    }
}