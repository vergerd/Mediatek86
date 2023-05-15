using Mediatek86.contoleur;
using Mediatek86.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
/// <summary>
/// Package contenant les interfaces
/// </summary>
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
        /// <summary>
        /// Demande de modification de personnel
        /// </summary>
        public Button BtnModifierPersonnel
        {
            get { return btnModifierPersonnel; }
        }
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        /// <param name="frmauthentification">Instance de la fenêtre d'authentification</param>
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
            this.StartPosition = FormStartPosition.CenterScreen;
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
        /// Demande de création d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            FrmAjoutModifPersonnel frm = new FrmAjoutModifPersonnel(null, sender, this);
            frm.ShowDialog();
        }
        /// <summary>
        /// Demande de modification d'un personnel
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
        /// Demande de suppresion d'un personnel (et préalablement, de toutes ces absences)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAllAbsence(personnel);
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Demande d'affichage des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsence_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                FrmAbsence frm = new FrmAbsence(personnel);
                frm.ShowDialog();
            }
        }
    }
}
