using Alfasoft.Domain.Interfaces.Services;
using Alfasoft.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alfasoft.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        public readonly IPersonService _personService;

        public PersonController(ILogger<ContactController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public async Task<ActionResult> IndexAsync()
        {
            try
            {
                return View(await _personService.GetAll());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ActionResult> DetailsAsync(int Id)
        {
            return View(await _personService.GetById(Id));
        }

        public ActionResult Create()
        {
            return View();
        }

        public async Task<ActionResult> EditAsync(int Id)
        {
            return View(await _personService.GetById(Id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel entity)
        {
            try
            {
                _personService.Insert(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonModel entity)
        {
            try
            {
                _personService.Update(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> DeleteAsync(PersonModel entity)
        {
            try
            {
                await _personService.DeleteAsync(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}