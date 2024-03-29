﻿using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {

        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;     
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        //Get : Cinemas/Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("Logo, Name, Description")] Cinema cinema)
        {

            if (!ModelState.IsValid)
            {
                return View(cinema);

            }

            await _service.AddAsync(cinema);

            return RedirectToAction(nameof(Index));

        }


        //Get: Cinemas/Details/1

        public async Task<ActionResult> Details(int id)
        {

            var cinemaDetails = await  _service.GetByIdAsync(id);

            if(cinemaDetails == null)
            {

                return View("Not found");
            }

            return View(cinemaDetails);
          

        }



        //Get: Cinemas/Edit/1

        public async Task<ActionResult> Edit(int id)
        {

            var cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
            {

                return View("Not found");
            }

            return View(cinemaDetails);


        }



        //Get:Cinema/Edit/1

        [HttpPost]

        public async Task<IActionResult> Edit(int id, [Bind("Id, Logo, Name, Description")] Cinema cinema)
        {

            if(!ModelState.IsValid)return View(cinema);
            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));

        }



        //Get: Cinemas/Delete/1

        public async Task<ActionResult> Delete(int id)
        {

            var cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
            {

                return View("Not found");
            }

            return View(cinemaDetails);


        }



        //Get:Cinema/Edit/1

        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirm(int id)
        {

            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
          
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }


    }
}
