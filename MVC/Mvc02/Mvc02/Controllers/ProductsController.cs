﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mvc02.Data;
using Mvc02.Models.Entities;
using Mvc02.Models.ViewModels;

namespace Mvc02.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //// GET: Products
        //public async Task<IActionResult> Index(int? id)
        //{
        //    var allProducts = _context.Product.Include(x => x.Category);
        //    if (id == null)
        //    {
        //        return View(await allProducts.ToListAsync());
        //    }
        //    else
        //    {
        //        return View(await allProducts.Where(x => x.CategoryId == id).ToListAsync());
        //    }
        //}

        // GET: Products
        public async Task<IActionResult> Index()
        {
            
            var xxx = await _context.Product.Include(x => x.Category).ToListAsync();
            return View(xxx);
        }

        public async Task<IActionResult> Search(string q)
        {
            var xxx = await _context.Product.Include(x => x.Category).Where(x => x.Name == q).ToListAsync();
            return View(xxx);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //ViewData["hello"] = "HELLO WORLD!";

            
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.Include(x => x.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            var viewmodel = new CreateProductVm();
            List<SelectListItem> test = new List<SelectListItem>();   

            var x = _context.Category;
            foreach (var item in x)
            {
                test.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString()});
            }
            viewmodel.AllCategories = test;

            return View(viewmodel);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,CategoryId,ForSale")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var vm = new EditProductVm();
            vm.Product = product;

            //List<SelectListItem> test = new List<SelectListItem>();
            //var x = _context.Category;
            //foreach (var item in x)
            //{
            //    test.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            //}

            vm.AllCategories = GetAllCategoriesAsSelectList();

            return View(vm);
        }

        private IEnumerable<SelectListItem> GetAllCategoriesAsSelectList()
        {
            List<SelectListItem> test = new List<SelectListItem>();
            var x = _context.Category;
            foreach (var item in x)
            {
                test.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }
            return test;
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,CategoryId,ForSale")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
