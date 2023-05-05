
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
            this.btnSupprimerPersonnel.Click += new System.EventHandler(this.btnSupprimerPersonnel_Click);
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(90, 340);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(80, 23);
            this.btnModifierPersonnel.TabIndex = 2;
            this.btnModifierPersonnel.Text = "modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            this.btnModifierPersonnel.Click += new System.EventHandler(this.btnModifierPersonnel_Click);
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(6, 340);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(78, 23);
            this.btnAjouterPersonnel.TabIndex = 1;
            this.btnAjouterPersonnel.Text = "ajouter";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.btnAjouterPersonnel_Click);
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.AllowUserToAddRows = false;
            this.dgvPersonnels.AllowUserToDeleteRows = false;
            this.dgvPersonnels.AllowUserToResizeRows = false;
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(6, 21);
            this.dgvPersonnels.MultiSelect = false;
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.ReadOnly = true;
            this.dgvPersonnels.RowHeadersVisible = false;
            this.dgvPersonnels.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPersonnels.RowTemplate.Height = 24;
            this.dgvPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnels.Size = new System.Drawing.Size(679, 313);
            this.dgvPersonnels.TabIndex = 0;
            this.dgvPersonnels.TabStop = false;
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
    }
}