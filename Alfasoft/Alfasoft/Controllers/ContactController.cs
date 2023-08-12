using Alfasoft.Models;
using ContactManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Alfasoft.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        public readonly IContactService _contactService;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        // GET: ContactController
        public ActionResult Index()
        {
            return View(_contactService.GetAll());
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int Id)
        {
            return View(_contactService.GetById(Id));
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create
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

        // GET: ContactController/Edit/5
        public ActionResult Edit(int Id)
        {
            return View(_contactService.GetById(Id));
        }

        // POST: ContactController/Edit/5
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

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactController/Delete/5
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