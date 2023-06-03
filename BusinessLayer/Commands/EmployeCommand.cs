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
        /// Ajouter l'employé en base à partir du contexte
        /// </summary>
        /// <param name="e">Employé à ajouter</param>
        /// <returns>Identifiant de l'employé ajouté</returns>
        public int Add(Employe e)
        {
            _contexte.Employes.Add(e);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un employé déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="e">Employé à modifier</param>
        public void Update(Employe e)
        {
            Employe upEmpl = _contexte.Employes.Where(prd => prd.Id == e.Id).FirstOrDefault();
            if (upEmpl != null)
            {
                upEmpl.Firstname = e.Firstname;
                upEmpl.Lastname = e.Lastname;
                upEmpl.Dateofbirth = e.Dateofbirth;
                upEmpl.Seniority = e.Seniority;
                upEmpl.Biography = e.Biography;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un employé en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="id">Identifiant de l'employé à supprimer</param>
        public void Delete(int id)
        {
            Employe delEmpl = _contexte.Employes.Where(prd => prd.Id == id).FirstOrDefault();
            if (delEmpl != null)
            {
                _contexte.Employes.Remove(delEmpl);
            }
            _contexte.SaveChanges();
        }
    }
}

