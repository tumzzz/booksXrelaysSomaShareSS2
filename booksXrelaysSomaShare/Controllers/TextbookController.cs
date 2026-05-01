using booksXrelaysSomaShare.Data;
using booksXrelaysSomaShare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace booksXrelaysSomaShare.Controllers
{
    public class TextbookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TextbookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string search, decimal? minPrice, decimal? maxPrice)
        {
            var textbooks = _context.Textbooks.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                textbooks = textbooks.Where(t =>
                    t.Title.Contains(search) ||
                    t.Author.Contains(search) ||
                    t.ISBN.Contains(search) ||
                    t.Module.Contains(search));
            }


            return View(await textbooks.ToListAsync());
        }

        //Create

        public IActionResult Create()
        {
            return View();
        }

        // Post for Textbook

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TextBookID,Title,Author,Description,ISBN,Module,Price,ListingDate")] Textbook textbook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(textbook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(textbook);
        }



        // Employee Edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbook = await _context.Textbooks.FindAsync(id);
            if (textbook == null)
            {
                return NotFound();
            }

            return View(textbook);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("TextBookID, Title, Author, Description, ISBN, Module, Price, ListingDate")] Textbook textbook)
        {
            if (id != textbook.TextBookID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(textbook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextbookExist(textbook.TextBookID))
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
            return View(textbook);
        }


        // Textbook delete

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbook = await _context.Textbooks
                .FirstOrDefaultAsync(m => m.TextBookID == id);
            if (textbook == null)
            {
                return NotFound();
            }

            return View(textbook);
        }

        // Post Textbook delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult>DeleteConfirmed(int id)

        {
            var textbook = await _context.Textbooks.FindAsync(id);
            if (textbook == null)
            {
                return NotFound();
            }

            _context.Textbooks.Remove(textbook);
            await _context.SaveChangesAsync();

            // redirect to index

            return RedirectToAction(nameof(Index));
        }

        private bool TextbookExist(int id)
        {
            return _context.Textbooks.Any(e => e.TextBookID == id);
        }
    } 
}

//Added Textbook CRUD functionality for Seller

//Implemented authorization and restricted access based on roles