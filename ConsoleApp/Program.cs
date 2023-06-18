using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using JobPortalIntranetLibraryClass.modeleFluent;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Manager bm = Manager.Instance;

            #region employe
            Employe employe = new Employe();
            employe.Seniority = 15;
            employe.Lastname = "Doe";
            employe.Firstname = "John";
            employe.Dateofbirth = DateTime.Now;
            employe.Biography = "biographie de John Doe";

            Employe employe2 = new Employe();
            employe2.Seniority = 2;
            employe2.Lastname = "Doe";
            employe2.Firstname = "Jane";
            employe2.Dateofbirth = DateTime.Now;
            employe2.Biography = "biographie de Jane Doe";

            Employe employe3 = new Employe();
            employe3.Seniority = 5;
            employe3.Lastname = "Doe";
            employe3.Firstname = "Alex";
            employe3.Dateofbirth = DateTime.Now;
            employe3.Biography = "biographie de Alex Doe";

            bm.AddEmploye(employe);
            bm.AddEmploye(employe2);
            bm.AddEmploye(employe3);

            Console.WriteLine("Employé Ajouté");
            #endregion

            #region Training
            Training training = new Training();
            training.Title = "Training 1";
            training.Date = DateTime.Now.AddDays(1);
            training.Employe = employe;

            Training training2 = new Training();
            training2.Title = "Training 2";
            training2.Date = DateTime.Now.AddDays(1);
            training2.Employe = employe;

            Training training3 = new Training();
            training3.Title = "Training 1";
            training3.Date = DateTime.Now.AddDays(1);
            training3.Employe = employe2;

            bm.AddTraining(training);
            bm.AddTraining(training2);
            bm.AddTraining(training3);

            Console.WriteLine("Training Ajouté");
            #endregion

            #region Experience

            Experience experience = new Experience();
            experience.Title = "experience 1";
            experience.Date = DateTime.Now;
            experience.Employe = employe;

            Experience experience2 = new Experience();
            experience2.Title = "experience 2";
            experience2.Date = DateTime.Now;
            experience2.Employe = employe;

            Experience experience3 = new Experience();
            experience3.Title = "experience 3";
            experience3.Date = DateTime.Now;
            experience3.Employe = employe3;

            bm.AddExperience(experience);
            bm.AddExperience(experience2);
            bm.AddExperience(experience3);

            Console.WriteLine("Expérience ajouté");
            #endregion

            #region statut
            Statut statut = new Statut();
            statut.Libelle = "Statut 1";

            Statut statut2 = new Statut();
            statut2.Libelle = "Statut 2";

            Statut statut3 = new Statut();
            statut3.Libelle = "Statut 3";

            bm.AddStatut(statut);
            bm.AddStatut(statut2);
            bm.AddStatut(statut3);

            Console.WriteLine("Statut Ajouté");
            #endregion

            #region Offers

            Offer offer = new Offer();
            offer.Title = "Offer 1";
            offer.Description = "description offer 1";
            offer.Statut = statut;
            offer.Responsible = "Responsible 1";
            offer.Salary = 4500;
            offer.Date = DateTime.Now;

            Offer offer2 = new Offer();
            offer2.Title = "Offer 2";
            offer2.Description = "description offer 2";
            offer2.Statut = statut2;
            offer2.Responsible = "Responsible 2";
            offer2.Salary = 5500;
            offer2.Date = DateTime.Now;

            Offer offer3 = new Offer();
            offer3.Title = "Offer 3";
            offer3.Description = "description offer 3";
            offer3.Statut = statut;
            offer3.Responsible = "Responsible 3";
            offer3.Salary = 2500;
            offer3.Date = DateTime.Now;

            Offer offer4 = new Offer();
            offer4.Title = "Offer 4";
            offer4.Description = "description offer 4";
            offer4.Statut = statut2;
            offer4.Responsible = "Responsible 4";
            offer4.Salary = 1500;
            offer4.Date = DateTime.Now;

            Offer offer5 = new Offer();
            offer5.Title = "Offer 5";
            offer5.Description = "description offer 5";
            offer5.Statut = statut3;
            offer5.Responsible = "Responsible 1";
            offer5.Salary = 1500;
            offer5.Date = DateTime.Now;


            bm.AddOffer(offer);
            bm.AddOffer(offer2);
            bm.AddOffer(offer3);
            bm.AddOffer(offer4);
            bm.AddOffer(offer5);

            Console.WriteLine("Offers ajouté");
            #endregion

            #region Candidacies
            
            Candidacy candidacy = new Candidacy();
            candidacy.Offer = offer;
            candidacy.Employe = employe3;
            candidacy.Status = "En Cours";
            candidacy.Date = DateTime.Now;

            Candidacy candidacy2 = new Candidacy();
            candidacy2.Offer = offer2;
            candidacy2.Employe = employe3;
            candidacy2.Status = "En Cours";
            candidacy2.Date = DateTime.Now;

            Candidacy candidacy3 = new Candidacy();
            candidacy3.Offer = offer;
            candidacy3.Employe = employe;
            candidacy3.Status = "En Cours";
            candidacy3.Date = DateTime.Now;

            Candidacy candidacy4 = new Candidacy();
            candidacy4.Offer = offer4;
            candidacy4.Employe = employe2;
            candidacy4.Status = "En Cours";
            candidacy4.Date = DateTime.Now;

            bm.AddCandidacy(candidacy);
            bm.AddCandidacy(candidacy2);
            bm.AddCandidacy(candidacy3);
            bm.AddCandidacy(candidacy4);


            Console.WriteLine("Candidacy ajouté");
            #endregion

            #region list
            //Console.WriteLine("Liste des offres ");

            //List<Offer> offers = bm.GetAllOffer();
            //Console.WriteLine("Liste de mes clients avec DA : ");
            //foreach (Offer c in offers)
            //{
            //    Console.WriteLine("Offre n°{0}", c.Id);
            //}
            #endregion
            Console.WriteLine("FINISH");
            Console.ReadLine();
        }
    }
}
