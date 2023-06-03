using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class ExperienceQuery
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ExperienceQuery(ContextFluent contexte)
        {
            _contexte = contexte;
        }


        /// <summary>
        /// Récupérer toutes les experiences
        /// </summary>
        /// <returns>IQueryable de l'expérience</returns>
        public IQueryable<Experience> GetAll()
        {
            return _contexte.Experiences;
        }

        /// <summary>
        /// Récupérer une expérience par son ID
        /// </summary>
        /// <param name="id">Identifiant de l'expérience à récupérer</param>
        /// <returns>IQueryable de l'expérience</returns>
        public IQueryable<Experience> GetByID(int id)
        {
            return _contexte.Experiences.Where(p => p.Id == id);
        }
    }
}
