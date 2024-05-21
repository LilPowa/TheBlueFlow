using System.Collections.Generic;

namespace FlotsBleusLibrary
{
    public class Course
    {
        #region Attributs

        public List<VoilierEnCourse> voiliersEnCourse;
        public List<Epreuve> epreuves;

        #endregion

        #region Méthodes classiques

        public List<VoilierEnCourse> VoiliersEnCourse
        {
            get { return voiliersEnCourse; }
            set { voiliersEnCourse = value; }
        }

        public List<Epreuve> Epreuves
        {
            get { return epreuves; }
            set { epreuves = value; }
        }

        #endregion

        #region Méthodes Automatiques

        public void AjouterVoilierEnCourse(VoilierEnCourse voilier)
        {
            VoiliersEnCourse.Add(voilier);
        }

        public void EnleverVoilierEnCourse(VoilierEnCourse voilier)
        {
            VoiliersEnCourse.Remove(voilier);
        }

        public void AjouterEpreuve(Epreuve epreuve)
        {
            Epreuves.Add(epreuve);
        }

        public void EnleverEpreuve(Epreuve epreuve)
        {
            Epreuves.Remove(epreuve);
        }

        #endregion

        #region Constructeur

        public Course()
        {
            VoiliersEnCourse = new List<VoilierEnCourse>();
            Epreuves = new List<Epreuve>();
        }

        #endregion
    }
}