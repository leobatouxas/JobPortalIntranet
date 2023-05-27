using System;
using JobPortalIntranetLibraryClass.modeleFluent;

class Program
{
    static void Main()
    {
        using (var contexte = new ContextFluent())
        {
            var statut = new Statut();
            statut.Id = 1;
            statut.Libelle = "libelle 1";
            Console.WriteLine("test");
            contexte.Statuts.Add(statut);
            Console.WriteLine(statut.Libelle);
            Console.WriteLine("Hello, World!");
        }

        Console.WriteLine("Appuyez sur une touche pour quitter.");
        Console.ReadKey();
    }
}