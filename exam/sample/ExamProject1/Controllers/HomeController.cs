using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamProject1.Models;

namespace ExamProject1.Controllers
{
    public class HomeController : Controller
    {
        private CarDataEntities db = new CarDataEntities();

        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude ="Id")] Car carToAdd)
        {
            try
            {
                db.Cars.Add(carToAdd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult List()
        {
            try
            {
                // TODO: Add display data logic here

                return View();
            }
            catch
            {
                return RedirectToAction("Create");
            }
        }
    }
}
