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
    /// Fenêtre de gestion des absences du personnel selectionné
    /// </summary>
    public partial class FrmAbsence : Form
    {
        /// <summary>
        /// Personnel concerné par les absences
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeMotdifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAbsenceController controller;
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAbsence(Personnel personnel)
        {
            InitializeComponent();
            Init(personnel);
        }
        /// <summary>
        /// Initialisations : création du controleur et remplissage de la liste des absences
        /// </summary>
        private void Init(Personnel personnel)
        {
            controller = new FrmAbsenceController();
            this.personnel = personnel;
            RemplirListeAbsences(personnel);
            RemplirListeMotifs();
            EnCoursModifAbsence(false);
        }
        /// <summary>
        /// Affiche les absences
        /// </summary>
        /// <param name="personnel"></param>
        private void RemplirListeAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(personnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotifs.DataSource = bdgMotifs;

        }
        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifAbsence(Boolean modif)
        {
            enCoursDeMotdifAbsence = modif;
            grbActionsAbsence.Enabled = !modif;
            if (modif)
            {
                grbActionsAbsence.Text = "modifer une absence";
            }
            else
            {
                grbActionsAbsence.Text = "ajouter une absence";
                btnAnnulerAbsence.Text = "réinitialiser";
                dtpDebut.Value = DateTime.Today;
                dtpFin.Value = DateTime.Today;
                cboMotifs.SelectedItem = cboMotifs.Items[0];
            }
        }
        /// <summary>
        /// Demande d'enregistrement de l'ajout d'un absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            if (cboMotifs.SelectedIndex != -1)
            {
                if (dtpFin.Value >= dtpDebut.Value)
                {
                    Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                    if (enCoursDeMotdifAbsence)
                    {

                    }
                    else
                    {
                        Absence absence = new Absence(personnel.Idpersonnel, dtpDebut.Value, dtpFin.Value, motif);
                        controller.AddAbsence(absence);
                    }
                    RemplirListeAbsences(personnel);
                    EnCoursModifAbsence(false);
                }
                else
                {
                    MessageBox.Show("La date de fin doit être ultérieure à la date de début", "Information");
                }
            }
            else
            {
                MessageBox.Show("Un motif doit être sélectionné.", "Information");
            }
        }
        /// <summary>
        /// Annuler la demande d'ajout d'une absence
        /// Réinitialise les zones de saisie de l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            if (btnAnnulerAbsence.Text == "réinitialiser")
            {
                if (MessageBox.Show("Voulez-vous vraiment revenir aux valeurs par défaut ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EnCoursModifAbsence(false);
                }
            }
        }
    }
}
