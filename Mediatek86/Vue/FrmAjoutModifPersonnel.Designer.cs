
namespace Mediatek86.Vue
{
    partial class FrmAjoutModifPersonnel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpActionPersonnel = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cbbServices = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerPersonnel = new System.Windows.Forms.Button();
            this.btnAnnulerPersonnel = new System.Windows.Forms.Button();
            this.grpActionPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpActionPersonnel
            // 
            this.grpActionPersonnel.Controls.Add(this.btnAnnulerPersonnel);
            this.grpActionPersonnel.Controls.Add(this.btnEnregistrerPersonnel);
            this.grpActionPersonnel.Controls.Add(this.cbbServices);
            this.grpActionPersonnel.Controls.Add(this.txtMail);
            this.grpActionPersonnel.Controls.Add(this.txtNom);
            this.grpActionPersonnel.Controls.Add(this.txtPrenom);
            this.grpActionPersonnel.Controls.Add(this.txtTelephone);
            this.grpActionPersonnel.Controls.Add(this.lblService);
            this.grpActionPersonnel.Controls.Add(this.lblMail);
            this.grpActionPersonnel.Controls.Add(this.lblTelephone);
            this.grpActionPersonnel.Controls.Add(this.lblPrenom);
            this.grpActionPersonnel.Controls.Add(this.lblNom);
            this.grpActionPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grpActionPersonnel.Name = "grpActionPersonnel";
            this.grpActionPersonnel.Size = new System.Drawing.Size(337, 246);
            this.grpActionPersonnel.TabIndex = 0;
            this.grpActionPersonnel.TabStop = false;
            this.grpActionPersonnel.Text = "ajouter personnel";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 21);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 70);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(70, 21);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "prénom";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(6, 103);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(89, 21);
            this.lblTelephone.TabIndex = 2;
            this.lblTelephone.Text = "téléphone";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 138);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 21);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "mail";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(6, 170);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(53, 17);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "service";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(92, 100);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(239, 22);
            this.txtTelephone.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(92, 67);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(239, 22);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(92, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(239, 22);
            this.txtNom.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(92, 135);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(239, 22);
            this.txtMail.TabIndex = 8;
            // 
            // cbbServices
            // 
            this.cbbServices.FormattingEnabled = true;
            this.cbbServices.Location = new System.Drawing.Point(92, 167);
            this.cbbServices.Name = "cbbServices";
            this.cbbServices.Size = new System.Drawing.Size(239, 24);
            this.cbbServices.TabIndex = 9;
            // 
            // btnEnregistrerPersonnel
            // 
            this.btnEnregistrerPersonnel.Location = new System.Drawing.Point(153, 209);
            this.btnEnregistrerPersonnel.Name = "btnEnregistrerPersonnel";
            this.btnEnregistrerPersonnel.Size = new System.Drawing.Size(86, 24);
            this.btnEnregistrerPersonnel.TabIndex = 10;
            this.btnEnregistrerPersonnel.Text = "enregistrer";
            this.btnEnregistrerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerPersonnel
            // 
            this.btnAnnulerPersonnel.Location = new System.Drawing.Point(245, 209);
            this.btnAnnulerPersonnel.Name = "btnAnnulerPersonnel";
            this.btnAnnulerPersonnel.Size = new System.Drawing.Size(86, 24);
            this.btnAnnulerPersonnel.TabIndex = 11;
            this.btnAnnulerPersonnel.Text = "annuler";
            this.btnAnnulerPersonnel.UseVisualStyleBackColor = true;
            // 
            // FrmAjoutModifPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 273);
            this.Controls.Add(this.grpActionPersonnel);
            this.Name = "FrmAjoutModifPersonnel";
            this.Text = "Personnels";
            this.grpActionPersonnel.ResumeLayout(false);
            this.grpActionPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpActionPersonnel;
        private System.Windows.Forms.Button btnAnnulerPersonnel;
        private System.Windows.Forms.Button btnEnregistrerPersonnel;
        private System.Windows.Forms.ComboBox cbbServices;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
    }
}

