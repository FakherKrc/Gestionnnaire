using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnnaire.modele
{
    public class Motif
    {
        private int idmotif;
        private string nom;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="nom"></param>
        public Motif(int idmotif, string nom)
        {
            this.idmotif = idmotif;
            this.nom = nom;
        }

        public int Idmotif { get => idmotif; }
        public string Nom { get => nom; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.nom;
        }
    }
}
