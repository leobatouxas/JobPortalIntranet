using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class OfferCommand
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public OfferCommand(ContextFluent contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter l'offre en base à partir du contexte
        /// </summary>
        /// <param name="e">offre à ajouter</param>
        /// <returns>Identifiant de la offre ajouté</returns>
        public int Add(Offer o)
        {
            _contexte.Trainings.Add(o);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une offre déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="e">offre à modifier</param>
        public void Update(Offer o)
        {
            Offer upOff = _contexte.Offers.Where(prd => prd.Id == e.Id).FirstOrDefault();
            if (upOff != null)
            {
                upOff.Title = o.Title;
                upOff.Description = o.Description;
                upOff.Date = o.Date;
                upOff.Salary = o.Salary;
                upOff.Responsible = o.Responsible;
                upOff.StatutId = o.StatutId;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une offre en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la offre à supprimer</param>
        public void Delete(int id)
        {
            Offer delOff = _contexte.Offers.Where(prd => prd.Id == id).FirstOrDefault();
            if (delOff != null)
            {
                _contexte.Offers.Remove(delOff);
            }
            _contexte.SaveChanges();
        }
    }
}

