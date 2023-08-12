using Alfasoft.Application.Services;
using Alfasoft.Domain.Interfaces.Services;
using Alfasoft.Domain.Models;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<ActionResult> IndexAsync()
        {
            try
            {
                return View(await _contactService.GetAll());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ActionResult> DetailsAsync(int Id)
        {
            return View(await _contactService.GetById(Id));
        }

        public async Task<ActionResult> CreateAsync()
        {
            var entity = new ContactModel();
            entity.Restcointries = await _contactService.GetRestcountriesList();
            return View(entity);
        }

        public async Task<ActionResult> EditAsync(int Id)
        {
            return View(await _contactService.GetById(Id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactModel entity)
        {
            try
            {
                _contactService.Insert(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContactModel entity)
        {
            try
            {
                _contactService.Update(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> DeleteAsync(ContactModel entity)
        {
            try
            {
                await _contactService.DeleteAsync(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}