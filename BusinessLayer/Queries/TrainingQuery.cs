using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class TrainingQuery
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public TrainingQuery(ContextFluent contexte)
        {
            _contexte = contexte;
        }


        /// <summary>
        /// Récupérer toutes les formations
        /// </summary>
        /// <returns>IQueryable de formations</returns>
        public IQueryable<Training> GetAll()
        {
            return _contexte.Trainings;
        }

        /// <summary>
        /// Récupérer une formation par son ID
        /// </summary>
        /// <param name="id">Identifiant de la formation à récupérer</param>
        /// <returns>IQueryable de Formation</returns>
        public IQueryable<Training> GetByID(int id)
        {
            return _contexte.Trainings.Where(p => p.Id == id);
        }

    }
}
