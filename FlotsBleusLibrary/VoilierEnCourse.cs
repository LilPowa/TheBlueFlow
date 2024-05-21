using System;
using System.Collections.Generic;

namespace FlotsBleusLibrary
{
    public class VoilierEnCourse : Voilier
    {
        #region MyRegion

        public string codeInscription;
        public List<Entreprise> sponsors;
        public List<Epreuve> epreuves;
        public TimeSpan tempsBrut;
        public TimeSpan tempsPenalite;
        public TimeSpan tempsReel;

        #endregion

        #region Méthodes classiques

        public string CodeInscription
        {
            get { return codeInscription; }
            set { codeInscription = value; }
        }

        public List<Entreprise> Sponsors
        {
            get { return sponsors; }
            set { sponsors = value; }
        }

        public List<Epreuve> Epreuves
        {
            get { return epreuves; }
            set { epreuves = value; }
        }

        public TimeSpan TempsBrut
        {
            get { return tempsBrut; }
            set { tempsBrut = value; }
        }

        public TimeSpan TempsPenalite
        {
            get { return tempsPenalite; }
            set { tempsPenalite = value; }
        }

        public TimeSpan TempsReel
        {
            get
            {
                return TempsBrut - TempsPenalite;
            }
        }

        #endregion

        #region Méthodes automatiques

        public void AjouterSponsor(Entreprise entreprise)
        {
            Sponsors.Add(entreprise);
        }

        public void RetirerSponsor(Entreprise entreprise)
        {
            Sponsors.Remove(entreprise);
        }

        public void AjouterEpreuve(Epreuve epreuve)
        {
            Epreuves.Add(epreuve);
        }

        public void EnregistrerTempsBrut(TimeSpan tempsBrut)
        {
            TempsBrut = tempsBrut;
        }

        public void AjouterPenalite(Penalite penalite)
        {
            TempsPenalite += penalite.Duree;
        }

        #endregion
        
        #region Constructeur

        public VoilierEnCourse(string code, string codeInscription) : base(code)
        {
            CodeInscription = codeInscription;
            Sponsors = new List<Entreprise>();
            Epreuves = new List<Epreuve>();
            TempsBrut = TimeSpan.Zero;
            TempsPenalite = TimeSpan.Zero;
        }

        #endregion
    }
}