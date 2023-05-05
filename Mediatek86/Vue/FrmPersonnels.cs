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
    /// Fentre d'affichage des personnels et de leurs infos
    /// </summary>
    public partial class FrmPersonnels : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmPersonnelsController controller;
        public Button BtnModifierPersonnel
        {
            get { return btnModifierPersonnel; }
        }
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>        
        public FrmPersonnels(FrmAuthentification frmauthentification)       
        {
            InitializeComponent();
            if (frmauthentification != null)
            {
                frmauthentification.Visible = false;
            }
            Init();
        }
        /// <summary>
        /// Initialisations : création du controleur et remplissage de la liste
        /// </summary>
        private void Init()
        {
            controller = new FrmPersonnelsController();
            RemplirListePersonnels();
        }
        /// <summary>
        /// Affiche les personnels
        /// </summary>
        public void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;            
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// demande de création d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            FrmAjoutModifPersonnel frm = new FrmAjoutModifPersonnel(null, sender, this);
            frm.ShowDialog();
        }
        /// <summary>
        /// demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                FrmAjoutModifPersonnel frm = new FrmAjoutModifPersonnel(personnel, sender, this);
                frm.ShowDialog();
            }
                
        }
        /// <summary>
        /// demande de suppresion d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if(dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " "+ personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
