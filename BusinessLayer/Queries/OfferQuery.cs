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
    public class OfferQuery
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public OfferQuery(ContextFluent contexte)
        {
            _contexte = contexte;
        }


        /// <summary>
        /// Récupérer toutes les Offres
        /// </summary>
        /// <returns>IQueryable de Offre</returns>
        public IQueryable<Offer> GetAll()
        {
            return _contexte.Offers;
        }

        /// <summary>
        /// Récupérer une Offre par son ID
        /// </summary>
        /// <param name="id">Identifiant de la Offre à récupérer</param>
        /// <returns>IQueryable de Offre</returns>
        public IQueryable<Offer> GetByID(int id)
        {
            return _contexte.Offers.Where(p => p.Id == id).Include(c => c.Candidacies).Include(c => c.Candidacies.Select(e => e.Employe));
        }

        /// <summary>
        /// Récupérer une Liste d'offre selon une recherche
        /// </summary>
        /// <param name="searchTerm">Termes de recherche</param>
        /// <returns>IQueryable de Offre</returns>
        public IQueryable<Offer> PerformSearch(string searchTerm)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                return _contexte.Offers.Where(o => o.Title.ToLower().Contains(searchTerm) ||
                                        o.Description.ToLower().Contains(searchTerm) ||
                                        o.Responsible.ToLower().Contains(searchTerm));
            }
            else
            {
                return _contexte.Offers;
            }
        }
    }
}
