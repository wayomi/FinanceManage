using FinanceManage.Data;
using FinanceManage.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManage.Controllers
{
    public class IncomeController : Controller
    {
        private readonly ApplicataionDbContext _db;

        public object DateManager { get; private set; }

        public IncomeController (ApplicataionDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Income> objList = _db.Incomes;
            return View(objList);
            
        }
        
        //Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Post Create
        [HttpPost]
        public IActionResult Create(Income obj)
        {

            _db.Incomes.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

       
        // GET Delete       
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Incomes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? IncomeId)
        {
            var obj = _db.Incomes.Find(IncomeId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Incomes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET Update       
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Incomes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //Post Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Income obj)
        {

            _db.Incomes.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
