using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using JobPortalIntranetLibraryClass.modeleFluent;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContextFluent contexte = new ContextFluent();
            Statut statut = new Statut();
            statut.Id = 1;
            statut.Libelle = "Libelle 1";
            contexte.Statuts.Add(statut);
            contexte.SaveChanges();
            Console.WriteLine("FINISH");
            Console.ReadLine();
        }
    }
}
