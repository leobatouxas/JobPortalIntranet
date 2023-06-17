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

        // POST: Candidacies/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OfferId,EmployeId,Date,Status")] Candidacy candidacy)
        {
            if (ModelState.IsValid)
            {
                manager.AddCandidacy(candidacy);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Offers");
        }

        // GET: Offers/Delete/5
        public ActionResult Delete(int? offerId, int? employeId)
        {
            if (offerId == null || employeId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidacy candidacy = manager.GetCandidacyById((int)employeId, (int)offerId);
            if (candidacy == null)
            {
                return HttpNotFound();
            }
            return View(candidacy);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int offerId, int employeId)
        {
            manager.DeleteCandidacy(employeId, offerId);
            return RedirectToAction("Index");
        }

    }
}
