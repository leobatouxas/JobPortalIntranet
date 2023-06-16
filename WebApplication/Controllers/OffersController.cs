using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using JobPortalIntranetLibraryClass.modeleFluent;

namespace WebApplication.Controllers
{
    public class OffersController : Controller
    {
        private Manager manager;
        public OffersController()
        {
            this.manager = Manager.Instance;
        }

        // GET: Offers
        public ActionResult Index()
        {
            List<Offer> offers = manager.GetAllOffer();
            return View(offers);
        }

        // GET: Offers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            } 
            
            Offer offer = manager.GetOfferById((int)id);

            if (offer == null)
            {
                return HttpNotFound();
            }
            return View(offer);
        }

        // GET: Offers/Create
        public ActionResult Create()
        {
            ViewBag.StatutId = new SelectList(manager.GetAllStatut(), "Id", "Libelle");
            return View();
        }

        // POST: Offers/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,Date,Salary,Responsible,StatutId")] Offer offer)
        {
            if (ModelState.IsValid)
            {
                manager.AddOffer(offer);
                return RedirectToAction("Index");
            }

            ViewBag.StatutId = new SelectList(manager.GetAllStatut(), "Id", "Libelle", offer.StatutId);
            return View(offer);
        }

        // GET: Offers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offer offer = manager.GetOfferById((int)id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            ViewBag.StatutId = new SelectList(manager.GetAllStatut(), "Id", "Libelle", offer.StatutId);
            return View(offer);
        }

        // POST: Offers/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,Date,Salary,Responsible,StatutId")] Offer offer)
        {
            if (ModelState.IsValid)
            {
                manager.UpdateOffer(offer);
                return RedirectToAction("Index");
            }
            ViewBag.StatutId = new SelectList(manager.GetAllStatut(), "Id", "Libelle", offer.StatutId);
            return View(offer);
        }

        // GET: Offers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offer offer = manager.GetOfferById((int)id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            return View(offer);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            manager.DeleteOffer(id);
            return RedirectToAction("Index");
        }
    }
}
