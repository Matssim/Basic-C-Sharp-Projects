using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsuranceContext _context;

        public InsureesController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }

        public decimal CalculateInsureeAgeQuote(Insuree insuree)
        {
            //Calculates the age of insuree
            DateTime today = DateTime.Today;
            DateTime birthdate = insuree.DateofBirth.ToDateTime(TimeOnly.MinValue);
            TimeSpan daysold = today - birthdate;
            int insureeAge = daysold.Days / 365;
            //Returns the amount commensurate to the insuree's age 
            if (insureeAge <= 18) return 100;
            else if (insureeAge <= 25) return 50;
            else return 25;
        }

        public decimal CalculateCarAgeQuote(Insuree insuree)
        {
            //Returns 25 if the car's year is before 2000 or after 2015
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015) return 25;
            else return 0;
        }

        public decimal CalculateCarTypeQuote(Insuree insuree)
        {
            //Returns 25 if the car is Porsche and 50 if it's a Porsche Carrerra
            if (insuree.CarMake.ToLower() == "porsche")
            {
                if (insuree.CarModel.ToLower() == "carrerra") return 50;
                else return 25;
            }
            else return 0;
        }

        public decimal CalculateFinalQuote(Insuree insuree)
        {
            //Calculates quote on basis of the insuree's age and the car specs.
            decimal insureeAgeQuote = CalculateInsureeAgeQuote(insuree);
            decimal carAgeQuote = CalculateCarAgeQuote(insuree);
            decimal carTypeQuote = CalculateCarTypeQuote(insuree);
            //Adds 10 to the quote for each speeding ticket
            decimal SpeedingTicketQuote = Convert.ToDecimal(insuree.SpeedingTickets) * 10;
            //Adds the above specs to the base of 50$
            decimal nonDUIQuote = 50 + insureeAgeQuote + carAgeQuote + carTypeQuote + SpeedingTicketQuote;
            //Adds 25% to the total if the insuree has a DUI
            if (insuree.DUI)
            {
                decimal baseQuote = nonDUIQuote * 1.25M;
                //Adds 50% to the total for a quote with a DUI and returns it if the insuree selects full coverage
                if (insuree.CoverageType.ToLower() == "full coverage") return baseQuote * 1.50M;
                //Returns the total quote with a DUI, but without full coverage
                else return baseQuote;
            }
            //Adds 50% to the total quote and returns it if the insuree selects full coverage
            else if (insuree.CoverageType.ToLower() == "full coverage") return nonDUIQuote * 1.50M;
            //Returns the total quote without a DUI, nor full coverage
            else return nonDUIQuote;
        }
    }
}
