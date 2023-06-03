using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class StatutQuery
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public StatutQuery(ContextFluent contexte)
        {
            _contexte = contexte;
        }


        /// <summary>
        /// Récupérer tout les statuts
        /// </summary>
        /// <returns>IQueryable de statuts</returns>
        public IQueryable<Statut> GetAll()
        {
            return _contexte.Statuts;
        }

        /// <summary>
        /// Récupérer un statuts par son ID
        /// </summary>
        /// <param name="id">Identifiant de la statut à récupérer</param>
        /// <returns>IQueryable de statut</returns>
        public IQueryable<Statut> GetByID(int id)
        {
            return _contexte.Statuts.Where(p => p.Id == id);
        }
    }
}
