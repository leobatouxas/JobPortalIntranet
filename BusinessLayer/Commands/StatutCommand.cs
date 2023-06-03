using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class StatutCommand
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public StatutCommand(ContextFluent contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le statut en base à partir du contexte
        /// </summary>
        /// <param name="s">statut à ajouter</param>
        /// <returns>Identifiant de la statut ajouté</returns>
        public int Add(Statut s)
        {
            _contexte.Statuts.Add(s);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un statut déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="s">statut à modifier</param>
        public void Update(Statut s)
        {
            Statut upSta = _contexte.Statuts.Where(prd => prd.Id == s.Id).FirstOrDefault();
            if (upSta != null)
            {
                upSta.Libelle = s.Libelle;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un statut en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="id">Identifiant du statut à supprimer</param>
        public void Delete(int id)
        {
            Statut delSta = _contexte.Statuts.Where(prd => prd.Id == id).FirstOrDefault();
            if (delSta != null)
            {
                _contexte.Statuts.Remove(delSta);
            }
            _contexte.SaveChanges();
        }
    }
}

