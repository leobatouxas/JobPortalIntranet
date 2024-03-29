﻿using System;
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
    public class EmployesController : Controller
    {

        private Manager manager;

        public EmployesController()
        {
            this.manager = Manager.Instance;
        }

        // GET: Employes
        public ActionResult Index(string searchTerm)
        {
            // Effectuer la recherche et obtenir les résultats
            List<Employe> searchResults = manager.PerformSearchEmploye(searchTerm);

            // Afficher les résultats de recherche
            return View(searchResults);
        }

        // GET: Employes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employe employe = manager.GetEmployeById((int)id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            return View(employe);
        }
    }
}
