using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebApi.Controllers
{
    public class UserPageController : Controller
    {
        // GET: UserPageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserPageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserPageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserPageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserPageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserPageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserPageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserPageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
