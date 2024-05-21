using System;
using System.Text;
using FlotsBleusLibrary;

namespace FlotsBleusConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            /*
             * TODO :
             * - Méthodes "description" pour chaque classe
             * - Comparer classe/classe avec cahier des charges
             * - Finir les tests
             */
            
            Console.OutputEncoding = Encoding.UTF8;
            
            #region Test classe Voilier

            Voilier voilier1 = new Voilier("VOI3");
            Voilier voilier2 = new Voilier("VOI2");
            
            Console.WriteLine(voilier1.CodeVoilier);
            
            voilier1.ModifierCode("VOI1");

            Console.WriteLine(voilier1.CodeVoilier);
            
            #endregion

            #region Test classe Personne

            Personne personne1 = new Personne(1, "Noemi", "Gallien", new DateTime(2000, 02, 11), Personne.Roles.Skipper, voilier1);
            Personne personne2 = new Personne(2, "Olaf", "Ramon", new DateTime(2016, 06, 15), Personne.Roles.Matelot, voilier1);
            
            Console.WriteLine(personne1.Identite);
            
            personne1.ChangrVoilier(voilier2);
            
            Console.WriteLine(personne1.Identite);
            
            personne2.ModifierPrenom("Thomas");
            personne2.ModifierNom("Ramon");
            personne2.ModifierRole(Personne.Roles.Ingenieur);
            
            Console.WriteLine(personne2.Identite);

            #endregion

            #region Test classe Epreuve

            Epreuve epreuve1 = new Epreuve(1, "Epreuve des potaux", 1);
            Epreuve epreuve2 = new Epreuve(2, "Epreuve ultime", 3);
            Epreuve epreuve3 = new Epreuve(3, "Epreuve juste avant l'utlime", 2);

            #endregion
            
            #region Test classe Penalite

            Penalite penalite1 = new Penalite("PEN1010", new TimeSpan(00, 05, 00), "Faute pas très grave");
            Penalite penalite2 = new Penalite("PEN404", TimeSpan.MaxValue, "La plus grave des fautes");
            
            #endregion

            #region Test classe VoilierEnCourse

            VoilierEnCourse voilierEnCourse1 = new VoilierEnCourse("VOI1", "123");
            VoilierEnCourse voilierEnCourse2 = new VoilierEnCourse("VOI2", "456");

            voilierEnCourse1.AjouterEpreuve(epreuve1);
            voilierEnCourse1.AjouterPenalite(penalite2);
            voilierEnCourse1.EnregistrerTempsBrut(new TimeSpan(16,05,02));
            
            #endregion

            #region Test classe Entreprise

            Entreprise entreprise1 = new Entreprise("EPSI");
            Entreprise entreprise2 = new Entreprise("EPITECH");
            
            entreprise1.DevenirSponsor(voilierEnCourse1);

            #endregion

            #region Test classe Course

            Course course1 = new Course();
            course1.AjouterEpreuve(epreuve1);
            course1.AjouterEpreuve(epreuve2);
            course1.AjouterEpreuve(epreuve3);

            course1.AjouterVoilierEnCourse(voilierEnCourse1);
            course1.AjouterVoilierEnCourse(voilierEnCourse2);
            
            #endregion
        }
    }
}