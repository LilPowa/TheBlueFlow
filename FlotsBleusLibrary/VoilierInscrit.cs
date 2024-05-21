namespace FlotsBleusLibrary
{
    public class VoilierInscrit
    {
        #region Attributs

        public Voilier voilier;

        #endregion

        #region Méthodes classiques

        public Voilier Voilier
        {
            get { return voilier; }
            set { voilier = value; }
        }

        #endregion

        #region Constructeur

        public VoilierInscrit(Voilier voilier)
        {
            Voilier = voilier;
        }

        #endregion
    }
}