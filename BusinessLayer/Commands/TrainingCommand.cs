using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class TrainingCommand
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public TrainingCommand(ContextFluent contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter la formation en base à partir du contexte
        /// </summary>
        /// <param name="e">formation à ajouter</param>
        /// <returns>Identifiant de la formation ajouté</returns>
        public int Add(Training e)
        {
            _contexte.Trainings.Add(e);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une formation déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="e">formation à modifier</param>
        public void Update(Training t)
        {
            Training upTra = _contexte.Trainings.Where(prd => prd.Id == e.Id).FirstOrDefault();
            if (upTra != null)
            {
                upTra.Title = t.Title;
                upTra.Date = t.Date;
                upTra.EmployeId = t.EmployeId;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une formation en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la formation à supprimer</param>
        public void Delete(int id)
        {
            Training delTra = _contexte.Trainings.Where(prd => prd.Id == id).FirstOrDefault();
            if (delTra != null)
            {
                _contexte.Trainings.Remove(delTra);
            }
            _contexte.SaveChanges();
        }
    }
}

