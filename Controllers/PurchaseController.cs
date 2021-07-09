using FinanceManage.Data;
using FinanceManage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManage.Controllers
{
    public class PurchaseController : Controller
    {

        private readonly ApplicataionDbContext _db;

        public PurchaseController(ApplicataionDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Purchase> objList = _db.Purchases;
            ViewBag.SupplierName = new SelectList(_db.Items,"ItemName");
            return View(objList);
        }

        //Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Post Create
        [HttpPost]
        public IActionResult Create(Purchase obj)
        {

            _db.Purchases.Add(obj);
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
            var obj = _db.Purchases.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //Post Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Purchase obj)
        {

            _db.Purchases.Update(obj);
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
            var obj = _db.Purchases.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? purchaseId)
        {
            var obj = _db.Purchases.Find(purchaseId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Purchases.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
