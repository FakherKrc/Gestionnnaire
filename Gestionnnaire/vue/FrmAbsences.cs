using Gestionnnaire.controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionnnaire.modele;

namespace Gestionnnaire.vue
{
    public partial class FrmAbsences : Form
    {
        private Controle controle;
        private Personnel personnel;
        public FrmAbsences(Controle controle, Personnel personnel)
        {
            this.personnel = personnel;
            this.controle = controle;
            InitializeComponent();
            Init();
        }


        private BindingSource bdgAbsences = new BindingSource();
        private BindingSource bdgMotifs = new BindingSource();
        bool enCoursDeModif;


        /// <summary>
        /// Remplie la fenêtre de la liste des personnels et des services. 
        /// </summary>
        public void Init()
        {
            RemplirListeAbsences();
            RemplirListeMotifs();
        }
        /// <summary>
        /// Remplit la DataGriedView avec les absences.
        /// </summary>
        /// <param name="idpersonnel"></param>

        public void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controle.GetLesAbsences(personnel.IdPersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les Motifs
        /// </summary>
        public void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
            if (cboMotif.Items.Count > 0)
            {
                cboMotif.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Vider les zones de saisie d'une absence
        /// </summary>
        private void ViderAbsence()
        {
            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            cboMotif.SelectedIndex = 0;
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, System.EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer ", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbsence(absence.IdPersonnel, absence.DateDebut);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Annule une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAnnulerPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ViderAbsence();
                enCoursDeModif = false;
                grbAbsence.Text = "ajouter une absence";
            }
        }

        /// <summary>
        /// Enregistre une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregPersonnel_Click(object sender, EventArgs e)
        {
            if (cboMotif.SelectedIndex != -1)
            {
                if (dtpDebut.Value.CompareTo(dtpFin.Value) <= 0)
                {
                    Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                    Absence absence = new Absence(personnel.IdPersonnel, dtpDebut.Value, dtpFin.Value, motif.Idmotif, motif.Nom);
                    if (enCoursDeModif)
                    {
                        controle.UpdateAbsence(dtpDebut.Value, absence);
                        enCoursDeModif = false;
                        grbAbsence.Text = "ajouter un personnel";
                        dtpDebut.Enabled = true;
                    }
                    else
                    {
                        controle.AddAbsence(absence);
                    }
                    RemplirListeAbsences();
                    ViderAbsence();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Modifie un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                enCoursDeModif = true;
                grbAbsence.Enabled = true;
                grbAbsence.Text = "modifier un développeur";
                dtpDebut.Enabled = false;
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpDebut.Value = absence.DateDebut;
                dtpFin.Value = absence.DateFin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }

        }

    }
}
