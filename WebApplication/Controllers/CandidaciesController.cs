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
    public class CandidaciesController : Controller
    {
        private Manager manager;
        public CandidaciesController()
        {
            this.manager = Manager.Instance;
        }

        // GET: Candidacies
        public ActionResult Index()
        {
            // Recherche de toutes les candidatures de l'employé N 1
            List<Candidacy> candidacies = manager.GetAllCandidacyByEmployeeId(1);
            return View(candidacies);
        }

        // GET: Candidacies/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Candidacy candidacy = db.Candidacies.Find(id);
        //    if (candidacy == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(candidacy);
        //}

        //// GET: Candidacies/Create
        //public ActionResult Create()
        //{
        //    ViewBag.EmployeId = new SelectList(db.Employes, "Id", "Firstname");
        //    ViewBag.OfferId = new SelectList(db.Offers, "Id", "Title");
        //    return View();
        //}

        // POST: Candidacies/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "OfferId,EmployeId,Date,Status")] Candidacy candidacy)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Candidacies.Add(candidacy);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.EmployeId = new SelectList(db.Employes, "Id", "Firstname", candidacy.EmployeId);
        //    ViewBag.OfferId = new SelectList(db.Offers, "Id", "Title", candidacy.OfferId);
        //    return View(candidacy);
        //}

    }
}
