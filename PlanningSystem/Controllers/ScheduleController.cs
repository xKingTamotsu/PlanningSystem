﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PlanningSystem.Controllers {
    public class ScheduleController : Controller {
        // GET: Schedule
        public ActionResult CreateSchedule() {


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

            List<SchoolWeekNumber> AllWeeks = context.SchoolWeekNumber.ToList();
            List<SelectListItem> items4 = new List<SelectListItem>();
            foreach (SchoolWeekNumber weeks in AllWeeks)
                items4.Add(new SelectListItem
                {
                    Text = weeks.NumberOfTheWeek.ToString(),
                    Value = weeks.NumberOfTheWeek.ToString()
                });
            ViewData["ListItemsWeeks"] = items4;

            List<DaysOfTheWeek> AllDays = context.DaysOfTheWeek.ToList();
            List<SelectListItem> items5 = new List<SelectListItem>();
            foreach (DaysOfTheWeek days in AllDays)
                items5.Add(new SelectListItem
                {
                    Text = days.Day,
                    Value = days.Day
                });
            ViewData["ListItemsDays"] = items5;

            List<Account> AllUsers = context.Account.ToList();
            List<SelectListItem> items6 = new List<SelectListItem>();
            foreach (Account users in AllUsers)
                items6.Add(new SelectListItem
                {
                    Text = users.name,
                    Value = users.name
                });
            ViewData["ListItemsTeachers"] = items6;

            List<Course> AllCourses = context.Course.ToList();
            List<SelectListItem> items7 = new List<SelectListItem>();
            foreach (Course courses in AllCourses)
                items7.Add(new SelectListItem
                {
                    Text = courses.courseName,
                    Value = courses.courseName
                });
            ViewData["ListItemsCourses"] = items7;

            List<Classroom> AllClassrooms = context.Classroom.ToList();
            List<SelectListItem> items8 = new List<SelectListItem>();
            foreach (Classroom classrooms in AllClassrooms)
                items8.Add(new SelectListItem
                {
                    Text = classrooms.ClassroomID.ToString(),
                    Value = classrooms.ClassroomID.ToString()
                });
            ViewData["ListItemsClassrooms"] = items8;

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
                SchoolWeekNumber = int.Parse(Request.Form["StudentWeek"]),
                Day = Request.Form["StudentDay"],
                Teacher = (Request.Form["Teachers"]),
                courseName = (Request.Form["Courses"]),
                ClassroomID = Request.Form["Classrooms"],
                //userId = 3, //sched.userId,



                //DayDate = "2018, 9, 10, 9, 0, 0",
                //ClassroomID = "loka1",
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