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

namespace Gestionnnaire.vue
{
    public partial class FrmAuthentification : Form
    {
        private Controle controle;
        /// <summary>
        /// Constructeur de la Frame Authentification
        /// </summary>
        /// <param name="controle"></param>
        public FrmAuthentification(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
        }
        
        /// <summary>
        /// Controle l'authentification au clique de la souris 
        /// Si champs incorrect : affiche erreur. P0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeconnecter_Click(object sender, EventArgs e)
        {
            if (!txtIdentifiant.Text.Equals("") && !txtMdp.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(txtIdentifiant.Text,  txtMdp.Text))
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                    txtIdentifiant.Text = "";

                    txtMdp.Text = "";
                    txtIdentifiant.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
