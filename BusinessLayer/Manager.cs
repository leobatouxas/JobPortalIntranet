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
        /// Récupérer une liste d'employé en base
        /// </summary>
        /// <returns>Liste d'employé</returns>
        public List<Employe> GetAllEmploye()
        {
            EmployeQuery pq = new EmployeQuery(contexte);
            return pq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une liste d'employé en fonction d'une recherche
        /// </summary>
        /// /// <param name="searchTerm">termes de recherche</param>
        /// <returns>Liste d'employé</returns>
        public List<Employe> PerformSearchEmploye(string searchTerm)
        {
            EmployeQuery oq = new EmployeQuery(contexte);
            return oq.PerformSearch(searchTerm).ToList();
        }

        /// <summary>
        /// Récupérer un employé en base
        /// </summary>
        /// <param name="id">id de l'employé à ajouter</param>
        /// <returns>Un employé</returns>
        public Employe GetEmployeById(int id)
        {
            EmployeQuery eq = new EmployeQuery(contexte);
            return eq.GetByID(id).First();
        }

        /// <summary>
        /// Ajouter un Employé en base
        /// </summary>
        /// <param name="e">Employé à ajouter</param>
        /// <returns>identifiant du nouvelle employé</returns>
        public int AddEmploye(Employe e)
        {
            // TODO : ajouter des contrôles sur l'employé (exemple : vérification de champ, etc.)
            EmployeCommand ec = new EmployeCommand(contexte);
            return ec.Add(e);
        }

        /// <summary>
        /// Modifier un employé en base
        /// </summary>
        /// <param name="e">Employé à modifier</param>
        public void UpdateEmploye(Employe e)
        {
            // TODO : ajouter des contrôles sur l'employé (exemple : vérification de champ, etc.)
            EmployeCommand ec = new EmployeCommand(contexte);
            ec.Update(e);
        }

        /// <summary>
        /// Supprimer un employé en base
        /// </summary>
        /// <param name="id">Identifiant de l'employé à supprimer</param>
        public void DeleteEmploye(int id)
        {
            EmployeCommand ec = new EmployeCommand(contexte);
            ec.Delete(id);
        }

        #endregion

        #region Experience

        /// <summary>
        /// Récupérer une liste d'experience en base
        /// </summary>
        /// <returns>Liste d'employé</returns>
        public List<Experience> GetAllExperience()
        {
            ExperienceQuery eq = new ExperienceQuery(contexte);
            return eq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une experience en base
        /// </summary>
        /// <param name="id">id de l'experience à ajouter</param>
        /// <returns>Une experience</returns>
        public Experience GetExperienceById(int id)
        {
            ExperienceQuery eq = new ExperienceQuery(contexte);
            return eq.GetByID(id).First();
        }

        /// <summary>
        /// Ajouter une Experience en base
        /// </summary>
        /// <param name="e">Experience à ajouter</param>
        /// <returns>identifiant de la nouvelle Experience</returns>
        public int AddExperience(Experience e)
        {
            // TODO : ajouter des contrôles sur l'employé (exemple : vérification de champ, etc.)
            ExperienceCommand ec = new ExperienceCommand(contexte);
            return ec.Add(e);
        }

        /// <summary>
        /// Modifier une Experience en base
        /// </summary>
        /// <param name="e">Experience à modifier</param>
        public void UpdateExperience(Experience e)
        {
            // TODO : ajouter des contrôles sur l'Experience (exemple : vérification de champ, etc.)
            ExperienceCommand ec = new ExperienceCommand(contexte);
            ec.Update(e);
        }

        /// <summary>
        /// Supprimer une experience en base
        /// </summary>
        /// <param name="id">Identifiant de l'expérience à supprimer</param>
        public void DeleteExperience(int id)
        {
            ExperienceCommand ec = new ExperienceCommand(contexte);
            ec.Delete(id);
        }

        #endregion

        #region Formation
        /// <summary>
        /// Récupérer une liste de Formation en base
        /// </summary>
        /// <returns>Liste de Formation</returns>
        public List<Training> GetAllTraining()
        {
            TrainingQuery eq = new TrainingQuery(contexte);
            return eq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une Formation en base
        /// </summary>
        /// <param name="id">id de la formation à ajouter</param>
        /// <returns>Une Formation</returns>
        public Training GetTrainingById(int id)
        {
            TrainingQuery tq = new TrainingQuery(contexte);
            return tq.GetByID(id).First();
        }

        /// <summary>
        /// Ajouter une Formation en base
        /// </summary>
        /// <param name="t">Formation à ajouter</param>
        /// <returns>identifiant de la nouvelle Formation</returns>
        public int AddTraining(Training t)
        {
            // TODO : ajouter des contrôles sur la formation (exemple : vérification de champ, etc.)
            TrainingCommand tc = new TrainingCommand(contexte);
            return tc.Add(t);
        }

        /// <summary>
        /// Modifier une Formation en base
        /// </summary>
        /// <param name="t">Formation à modifier</param>
        public void UpdateTraining(Training t)
        {
            // TODO : ajouter des contrôles sur l'Experience (exemple : vérification de champ, etc.)
            TrainingCommand tc = new TrainingCommand(contexte);
            tc.Update(t);
        }

        /// <summary>
        /// Supprimer un Formation en base
        /// </summary>
        /// <param name="id">Identifiant de la Formation à supprimer</param>
        public void DeleteTraining(int id)
        {
            TrainingCommand tc = new TrainingCommand(contexte);
            tc.Delete(id);
        }
        #endregion

        #region Candidacy
        /// <summary>
        /// Récupérer une liste de Candidature en base
        /// </summary>
        /// <returns>Liste de Candidature</returns>
        public List<Candidacy> GetAllCandidacy()
        {
            CandidacyQuery cq = new CandidacyQuery(contexte);
            return cq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une Candidature en base
        /// </summary>
        /// <param name="id">id de la Candidature à ajouter</param>
        /// <returns>Une Candidature</returns>
        public Candidacy GetCandidacyById(int EmployeId, int OfferId)
        {
            CandidacyQuery cq = new CandidacyQuery(contexte);
            return cq.GetByID(EmployeId, OfferId).First();
        }

        /// <summary>
        /// Ajouter une Candidature en base
        /// </summary>
        /// <param name="c">Candidature à ajouter</param>
        /// <returns>identifiant de la nouvelle Candidature</returns>
        public int AddCandidacy(Candidacy c)
        {
            // TODO : ajouter des contrôles sur la Candidature (exemple : vérification de champ, etc.)
            CandidacyCommand cc = new CandidacyCommand(contexte);
            return cc.Add(c);
        }

        /// <summary>
        /// Modifier une Candidature en base
        /// </summary>
        /// <param name="">Candidature à modifier</param>
        public void UpdateCandidacy(Candidacy c)
        {
            // TODO : ajouter des contrôles sur l'Experience (exemple : vérification de champ, etc.)
            CandidacyCommand cc = new CandidacyCommand(contexte);
            cc.Update(c);
        }

        /// <summary>
        /// Supprimer un Candidature en base
        /// </summary>
        /// <param name="id">Identifiant de la Candidature à supprimer</param>
        public void DeleteCandidacy(int EmployeId, int OfferId)
        {
            CandidacyCommand cc = new CandidacyCommand(contexte);
            cc.Delete(EmployeId, OfferId);
        }
        #endregion

        #region Offer
        /// <summary>
        /// Récupérer une liste d'offre en base
        /// </summary>
        /// <returns>Liste d'offre</returns>
        public List<Offer> GetAllOffer()
        {
            OfferQuery oq = new OfferQuery(contexte);
            return oq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une liste d'offre en fonction d'une recherche
        /// </summary>
        /// /// <param name="searchTerm">termes de recherche</param>
        /// <returns>Liste d'offre</returns>
        public List<Offer> PerformSearchOffer(string searchTerm)
        {
            OfferQuery oq = new OfferQuery(contexte);
            return oq.PerformSearch(searchTerm).ToList();
        }

        /// <summary>
        /// Récupérer une offre en base
        /// </summary>
        /// <param name="id">id de l'offre à ajouter</param>
        /// <returns>Une offre</returns>
        public Offer GetOfferById(int id)
        {
            OfferQuery oq = new OfferQuery(contexte);
            return oq.GetByID(id).First();
        }

        /// <summary>
        /// Ajouter une offre en base
        /// </summary>
        /// <param name="c">offre à ajouter</param>
        /// <returns>identifiant de la nouvelle offre</returns>
        public int AddOffer(Offer o)
        {
            // TODO : ajouter des contrôles sur l'offre (exemple : vérification de champ, etc.)
            OfferCommand oc = new OfferCommand(contexte);
            return oc.Add(o);
        }

        /// <summary>
        /// Modifier une offre en base
        /// </summary>
        /// <param name="o">offre à modifier</param>
        public void UpdateOffer(Offer o)
        {
            // TODO : ajouter des contrôles sur l'offre (exemple : vérification de champ, etc.)
            OfferCommand oc = new OfferCommand(contexte);
            oc.Update(o);
        }

        /// <summary>
        /// Supprimer un offre en base
        /// </summary>
        /// <param name="id">Identifiant de l'offre à supprimer</param>
        public void DeleteOffer(int id)
        {
            OfferCommand oc = new OfferCommand(contexte);
            oc.Delete(id);
        }
        #endregion

        #region Statut
        /// <summary>
        /// Récupérer une liste de statut en base
        /// </summary>
        /// <returns>Liste de statut</returns>
        public List<Statut> GetAllStatut()
        {
            StatutQuery sq = new StatutQuery(contexte);
            return sq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une statut en base
        /// </summary>
        /// <param name="id">id du statut à ajouter</param>
        /// <returns>Une statut</returns>
        public Statut GetStatutById(int id)
        {
            StatutQuery sq = new StatutQuery(contexte);
            return sq.GetByID(id).First();
        }

        /// <summary>
        /// Ajouter un statut en base
        /// </summary>
        /// <param name="c">statut à ajouter</param>
        /// <returns>identifiant du nouveau statut </returns>
        public int AddStatut(Statut s)
        {
            // TODO : ajouter des contrôles sur l'offre (exemple : vérification de champ, etc.)
            StatutCommand sc = new StatutCommand(contexte);
            return sc.Add(s);
        }

        /// <summary>
        /// Modifier un statut en base
        /// </summary>
        /// <param name="o">statut à modifier</param>
        public void UpdateStatut(Statut s)
        {
            // TODO : ajouter des contrôles sur l'offre (exemple : vérification de champ, etc.)
            StatutCommand sc = new StatutCommand(contexte);
            sc.Update(s);
        }

        /// <summary>
        /// Supprimer un statut en base
        /// </summary>
        /// <param name="id">Identifiant du statut à supprimer</param>
        public void DeleteStatut(int id)
        {
            StatutCommand oc = new StatutCommand(contexte);
            oc.Delete(id);
        }
        #endregion

    }
}
