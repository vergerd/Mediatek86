
namespace Mediatek86.Vue
{
    partial class FrmAbsence
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
            this.grpAbsences = new System.Windows.Forms.GroupBox();
            this.grbActionsAbsence = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMotif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.cbbMotif = new System.Windows.Forms.ComboBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.grpAbsences.SuspendLayout();
            this.grbActionsAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAbsences
            // 
            this.grpAbsences.Controls.Add(this.btnAjouterAbsence);
            this.grpAbsences.Controls.Add(this.btnSupprimerAbsence);
            this.grpAbsences.Controls.Add(this.bntModifierAbsence);
            this.grpAbsences.Controls.Add(this.dataGridView1);
            this.grpAbsences.Location = new System.Drawing.Point(12, 12);
            this.grpAbsences.Name = "grpAbsences";
            this.grpAbsences.Size = new System.Drawing.Size(438, 442);
            this.grpAbsences.TabIndex = 0;
            this.grpAbsences.TabStop = false;
            this.grpAbsences.Text = "prenom nom";
            // 
            // grbActionsAbsence
            // 
            this.grbActionsAbsence.Controls.Add(this.dtpFin);
            this.grbActionsAbsence.Controls.Add(this.dtpDebut);
            this.grbActionsAbsence.Controls.Add(this.cbbMotif);
            this.grbActionsAbsence.Controls.Add(this.btnAnnulerAbsence);
            this.grbActionsAbsence.Controls.Add(this.btnEnregistrerAbsence);
            this.grbActionsAbsence.Controls.Add(this.lblMotif);
            this.grbActionsAbsence.Controls.Add(this.lblDateFin);
            this.grbActionsAbsence.Controls.Add(this.lblDateDebut);
            this.grbActionsAbsence.Location = new System.Drawing.Point(12, 460);
            this.grbActionsAbsence.Name = "grbActionsAbsence";
            this.grbActionsAbsence.Size = new System.Drawing.Size(438, 142);
            this.grbActionsAbsence.TabIndex = 1;
            this.grbActionsAbsence.TabStop = false;
            this.grbActionsAbsence.Text = "Absence";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDebut,
            this.dateFin,
            this.idMotif,
            this.libelle});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateDebut
            // 
            this.dateDebut.HeaderText = "Début";
            this.dateDebut.MinimumWidth = 6;
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Width = 125;
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "Fin";
            this.dateFin.MinimumWidth = 6;
            this.dateFin.Name = "dateFin";
            this.dateFin.Width = 125;
            // 
            // idMotif
            // 
            this.idMotif.HeaderText = "idMotif";
            this.idMotif.MinimumWidth = 6;
            this.idMotif.Name = "idMotif";
            this.idMotif.Visible = false;
            this.idMotif.Width = 125;
            // 
            // libelle
            // 
            this.libelle.HeaderText = "Motif";
            this.libelle.MinimumWidth = 6;
            this.libelle.Name = "libelle";
            this.libelle.Width = 125;
            // 
            // bntModifierAbsence
            // 
            this.bntModifierAbsence.Location = new System.Drawing.Point(357, 401);
            this.bntModifierAbsence.Name = "bntModifierAbsence";
            this.bntModifierAbsence.Size = new System.Drawing.Size(75, 23);
            this.bntModifierAbsence.TabIndex = 1;
            this.bntModifierAbsence.Text = "modifier";
            this.bntModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(276, 401);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerAbsence.TabIndex = 2;
            this.btnSupprimerAbsence.Text = "supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(195, 401);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterAbsence.TabIndex = 3;
            this.btnAjouterAbsence.Text = "ajouter";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(6, 37);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(55, 21);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(244, 37);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(23, 17);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "fin";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(6, 67);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(38, 17);
            this.lblMotif.TabIndex = 2;
            this.lblMotif.Text = "motif";
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(276, 107);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerAbsence.TabIndex = 4;
            this.btnEnregistrerAbsence.Text = "enregistrer";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(357, 107);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerAbsence.TabIndex = 5;
            this.btnAnnulerAbsence.Text = "annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            // 
            // cbbMotif
            // 
            this.cbbMotif.FormattingEnabled = true;
            this.cbbMotif.Location = new System.Drawing.Point(67, 64);
            this.cbbMotif.Name = "cbbMotif";
            this.cbbMotif.Size = new System.Drawing.Size(150, 24);
            this.cbbMotif.TabIndex = 8;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(67, 36);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(150, 22);
            this.dtpDebut.TabIndex = 9;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(282, 37);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(150, 22);
            this.dtpFin.TabIndex = 10;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 607);
            this.Controls.Add(this.grbActionsAbsence);
            this.Controls.Add(this.grpAbsences);
            this.Name = "FrmAbsence";
            this.Text = "Absences";
            this.grpAbsences.ResumeLayout(false);
            this.grbActionsAbsence.ResumeLayout(false);
            this.grbActionsAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAbsences;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbActionsAbsence;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button bntModifierAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMotif;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.ComboBox cbbMotif;
        private System.Windows.Forms.Button btnAnnulerAbsence;
        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
    }
}