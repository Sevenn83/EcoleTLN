﻿namespace EcoleTLN
{
    public abstract class Etudiant : Personne
    {
        public string Section { get; set; }
        

        public Etudiant(string section, string nom, int annee) : base(nom, annee)
        {
            this.Section = section;
        }

        /// <summary>
        /// Affiche les informations de la class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + "    Section : " + this.Section;
        }
    }


}
