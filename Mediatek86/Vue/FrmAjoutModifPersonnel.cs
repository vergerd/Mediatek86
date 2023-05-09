using Mediatek86.contoleur;
using Mediatek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatek86.vue
{
    /// <summary>
    /// Fenêtre d'ajout ou de modification de personnel
    /// </summary>
    public partial class FrmAjoutModifPersonnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifDeveloppeur = false;
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAjoutModifPersonnelController controller;
        private FrmPersonnels frmPersonnels;
        private Personnel personnel;
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();        
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAjoutModifPersonnel(Personnel personnel, Object sender, FrmPersonnels frm)
        {
            InitializeComponent();
            Init(personnel, sender, frm);
        }
        /// <summary>
        /// Initialisations : création du controller
        /// </summary>
        /// <param name="personnel">personnel de la ligne selectionnée</param>
        /// <param name="sender">bouton ayant déclenché l'ouverture de la frame (ajouter ou modifier)</param>
        /// <param name="frm"></param>
        private void Init(Personnel personnel, Object sender, FrmPersonnels frm)
        {

            controller = new FrmAjoutModifPersonnelController();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.frmPersonnels = frm;
            this.personnel = personnel;
            RemplirListServices();
            if ((Button)sender == frm.BtnModifierPersonnel)
            {
                grpActionPersonnel.Text = "modifier un personnel";
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTelephone.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cbbServices.SelectedIndex = cbbServices.FindStringExact(personnel.Service.Nom);
                enCoursDeModifDeveloppeur = true;
            }
            else
            {
                grpActionPersonnel.Text = "ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTelephone.Text = "";
                txtMail.Text = "";
            }
            
        }
        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cbbServices.DataSource = bdgServices;

        }
        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTelephone.Text.Equals("") && !txtMail.Text.Equals("") && cbbServices.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModifDeveloppeur)
                {                    
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTelephone.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                frmPersonnels.RemplirListePersonnels();
                enCoursDeModifDeveloppeur=false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
           
        }
        /// <summary>
        /// annuler la demande d'ajout ou de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
