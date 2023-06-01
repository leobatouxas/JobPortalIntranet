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

            //    ContextFluent contexte = new ContextFluent();

            //    // lecture des clients
            //    List<Employe> employes = contexte.Employes.ToList();
            Manager bm = Manager.Instance;
            Employe employe = new Employe();
            employe.Seniority = 1;
            employe.Lastname = "lastname 5";
            employe.Firstname = "firstname 5";
            employe.Dateofbirth = DateTime.Now;
            employe.Biography = "biographie 5";
            bm.AddEmploye(employe);

            List<Employe> employes = bm.GetAllEmploye();
            Console.WriteLine("Liste de mes clients avec DA : ");
            foreach (Employe c in employes)
            {
                Console.WriteLine("Client n°{0} : {1} {2}", c.Id, c.Firstname, c.Lastname);
            }

            Console.WriteLine(employes);
            Console.ReadLine();


            //Statut statut = new Statut();
            //statut.Id = 1;
            //statut.Libelle = "Libelle 1";
            //contexte.Statuts.Add(statut);


            //Offer offer = new Offer();
            //offer.Title = "Offer 1";
            //offer.Description = "descrition offer 1";
            //offer.Statut = statut;
            //offer.Responsible = "Responsible 1";
            //offer.Salary = 4500;
            //offer.Date = DateTime.Now;
            //contexte.Offers.Add(offer);

            //Employe employe = new Employe();
            //employe.Seniority = 1;
            //employe.Lastname = "lastname 1";
            //employe.Firstname = "firstname 1";
            //employe.Dateofbirth = DateTime.Now;
            //employe.Biography = "biographie 1";
            //contexte.Employes.Add(employe);

            //Experience experience = new Experience();
            //experience.Title = "experience 1";
            //experience.Date = DateTime.Now.AddDays(1);
            //experience.Employe = employe;
            //contexte.Experiences.Add(experience);

            //Training training = new Training();
            //training.Title = "title 1";
            //training.Date = DateTime.Now.AddDays(1);
            //training.Employe = employe;
            //contexte.Trainings.Add(training);

            //Candidacy candidacy = new Candidacy();
            //candidacy.Offer = offer;
            //candidacy.Employe = employe;
            //candidacy.Date = DateTime.Now.AddDays(1);
            //candidacy.Status = "Statut";
            //contexte.Candidacies.Add(candidacy);

            //contexte.SaveChanges();
            //Console.WriteLine("FINISH");
            //Console.ReadLine();



        }
    }
}
