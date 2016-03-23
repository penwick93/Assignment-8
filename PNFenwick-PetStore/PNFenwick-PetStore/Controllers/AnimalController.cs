using PNFenwick_PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNFenwick_PetStore.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        public ActionResult Manage()
        {
            AnimalContext context = new AnimalContext();
            List<Animal> Animals = context.Animals.ToList();
            return View(Animals);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                return View(animal);
            }
            try
            {
                AnimalContext context = new AnimalContext();
                context.Animals.Add(animal);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(animal);
            }

            TempData["Message"] = "Create" + animal.Name;

            return RedirectToAction("Manage");
        }
    }
}