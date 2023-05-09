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
    /// Fenêtre d'authentification (seul le responsable peut accéder à l'application)
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation : création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Demande au controleur de controler l'authentification 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            String identifiant = txtIdentifiant.Text;
            String mdp = txtMdp.Text;
            if (String.IsNullOrEmpty(identifiant) || String.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(identifiant, mdp);
                if (controller.ControleAuthentification(responsable))
                {                    
                    FrmPersonnels frm = new FrmPersonnels(this);                    
                    frm.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                }
            }
        }
    }
}
