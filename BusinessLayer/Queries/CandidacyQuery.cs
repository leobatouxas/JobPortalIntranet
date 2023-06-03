using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class CandidacyQuery
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CandidacyQuery(ContextFluent contexte)
        {
            _contexte = contexte;
        }


        /// <summary>
        /// Récupérer toutes les Candidature
        /// </summary>
        /// <returns>IQueryable de Candidature</returns>
        public IQueryable<Candidacy> GetAll()
        {
            return _contexte.Candidacies;
        }

        /// <summary>
        /// Récupérer une Candidature par son ID
        /// </summary>
        /// <param name="id">Identifiant de la Candidature à récupérer</param>
        /// <returns>IQueryable de Candidature</returns>
        public IQueryable<Candidacy> GetByID(int EmployeId, int OfferId)
        {
            return _contexte.Candidacies.Where(p => p.EmployeId == EmployeId && p.OfferId == OfferId);
        }

    }
}
