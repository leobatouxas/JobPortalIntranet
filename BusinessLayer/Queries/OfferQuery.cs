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

    }
}
