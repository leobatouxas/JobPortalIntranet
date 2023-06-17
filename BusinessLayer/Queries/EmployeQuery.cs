using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class EmployeQuery
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public EmployeQuery(ContextFluent contexte)
        {
            _contexte = contexte;
        }


        /// <summary>
        /// Récupérer tous les employé
        /// </summary>
        /// <returns>IQueryable de employé</returns>
        public IQueryable<Employe> GetAll()
        {
            return _contexte.Employes;
        }

        /// <summary>
        /// Récupérer un employé par son ID
        /// </summary>
        /// <param name="id">Identifiant de l'employé à récupérer</param>
        /// <returns>IQueryable de Employe</returns>
        public IQueryable<Employe> GetByID(int id)
        {
            return _contexte.Employes.Where(p => p.Id == id).Include(c => c.Experiences).Include(c => c.Trainings);
        }

        /// <summary>
        /// Récupérer une Liste d'employé selon une recherche
        /// </summary>
        /// <param name="searchTerm">Termes de recherche</param>
        /// <returns>IQueryable de Employes</returns>
        public IQueryable<Employe> PerformSearch(string searchTerm)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                return _contexte.Employes.Where(o => o.Firstname.ToLower().Contains(searchTerm) ||
                                        o.Lastname.ToLower().Contains(searchTerm) ||
                                        o.Biography.ToLower().Contains(searchTerm));
            }
            else
            {
                return _contexte.Employes;
            }
        }

    }
}
