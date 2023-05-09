
namespace Mediatek86.vue
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.bntModifierAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grpActionsAbsence = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.cboMotifs = new System.Windows.Forms.ComboBox();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.btnFermerAbsences = new System.Windows.Forms.Button();
            this.grpAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grpActionsAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAbsences
            // 
            this.grpAbsences.Controls.Add(this.btnAjouter);
            this.grpAbsences.Controls.Add(this.btnSupprimerAbsence);
            this.grpAbsences.Controls.Add(this.bntModifierAbsence);
            this.grpAbsences.Controls.Add(this.dgvAbsences);
            this.grpAbsences.Location = new System.Drawing.Point(12, 12);
            this.grpAbsences.Name = "grpAbsences";
            this.grpAbsences.Size = new System.Drawing.Size(319, 256);
            this.grpAbsences.TabIndex = 0;
            this.grpAbsences.TabStop = false;
            this.grpAbsences.Text = "absence";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(38, 219);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(87, 31);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(226, 219);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(87, 31);
            this.btnSupprimerAbsence.TabIndex = 3;
            this.btnSupprimerAbsence.Text = "supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // bntModifierAbsence
            // 
            this.bntModifierAbsence.Location = new System.Drawing.Point(131, 219);
            this.bntModifierAbsence.Name = "bntModifierAbsence";
            this.bntModifierAbsence.Size = new System.Drawing.Size(89, 31);
            this.bntModifierAbsence.TabIndex = 2;
            this.bntModifierAbsence.Text = "modifier";
            this.bntModifierAbsence.UseVisualStyleBackColor = true;
            this.bntModifierAbsence.Click += new System.EventHandler(this.bntModifierAbsence_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AllowUserToResizeRows = false;
            this.dgvAbsences.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 21);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(307, 192);
            this.dgvAbsences.TabIndex = 0;
            this.dgvAbsences.TabStop = false;
            // 
            // grpActionsAbsence
            // 
            this.grpActionsAbsence.Controls.Add(this.dtpFin);
            this.grpActionsAbsence.Controls.Add(this.dtpDebut);
            this.grpActionsAbsence.Controls.Add(this.cboMotifs);
            this.grpActionsAbsence.Controls.Add(this.btnAnnulerAbsence);
            this.grpActionsAbsence.Controls.Add(this.btnEnregistrerAbsence);
            this.grpActionsAbsence.Controls.Add(this.lblMotif);
            this.grpActionsAbsence.Controls.Add(this.lblDateFin);
            this.grpActionsAbsence.Controls.Add(this.lblDateDebut);
            this.grpActionsAbsence.Location = new System.Drawing.Point(12, 274);
            this.grpActionsAbsence.Name = "grpActionsAbsence";
            this.grpActionsAbsence.Size = new System.Drawing.Size(319, 128);
            this.grpActionsAbsence.TabIndex = 1;
            this.grpActionsAbsence.TabStop = false;
            this.grpActionsAbsence.Text = "Absence";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(86, 64);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(121, 22);
            this.dtpFin.TabIndex = 5;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(86, 36);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(121, 22);
            this.dtpDebut.TabIndex = 4;
            // 
            // cboMotifs
            // 
            this.cboMotifs.FormattingEnabled = true;
            this.cboMotifs.Location = new System.Drawing.Point(86, 92);
            this.cboMotifs.Name = "cboMotifs";
            this.cboMotifs.Size = new System.Drawing.Size(121, 24);
            this.cboMotifs.TabIndex = 8;
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(226, 81);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(87, 31);
            this.btnAnnulerAbsence.TabIndex = 10;
            this.btnAnnulerAbsence.Text = "annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulerAbsence.Click += new System.EventHandler(this.btnAnnulerAbsence_Click);
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(224, 34);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(89, 31);
            this.btnEnregistrerAbsence.TabIndex = 9;
            this.btnEnregistrerAbsence.Text = "enregistrer";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            this.btnEnregistrerAbsence.Click += new System.EventHandler(this.btnEnregistrerAbsence_Click);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(6, 95);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(38, 17);
            this.lblMotif.TabIndex = 2;
            this.lblMotif.Text = "motif";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(6, 69);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(23, 17);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "fin";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(6, 37);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(44, 17);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "début";
            // 
            // btnFermerAbsences
            // 
            this.btnFermerAbsences.Location = new System.Drawing.Point(236, 417);
            this.btnFermerAbsences.Name = "btnFermerAbsences";
            this.btnFermerAbsences.Size = new System.Drawing.Size(89, 31);
            this.btnFermerAbsences.TabIndex = 11;
            this.btnFermerAbsences.Text = "fermer";
            this.btnFermerAbsences.UseVisualStyleBackColor = true;
            this.btnFermerAbsences.Click += new System.EventHandler(this.btnFermerAbsences_Click);
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 460);
            this.Controls.Add(this.btnFermerAbsences);
            this.Controls.Add(this.grpActionsAbsence);
            this.Controls.Add(this.grpAbsences);
            this.Name = "FrmAbsence";
            this.Text = "Absences";
            this.grpAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grpActionsAbsence.ResumeLayout(false);
            this.grpActionsAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grpActionsAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button bntModifierAbsence;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.ComboBox cboMotifs;
        private System.Windows.Forms.Button btnAnnulerAbsence;
        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Button btnFermerAbsences;
        private System.Windows.Forms.Button btnAjouter;
    }
}