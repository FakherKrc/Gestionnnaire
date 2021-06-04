
namespace Gestionnnaire.vue
{
    partial class FrmAbsences
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
            this.btnAjouterAbsences = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifAbsences = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnnulAbs = new System.Windows.Forms.Button();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grbAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouterAbsences
            // 
            this.btnAjouterAbsences.Location = new System.Drawing.Point(16, 258);
            this.btnAjouterAbsences.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterAbsences.Name = "btnAjouterAbsences";
            this.btnAjouterAbsences.Size = new System.Drawing.Size(100, 28);
            this.btnAjouterAbsences.TabIndex = 13;
            this.btnAjouterAbsences.Text = "Ajouter";
            this.btnAjouterAbsences.UseVisualStyleBackColor = true;
            this.btnAjouterAbsences.Click += new System.EventHandler(this.btnAjouterAbsences_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(232, 258);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(103, 28);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnModifAbsences
            // 
            this.btnModifAbsences.Location = new System.Drawing.Point(124, 258);
            this.btnModifAbsences.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifAbsences.Name = "btnModifAbsences";
            this.btnModifAbsences.Size = new System.Drawing.Size(100, 28);
            this.btnModifAbsences.TabIndex = 15;
            this.btnModifAbsences.Text = "Modifier";
            this.btnModifAbsences.UseVisualStyleBackColor = true;
            this.btnModifAbsences.Click += new System.EventHandler(this.btnModifAbsences_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(16, 45);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 51;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.Size = new System.Drawing.Size(494, 197);
            this.dgvAbsences.TabIndex = 12;
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.dtpFin);
            this.grbAbsence.Controls.Add(this.label8);
            this.grbAbsence.Controls.Add(this.dtpDebut);
            this.grbAbsence.Controls.Add(this.cboMotif);
            this.grbAbsence.Controls.Add(this.label7);
            this.grbAbsence.Controls.Add(this.btnAnnulAbs);
            this.grbAbsence.Controls.Add(this.btnEnregAbsence);
            this.grbAbsence.Controls.Add(this.label6);
            this.grbAbsence.Location = new System.Drawing.Point(561, 45);
            this.grbAbsence.Margin = new System.Windows.Forms.Padding(4);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Padding = new System.Windows.Forms.Padding(4);
            this.grbAbsence.Size = new System.Drawing.Size(339, 197);
            this.grbAbsence.TabIndex = 11;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "Ajouter une absence";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(116, 60);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFin.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date de fin ";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Checked = false;
            this.dtpDebut.Location = new System.Drawing.Point(116, 23);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 22);
            this.dtpDebut.TabIndex = 7;
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(116, 99);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(200, 24);
            this.cboMotif.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date de début";
            // 
            // btnAnnulAbs
            // 
            this.btnAnnulAbs.Location = new System.Drawing.Point(117, 165);
            this.btnAnnulAbs.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulAbs.Name = "btnAnnulAbs";
            this.btnAnnulAbs.Size = new System.Drawing.Size(100, 28);
            this.btnAnnulAbs.TabIndex = 4;
            this.btnAnnulAbs.Text = "annuler";
            this.btnAnnulAbs.UseVisualStyleBackColor = true;
            this.btnAnnulAbs.Click += new System.EventHandler(this.btnAnnulAbs_Click);
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(0, 165);
            this.btnEnregAbsence.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(109, 28);
            this.btnEnregAbsence.TabIndex = 3;
            this.btnEnregAbsence.Text = "enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            this.btnEnregAbsence.Click += new System.EventHandler(this.btnEnregAbsence_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Motif";
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 311);
            this.Controls.Add(this.btnAjouterAbsences);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifAbsences);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.grbAbsence);
            this.Name = "FrmAbsences";
            this.Text = "Absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterAbsences;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnnulAbs;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.Label label6;
    }
}