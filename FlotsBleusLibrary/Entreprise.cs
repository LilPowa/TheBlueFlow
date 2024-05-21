namespace FlotsBleusLibrary
{
    public class Entreprise
    {
        #region Attributs

        public string nom;
        public VoilierEnCourse voilierSponsorise;

        #endregion

        #region Méthodes classiques

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public VoilierEnCourse VoilierSponsorise
        {
            get { return voilierSponsorise; }
            set { voilierSponsorise = value; }
        }

        #endregion

        #region Méthodes automatiques

        public void DevenirSponsor(VoilierEnCourse voilier)
        {
            VoilierSponsorise = voilier;
            voilier.AjouterSponsor(this);
        }

        public void CesserSponsoring()
        {
            VoilierSponsorise.RetirerSponsor(this);
            VoilierSponsorise = null;
        }

        #endregion

        #region Constructeur

        public Entreprise(string nom)
        {
            Nom = nom;
            VoilierSponsorise = null;
        }

        #endregion

    }
}