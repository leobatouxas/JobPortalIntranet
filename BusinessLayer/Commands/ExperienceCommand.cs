using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class ExperienceCommand
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ExperienceCommand(ContextFluent contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter l'expérience en base à partir du contexte
        /// </summary>
        /// <param name="e">expérience à ajouter</param>
        /// <returns>Identifiant de l'expérience ajouté</returns>
        public int Add(Experience e)
        {
            _contexte.Experiences.Add(e);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une Expérience déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="e">Expérience à modifier</param>
        public void Update(Experience e)
        {
            Experience upExp = _contexte.Experiences.Where(prd => prd.Id == e.Id).FirstOrDefault();
            if (upExp != null)
            {
                upExp.Title = e.Title;
                upExp.Date = e.Date;
                upExp.EmployeId = e.EmployeId;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une Expérience en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="id">Identifiant de l'Expérience à supprimer</param>
        public void Delete(int id)
        {
            Experience delExp = _contexte.Experiences.Where(prd => prd.Id == id).FirstOrDefault();
            if (delExp != null)
            {
                _contexte.Experiences.Remove(delExp);
            }
            _contexte.SaveChanges();
        }
    }
}

