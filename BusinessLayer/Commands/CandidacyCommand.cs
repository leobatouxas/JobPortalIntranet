using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class CandidacyCommand
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CandidacyCommand(ContextFluent contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter la candidature en base à partir du contexte
        /// </summary>
        /// <param name="c">candidature à ajouter</param>
        /// <returns>Identifiant de la candidature ajouté</returns>
        public int Add(Candidacy c)
        {
            _contexte.Candidacies.Add(c);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une candidature déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="e">candidature à modifier</param>
        public void Update(Candidacy c)
        {
            Candidacy upCan = _contexte.Candidacies.Where(prd => prd.id == c.id).FirstOrDefault();
            if (upCan != null)
            {
                upCan.OfferId = c.OfferId;
                upCan.EmployeId = c.EmployeId;
                upCan.Date = c.Date;
                upCan.Status = c.Status;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une candidature en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la candidature à supprimer</param>
        public void Delete(int id)
        {
            Candidacy delCan = _contexte.Candidacies.Where(prd => prd.id == id).FirstOrDefault();
            if (delCan != null)
            {
                _contexte.Candidacies.Remove(delCan);
            }
            _contexte.SaveChanges();
        }
    }
}

