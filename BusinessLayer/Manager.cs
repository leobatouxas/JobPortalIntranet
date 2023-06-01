using BusinessLayer.Commands;
using BusinessLayer.Queries;
using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Manager
    {
        private readonly ContextFluent contexte;
        private static Manager _businessManager = null;

        /// <summary>
        /// Constructeur, initialisation du contexte EF
        /// </summary>
        private Manager()
        {
            contexte = new ContextFluent();
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static Manager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new Manager();
                return _businessManager;
            }
        }

        #region Employe

        /// <summary>
        /// Récupérer une liste de produit en base
        /// </summary>
        /// <returns>Liste de Produit</returns>
        public List<Employe> GetAllEmploye()
        {
            EmployeQuery pq = new EmployeQuery(contexte);
            return pq.GetAll().ToList();
        }

        /// <summary>
        /// Ajouter un produit en base
        /// </summary>
        /// <param name="e">Produit à ajouter</param>
        /// <returns>identifiant du nouveau produit</returns>
        public int AddEmploye(Employe e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            EmployeCommand ec = new EmployeCommand(contexte);
            return ec.Add(e);
        }

        ///// <summary>
        ///// Modifier un produit en base
        ///// </summary>
        ///// <param name="p">Produit à modifier</param>
        //public void ModifierProduit(Produit p)
        //{
        //    // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
        //    ProduitCommand pc = new ProduitCommand(contexte);
        //    pc.Modifier(p);
        //}

        ///// <summary>
        ///// Supprimer une produit en base
        ///// </summary>
        ///// <param name="produitID">Identifiant du produit à supprimer</param>
        //public void SupprimerProduit(int produitID)
        //{
        //    ProduitCommand pc = new ProduitCommand(contexte);
        //    pc.Supprimer(produitID);
        //}

        #endregion
    }
}
