using System;

namespace FlotsBleusLibrary
{
    public class Penalite
    {
        #region Attributs

        public string code;
        public TimeSpan duree;
        public string libelle;

        #endregion

        #region Méthodes classiques

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public TimeSpan Duree
        {
            get { return duree; }
            set { duree = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        #endregion

        #region Constructeur

        public Penalite(string code, TimeSpan duree, string libelle)
        {
            Code = code;
            Duree = duree;
            Libelle = libelle;
        }

        #endregion
    }
}