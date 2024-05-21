using System.Collections.Generic;
using System;

namespace FlotsBleusLibrary
{
    public class Voilier
    {
        #region Attributs

        protected string code;

        #endregion

        #region Méthodes classiques

        protected string Code
        {
            get { return code; }
            set { code = value; }
        }

        #endregion

        #region Méthodes automatiques

        public void ModifierCode(string nouveauCode)
        {
            Code = nouveauCode;
        }

        public string CodeVoilier
        {
            get
            {
                return $"{code}";
            }
        }

        #endregion

        #region Constructeur

        public Voilier(string code)
        {
            Code = code;
        }

        #endregion
    }
}