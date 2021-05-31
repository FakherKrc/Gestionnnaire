
namespace Gestionnnaire.vue
{
    partial class FrmPersonnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGererAbs = new System.Windows.Forms.Button();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAnnulerPersonnel = new System.Windows.Forms.Button();
            this.btnEnregPersonnel = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGererAbs
            // 
            this.btnGererAbs.Location = new System.Drawing.Point(371, 244);
            this.btnGererAbs.Name = "btnGererAbs";
            this.btnGererAbs.Size = new System.Drawing.Size(145, 25);
            this.btnGererAbs.TabIndex = 12;
            this.btnGererAbs.Text = "Gerer les absences ";
            this.btnGererAbs.UseVisualStyleBackColor = true;
            this.btnGererAbs.Click += new System.EventHandler(this.btnGererAbs_Click);
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAnnulerPersonnel);
            this.grbPersonnel.Controls.Add(this.btnEnregPersonnel);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.label5);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Location = new System.Drawing.Point(33, 294);
            this.grbPersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Padding = new System.Windows.Forms.Padding(4);
            this.grbPersonnel.Size = new System.Drawing.Size(807, 159);
            this.grbPersonnel.TabIndex = 11;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Ajouter un personnel";
            // 
            // btnAnnulerPersonnel
            // 
            this.btnAnnulerPersonnel.Location = new System.Drawing.Point(116, 121);
            this.btnAnnulerPersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulerPersonnel.Name = "btnAnnulerPersonnel";
            this.btnAnnulerPersonnel.Size = new System.Drawing.Size(100, 28);
            this.btnAnnulerPersonnel.TabIndex = 10;
            this.btnAnnulerPersonnel.Text = "annuler";
            this.btnAnnulerPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulerPersonnel.Click += new System.EventHandler(this.btnAnnulerPersonnel_Click);
            // 
            // btnEnregPersonnel
            // 
            this.btnEnregPersonnel.Location = new System.Drawing.Point(8, 121);
            this.btnEnregPersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregPersonnel.Name = "btnEnregPersonnel";
            this.btnEnregPersonnel.Size = new System.Drawing.Size(100, 28);
            this.btnEnregPersonnel.TabIndex = 9;
            this.btnEnregPersonnel.Text = "enregistrer";
            this.btnEnregPersonnel.UseVisualStyleBackColor = true;
            this.btnEnregPersonnel.Click += new System.EventHandler(this.btnEnregPersonnel_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(472, 87);
            this.cboService.Margin = new System.Windows.Forms.Padding(4);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(213, 24);
            this.cboService.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "prenom";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(472, 23);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(325, 22);
            this.txtMail.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(472, 55);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(213, 22);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(72, 55);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(325, 22);
            this.txtPrenom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(72, 23);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.MaxLength = 20;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(325, 22);
            this.txtNom.TabIndex = 3;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(258, 244);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(107, 24);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(149, 244);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 24);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(33, 242);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(108, 26);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(33, 25);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.RowHeadersWidth = 51;
            this.dgvPersonnels.RowTemplate.Height = 24;
            this.dgvPersonnels.Size = new System.Drawing.Size(797, 211);
            this.dgvPersonnels.TabIndex = 7;
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 480);
            this.Controls.Add(this.btnGererAbs);
            this.Controls.Add(this.grbPersonnel);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvPersonnels);
            this.Name = "FrmPersonnel";
            this.Text = "Personnel";
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGererAbs;
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.Button btnAnnulerPersonnel;
        private System.Windows.Forms.Button btnEnregPersonnel;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvPersonnels;
    }
}