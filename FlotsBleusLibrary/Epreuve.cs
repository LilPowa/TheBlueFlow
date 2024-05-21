namespace FlotsBleusLibrary
{
    public class Epreuve
    {
        #region Attributs

        public int id;
        public string libelle;
        public int ordre;

        #endregion

        #region Méthodes classiques

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public int Ordre
        {
            get { return ordre; }
            set { ordre = value; }
        }
        
        #endregion

        #region Constructeur

        public Epreuve(int id, string libelle, int ordre)
        {
            Id = id;
            Libelle = libelle;
            Ordre = ordre;
        }

        #endregion
    }
}