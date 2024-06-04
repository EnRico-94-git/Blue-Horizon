using Microsoft.AspNetCore.Mvc;
using BlueHorizon.Models;
using BlueHorizon.Repositories;
using System.Threading.Tasks;

namespace BlueHorizon.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IRepository _repository;

        public AnimalController(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var animals = await _repository.GetAll<Animal>();
            return View(animals);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                await _repository.Add(animal);
                await _repository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var animal = await _repository.GetById<Animal>(id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _repository.Update(animal);
                await _repository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var animal = await _repository.GetById<Animal>(id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.Delete<Animal>(id);
            await _repository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
