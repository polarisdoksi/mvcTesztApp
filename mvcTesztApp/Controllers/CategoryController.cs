using Microsoft.AspNetCore.Mvc;
using mvcTesztApp.Data;
using mvcTesztApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcTesztApp.Controllers
{
    /// <summary>
    /// tpalee
    /// </summary>
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <returns>View</returns>
        public IActionResult Create()
        {
            return View();
        } 
        
        /// <summary>
        /// GET
        /// </summary>
        /// <returns>View</returns>
        public IActionResult CreateG()
        {
            return View();
        } 
        
        /// <summary>
        /// POST
        /// </summary>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        /// <summary>
        /// GET-EDIT
        /// </summary>
        /// <returns>View</returns>
        public IActionResult Edit(int? id)
        {
            if (id==null || id ==0)
            {
                return NotFound();
            }
            var obj = _db.Category.Find(id);
            if (obj==null)
            {
                return NotFound();
            }
            return View(obj);
        }

        /// <summary>
        /// POST-EDIT
        /// </summary>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        /// <summary>
        /// GET-DELETE
        /// </summary>
        /// <returns>View</returns>
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        /// <summary>
        /// POST-Delete
        /// </summary>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Category.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.Category.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}
