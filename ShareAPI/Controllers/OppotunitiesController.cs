using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShareAPI.Models;

namespace ShareAPI.Controllers
{
    public class OppotunitiesController : Controller
    {
        private ShareAPIContext db = new ShareAPIContext();

        // GET: Oppotunities
        public async Task<ActionResult> Index()
        {
            var oppotunities = db.Oppotunities.Include(o => o.Category);
            return View(await oppotunities.ToListAsync());
        }

        // GET: Oppotunities/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oppotunity oppotunity = await db.Oppotunities.FindAsync(id);
            if (oppotunity == null)
            {
                return HttpNotFound();
            }
            return View(oppotunity);
        }

        // GET: Oppotunities/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "id", "CategoryName");
            return View();
        }

        // POST: Oppotunities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,Title,Description,Organisation,Venue,Eligibility,Province,Country,Deadline,CategoryID")] Oppotunity oppotunity)
        {
            if (ModelState.IsValid)
            {
                db.Oppotunities.Add(oppotunity);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "id", "CategoryName", oppotunity.CategoryID);
            return View(oppotunity);
        }

        // GET: Oppotunities/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oppotunity oppotunity = await db.Oppotunities.FindAsync(id);
            if (oppotunity == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "id", "CategoryName", oppotunity.CategoryID);
            return View(oppotunity);
        }

        // POST: Oppotunities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,Title,Description,Organisation,Venue,Eligibility,Province,Country,Deadline,CategoryID")] Oppotunity oppotunity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oppotunity).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "id", "CategoryName", oppotunity.CategoryID);
            return View(oppotunity);
        }

        // GET: Oppotunities/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oppotunity oppotunity = await db.Oppotunities.FindAsync(id);
            if (oppotunity == null)
            {
                return HttpNotFound();
            }
            return View(oppotunity);
        }

        // POST: Oppotunities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Oppotunity oppotunity = await db.Oppotunities.FindAsync(id);
            db.Oppotunities.Remove(oppotunity);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
