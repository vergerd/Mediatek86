
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
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.bntModifierAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbActionsAbsence = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.cboMotifs = new System.Windows.Forms.ComboBox();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.grpAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grbActionsAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAbsences
            // 
            this.grpAbsences.Controls.Add(this.btnAjouterAbsence);
            this.grpAbsences.Controls.Add(this.btnSupprimerAbsence);
            this.grpAbsences.Controls.Add(this.bntModifierAbsence);
            this.grpAbsences.Controls.Add(this.dgvAbsences);
            this.grpAbsences.Location = new System.Drawing.Point(12, 12);
            this.grpAbsences.Name = "grpAbsences";
            this.grpAbsences.Size = new System.Drawing.Size(345, 256);
            this.grpAbsences.TabIndex = 0;
            this.grpAbsences.TabStop = false;
            this.grpAbsences.Text = "absence";
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(62, 219);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(89, 31);
            this.btnAjouterAbsence.TabIndex = 1;
            this.btnAjouterAbsence.Text = "ajouter";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(252, 219);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(87, 31);
            this.btnSupprimerAbsence.TabIndex = 3;
            this.btnSupprimerAbsence.Text = "supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // bntModifierAbsence
            // 
            this.bntModifierAbsence.Location = new System.Drawing.Point(157, 219);
            this.bntModifierAbsence.Name = "bntModifierAbsence";
            this.bntModifierAbsence.Size = new System.Drawing.Size(89, 31);
            this.bntModifierAbsence.TabIndex = 2;
            this.bntModifierAbsence.Text = "modifier";
            this.bntModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AllowUserToResizeRows = false;
            this.dgvAbsences.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(9, 21);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(330, 192);
            this.dgvAbsences.TabIndex = 0;
            this.dgvAbsences.TabStop = false;
            // 
            // grbActionsAbsence
            // 
            this.grbActionsAbsence.Controls.Add(this.dtpFin);
            this.grbActionsAbsence.Controls.Add(this.dtpDebut);
            this.grbActionsAbsence.Controls.Add(this.cboMotifs);
            this.grbActionsAbsence.Controls.Add(this.btnAnnulerAbsence);
            this.grbActionsAbsence.Controls.Add(this.btnEnregistrerAbsence);
            this.grbActionsAbsence.Controls.Add(this.lblMotif);
            this.grbActionsAbsence.Controls.Add(this.lblDateFin);
            this.grbActionsAbsence.Controls.Add(this.lblDateDebut);
            this.grbActionsAbsence.Location = new System.Drawing.Point(12, 274);
            this.grbActionsAbsence.Name = "grbActionsAbsence";
            this.grbActionsAbsence.Size = new System.Drawing.Size(345, 142);
            this.grbActionsAbsence.TabIndex = 1;
            this.grbActionsAbsence.TabStop = false;
            this.grbActionsAbsence.Text = "Absence";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(234, 36);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(105, 22);
            this.dtpFin.TabIndex = 5;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(67, 36);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(105, 22);
            this.dtpDebut.TabIndex = 4;
            // 
            // cboMotifs
            // 
            this.cboMotifs.FormattingEnabled = true;
            this.cboMotifs.Location = new System.Drawing.Point(67, 67);
            this.cboMotifs.Name = "cboMotifs";
            this.cboMotifs.Size = new System.Drawing.Size(126, 24);
            this.cboMotifs.TabIndex = 8;
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(252, 97);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(87, 31);
            this.btnAnnulerAbsence.TabIndex = 10;
            this.btnAnnulerAbsence.Text = "annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(157, 97);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(89, 31);
            this.btnEnregistrerAbsence.TabIndex = 9;
            this.btnEnregistrerAbsence.Text = "enregistrer";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
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
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(195, 41);
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
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 428);
            this.Controls.Add(this.grbActionsAbsence);
            this.Controls.Add(this.grpAbsences);
            this.Name = "FrmAbsence";
            this.Text = "Absences";
            this.grpAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grbActionsAbsence.ResumeLayout(false);
            this.grbActionsAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grbActionsAbsence;
        private System.Windows.Forms.Button btnAjouterAbsence;
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
    }
}