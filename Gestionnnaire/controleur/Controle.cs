using Gestionnnaire.dal;
using Gestionnnaire.modele;
using Gestionnnaire.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnnaire.controleur
{
    public class Controle
    {

        /// <summary>
        /// fenêtre d'authentification
        /// </summary>
        private FrmAuthentification frmAuthentification;

        /// <summary>
        /// Fênetre de gestion des absences
        /// </summary>
        private FrmAbsences frmAbsence;
        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {

            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        /// <summary>
        /// Demande l'instanciation la FrmAbsences
        /// </summary>
        /// <param name="personnel"></param>
       public void FrmAbsences(Personnel personnel)
        {
          frmAbsence = new FrmAbsences(this, personnel);
          frmAbsence.ShowDialog();
       }
        /// <summary>
        /// Demande de controler l'authentification 
        /// Si oui alors : ouverture de la fenêtre principale.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool ControleAuthentification(string login, string pwd)
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                frmAuthentification.Hide();
                (new FrmPersonnel(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Demande la liste des personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }

        /// <summary>
        /// Demande la suppression d'un personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        public void DelPersonnel(int idpersonnel)
        {
            AccesDonnees.DelPersonnel(idpersonnel);
        }
        /// <summary>
        /// Demande l'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>

        public void AddPersonnel(Personnel personnel)
        {
            AccesDonnees.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande la modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>

        public void UpdatePersonnel(Personnel personnel)
        {
            AccesDonnees.UpdatePersonnel(personnel);
        }
        /// <summary>
        /// Demande de récuperer la listte des services
        /// </summary>
        /// <returns></returns>

        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();

        }

        /// <summary>
        /// Demande de récuperer les absences.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <returns></returns>

        public List<Absence> GetLesAbsences(int idpersonnel)
        {
            return AccesDonnees.GetLesAbsences(idpersonnel);

        }
        /// <summary>
        /// Demande de supprimer une absence.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        public void DelAbsence(int idpersonnel, DateTime datedebut)
        {
            AccesDonnees.DelAbsence(idpersonnel, datedebut);
        }

        /// <summary>
        /// Demande d'ajouter une absence.
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            AccesDonnees.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modifier une absence. 
        /// </summary>
        /// <param name="debut"></param>
        /// <param name="absence"></param>

        public void UpdateAbsence(DateTime debut, Absence absence)
        {
            AccesDonnees.UpdateAbsence(debut, absence);
        }

        /// <summary>
        /// Demande la recuperation de la liste des motifs
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();


        }















    }
}
