using System;

namespace FlotsBleusLibrary
{
    public class Personne
    {
        public enum Roles {Skipper, Navigateur, Matelot, Ingenieur, Cuisinier}
        
        #region Attributs
        
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;
        private Roles role;
        private Voilier voilier;

        #endregion

        #region Méthodes classiques

        private int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private DateTime DateDeNaissance
        {
            get { return dateDeNaissance; }
            set { dateDeNaissance = value; }
        }
        
        public int Age
        {
            get
            {
                return (int)Math.Floor(DateTime.Now.Subtract(DateDeNaissance).TotalDays / 365);
            }
        }

        private Roles Role
        {
            get { return role; }
            set { role = value; }
        }

        private Voilier Voilier
        {
            get { return voilier; }
            set { voilier = value; }
        }
        
        #endregion

        #region Méthodes automatiques

        public string Identite
        {
            get
            {
                return
                    $"ID : {id}\nNom : {nom}\nPrénom : {prenom}\nAge : {Age} ans\nRôle : {role}\nVoilier : {voilier.CodeVoilier}";
            }
        }

        public void ModifierNom(string nouveauNom)
        {
            Nom = nouveauNom;
        }
        
        public void ModifierPrenom(string nouveauPrenom)
        {
            Prenom = nouveauPrenom;
        }
        
        public void ModifierRole(Roles nouveauRole)
        {
            Role = nouveauRole;
        }
        
        public void ChangrVoilier(Voilier voilier)
        {
            Voilier = voilier;
        }

        #endregion

        #region Constructeur
        
        public Personne(int id, string nom, string prenom, DateTime dateDeNaissance, Roles role, Voilier voilier)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
            Role = role;
            Voilier = voilier;
        }

        #endregion
    }
}