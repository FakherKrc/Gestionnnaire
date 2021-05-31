using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionnnaire.controleur;
using Gestionnnaire.modele;

namespace Gestionnnaire.vue
{
    public partial class FrmPersonnel : Form
    {
        private Controle controle;
        private BindingSource bdgPersonnels = new BindingSource();
        private BindingSource bdgAbsences = new BindingSource();
        private BindingSource bdgMotifs = new BindingSource();
        private BindingSource bdgServices = new BindingSource();
        bool enCoursDeModif;
        public FrmPersonnel(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            Init();

        }

        /// <summary>
        /// Remplie la fenêtre de la liste des personnels et des services. 
        /// </summary>
        public void Init()
        {
            RemplirListePersonnel();
            RemplirListeService();
            grbPersonnel.Enabled = false;
        }
        /// <summary>
        /// Remplis la DataGriedView par la liste des personnels. 
        /// </summary>

        public void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.Columns["idservice"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les Services
        /// </summary>
        public void RemplirListeService()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
            if (cboService.Items.Count > 0)
            {
                cboService.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Vider les zones de saisie d'un personnel
        /// </summary>
        private void ViderPersonnel()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            cboService.SelectedIndex = 0;
        }
            /// <summary>
            /// Demande de suppression d'un personnel
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, System.EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnel(personnel.IdPersonnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Annule un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAnnulerPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ViderPersonnel();
                grbPersonnel.Enabled = true;
                enCoursDeModif = false;
                grbPersonnel.Text = "ajouter un développeur";
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;
                grbPersonnel.Enabled = false;
            }
        }

        /// <summary>
        /// Enregistre un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                int idpersonnel = 0;
                if (enCoursDeModif)
                {
                    idpersonnel = (int)dgvPersonnels.SelectedRows[0].Cells["idpersonnel"].Value;
                }
                Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);
                if (enCoursDeModif)
                {
                    controle.UpdatePersonnel(personnel);
                    enCoursDeModif = false;
                    grbPersonnel.Text = "ajouter un personnel";

                }
                else
                {
                    controle.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                ViderPersonnel();
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;
                grbPersonnel.Enabled = false;
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
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                enCoursDeModif = true;
                grbPersonnel.Enabled = true;
                btnAjouter.Enabled = false;
                grbPersonnel.Text = "modifier un développeur";
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnGererAbs_Click(object sender, EventArgs e)
        {
            if(dgvPersonnels.SelectedRows.Count > 0)
            {
                controle.FrmAbsences((Personnel)bdgPersonnels.List[bdgPersonnels.Position]);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grbPersonnel.Enabled = true;
            btnModifier.Enabled = false;
        }
    }
}
