
namespace Mediatek86.vue
{
    partial class FrmPersonnels
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
            this.grbPersonnels = new System.Windows.Forms.GroupBox();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbPersonnels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnels
            // 
            this.grbPersonnels.Controls.Add(this.btnAbsence);
            this.grbPersonnels.Controls.Add(this.btnSupprimerPersonnel);
            this.grbPersonnels.Controls.Add(this.btnModifierPersonnel);
            this.grbPersonnels.Controls.Add(this.btnAjouterPersonnel);
            this.grbPersonnels.Controls.Add(this.dgvPersonnels);
            this.grbPersonnels.Location = new System.Drawing.Point(12, 12);
            this.grbPersonnels.Name = "grbPersonnels";
            this.grbPersonnels.Size = new System.Drawing.Size(693, 371);
            this.grbPersonnels.TabIndex = 0;
            this.grbPersonnels.TabStop = false;
            this.grbPersonnels.Text = "personnels";
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(552, 340);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(133, 23);
            this.btnAbsence.TabIndex = 4;
            this.btnAbsence.Text = "gestion absences";
            this.btnAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(176, 340);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(79, 23);
            this.btnSupprimerPersonnel.TabIndex = 3;
            this.btnSupprimerPersonnel.Text = "supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(90, 340);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(80, 23);
            this.btnModifierPersonnel.TabIndex = 2;
            this.btnModifierPersonnel.Text = "modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(6, 340);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(78, 23);
            this.btnAjouterPersonnel.TabIndex = 1;
            this.btnAjouterPersonnel.Text = "ajouter";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Prénom,
            this.Telephone,
            this.Mail,
            this.IdService,
            this.Service});
            this.dgvPersonnels.Location = new System.Drawing.Point(6, 21);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.RowHeadersWidth = 51;
            this.dgvPersonnels.RowTemplate.Height = 24;
            this.dgvPersonnels.Size = new System.Drawing.Size(679, 313);
            this.dgvPersonnels.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.MinimumWidth = 6;
            this.Prénom.Name = "Prénom";
            this.Prénom.Width = 125;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Téléphone";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 125;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.MinimumWidth = 6;
            this.Mail.Name = "Mail";
            this.Mail.Width = 125;
            // 
            // IdService
            // 
            this.IdService.HeaderText = "IdService";
            this.IdService.MinimumWidth = 6;
            this.IdService.Name = "IdService";
            this.IdService.Visible = false;
            this.IdService.Width = 125;
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 6;
            this.Service.Name = "Service";
            this.Service.Width = 125;
            // 
            // FrmPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 389);
            this.Controls.Add(this.grbPersonnels);
            this.Name = "FrmPersonnels";
            this.Text = "Personnels";
            this.grbPersonnels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnels;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
    }
}