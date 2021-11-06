using HWMvcPartThree.Context;
using HWMvcPartThree.Models;
using HWMvcPartThree.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HWMvcPartThree.Controllers
{
    public class FoodController : Controller
    {
        private readonly MvcContextPThree _context;

        public FoodController(MvcContextPThree context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync(int cotegoriesId = 0)
        {
             var result = _context.foods.AsQueryable();
            if (cotegoriesId > 0) result = result.Where(p => p.FoodCategoryId == cotegoriesId).AsQueryable();
            var foodList = new List<FoodViewModel>();
            foreach (var food in await result.ToListAsync())
            {
                foodList.Add(new FoodViewModel
                {
                    Id = food.Id,
                    Cost = food.Cost,
                    InsertDate = food.InsertDate,
                    NameP  = food.NameP,
                    FoodCotegoryId = food.FoodCategoryId,
                    FoodCotegoryName = food.FoodCategory.Name
                });
            }
            return View(foodList);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var food = new FoodViewModel
            {
                Cotegories = await _context
                 .foodCategories
                 .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }).ToListAsync()
            };
            return View(food);
        }
        [HttpPost]
        public async Task<IActionResult> Create(FoodViewModel food, CancellationToken token)
        {
            if (!ModelState.IsValid)
            {
                food.Cotegories = await _context.foodCategories.
                    Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }).ToListAsync();
                return View(food);
            }
            var foodDB = new Food
            {
                Cost = food.Cost,
                NameP = food.NameP,
                FoodCategoryId = food.FoodCotegoryId,
                InsertDate = DateTime.UtcNow
            };
            food.InsertDate = DateTime.UtcNow;
            _context.foods.Add(foodDB);
            await _context.SaveChangesAsync(token);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var food = await _context.foods.FindAsync(id);
            if (food == null)
            {
                return RedirectToAction("Index");
            }
            var result = new FoodViewModel
            {
                Id = food.Id,
                Cost = food.Cost,
                FoodCotegoryId = food.FoodCategoryId,
                NameP = food.NameP,
                Cotegories = await _context.foodCategories.
                    Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }).ToListAsync()
            };
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(FoodViewModel foodModel)
        {
            if (!ModelState.IsValid)
            {
                foodModel.Cotegories = await _context.foodCategories.
                    Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }).ToListAsync();
                return View(foodModel);
            }
            var food = await _context.foods.FindAsync(foodModel.Id);
            if (foodModel == null)
            {
                return RedirectToAction("Index");
            }
            food.Cost = foodModel.Cost;
            food.NameP = foodModel.NameP;
            food.FoodCategoryId = foodModel.FoodCotegoryId;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var food = await _context.foods.FindAsync(id);
            if (food == null)
            {
                return RedirectToAction("Index");
            }
            _context.foods.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
