using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class EmployeCommand
    {
        private readonly ContextFluent _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public EmployeCommand(ContextFluent contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le produit en base à partir du contexte
        /// </summary>
        /// <param name="e">Produit à ajouter</param>
        /// <returns>Identifiant du produit ajouté</returns>
        public int Add(Employe e)
        {
            _contexte.Employes.Add(e);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un produit déjà présent en base à partir du cotnexte
        /// </summary>
        /// <param name="p">Produit à modifier</param>
        //public void Modify(Employe p)
        //{
        //    Employe upPrd = _contexte.Employes.Where(prd => prd.ID == p.ID).FirstOrDefault();
        //    if (upPrd != null)
        //    {
        //        upPrd.Nom = p.Nom;
        //        upPrd.CategorieID = p.CategorieID;
        //    }
        //    _contexte.SaveChanges();
        //}

        /// <summary>
        /// Supprimer un produit en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="produitID">Identifiant du produit à supprimer</param>
        //public void Supprimer(int produitID)
        //{
        //    Produit delPrd = _contexte.Produits.Where(prd => prd.ID == produitID).FirstOrDefault();
        //    if (delPrd != null)
        //    {
        //        _contexte.Produits.Remove(delPrd);
        //    }
        //    _contexte.SaveChanges();
        //}
    }
}

