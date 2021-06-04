using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnnaire.modele
{
    public class Absence
    {
        private int idpersonnel;
        private DateTime datedebut;
        private DateTime datefin;
        private int idmotif;
        private string motif;

        public int IdPersonnel { get => idpersonnel; }
        public DateTime DateDebut { get => datedebut; }
        public DateTime DateFin { get => datefin; }
        public int IdMotif { get => idmotif; }
        public string Motif { get => motif; }


        /// <summary>
        /// Constructeur : valorise les propriétés.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        /// <param name="motif"></param>

        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif, string motif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;
            this.motif = motif;
        }
    }
}
