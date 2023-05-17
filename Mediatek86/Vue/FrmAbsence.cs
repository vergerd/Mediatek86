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
    /// Fenêtre de gestion des absences du personnel selectionné
    /// </summary>
    public partial class FrmAbsence : Form
    {
        /// <summary>
        /// Date de début originelle de l'absence à modifier
        /// </summary>
        private DateTime dateDebut;
        /// <summary>
        /// Personnel concerné par les absences
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeMotdifAbsence = false;
        /// <summary>
        /// Booléen poue savoir si un ajout est demandé
        /// </summary>
        private Boolean enCoursAjoutAbsence = false;        
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.personnel = personnel;
            grpActionsAbsence.Enabled = false;
            grpAbsences.Text = personnel.Nom + personnel.Prenom;
            RemplirListeAbsences(personnel);
            RemplirListeMotifs();
            InitialisationActionAbsence();            
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
        /// Initialise et rend inaccessible la zone d'ajout/modification 
        /// </summary>
        private void InitialisationActionAbsence()
        {
            grpAbsences.Enabled = true;
            grpActionsAbsence.Enabled = false;
            grpActionsAbsence.Text = "";
            dtpDebut.Value = DateTime.Today;
            dtpFin.Value = DateTime.Today;
            cboMotifs.SelectedItem = cboMotifs.Items[0];

        }
        /// <summary>
        /// Modification d'affichage si on est en cours de modif 
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifAbsence(Boolean modif)
        {
            enCoursDeMotdifAbsence = modif;            
            grpActionsAbsence.Text = "modifer une absence";
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
                    if (!ControleAbsencesSimultanees())
                    {
                        Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                        if (enCoursDeMotdifAbsence)
                        {
                            if (MessageBox.Show("Voulez-vous vraiment modifier : " + dgvAbsences.SelectedRows[0].Cells[3].Value + " du " + ((DateTime)(dgvAbsences.SelectedRows[0].Cells[1].Value)).ToString("dd/MM/yyyy") + " au " + ((DateTime)(dgvAbsences.SelectedRows[0].Cells[2].Value)).ToString("dd/MM/yyyy") + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                                absence.Datedebut = dtpDebut.Value;
                                absence.Datefin = dtpFin.Value;
                                absence.Motif = motif;
                                controller.UpdateAbsence(absence, personnel, dateDebut);
                                EnCoursModifAbsence(false);
                            }
                        }
                        else if (enCoursAjoutAbsence)
                        {
                            Absence absence = new Absence(personnel.Idpersonnel, dtpDebut.Value, dtpFin.Value, motif);
                            controller.AddAbsence(absence);
                            EnCoursAjoutAbsence(false);
                        }
                        RemplirListeAbsences(personnel);
                        InitialisationActionAbsence();
                    }
                    else
                    {
                        MessageBox.Show("Une absence est déjà enregistrée sur cette période", "Information");
                    }
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
                if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    InitialisationActionAbsence();                    
                }            
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer : " + dgvAbsences.SelectedRows[0].Cells[3].Value + " du " + ((DateTime)(dgvAbsences.SelectedRows[0].Cells[1].Value)).ToString("dd/MM/yyyy") + " au " + ((DateTime)(dgvAbsences.SelectedRows[0].Cells[2].Value)).ToString("dd/MM/yyyy") + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences(personnel);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }            
        }
        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {                
                grpActionsAbsence.Enabled = true;
                EnCoursModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpDebut.Value = (DateTime)dgvAbsences.SelectedRows[0].Cells[1].Value;
                dateDebut = (DateTime)dgvAbsences.SelectedRows[0].Cells[1].Value;
                dtpFin.Value = (DateTime)dgvAbsences.SelectedRows[0].Cells[2].Value;
                cboMotifs.SelectedIndex = cboMotifs.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être selectionnée.", "Information");
            }
        }    
        /// <summary>
        ///  Demande d'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grpActionsAbsence.Enabled = true;
            EnCoursAjoutAbsence(true);
        }
        /// <summary>
        /// Modification d'affichage si on est en cours d'ajout
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursAjoutAbsence(Boolean modif)
        {
            enCoursAjoutAbsence = modif;
            grpActionsAbsence.Text = "ajouter une absence";                     
        }
        /// <summary>
        /// Controle d'absences simultanées
        /// </summary>
        /// <returns></returns>
        private Boolean ControleAbsencesSimultanees()
        {
            Boolean test = false;
            if (enCoursDeMotdifAbsence)
            {
                foreach (DataGridViewRow row in dgvAbsences.Rows)
                {
                    if (!row.Selected && (dtpDebut.Value <= (DateTime)row.Cells[2].Value && dtpFin.Value >= (DateTime)row.Cells[1].Value))
                    {
                        test = true;
                    }                    
                }
                return test;
            }
            else if(enCoursAjoutAbsence)
            {
                foreach (DataGridViewRow row in dgvAbsences.Rows)
                {
                    if ((dtpDebut.Value <= (DateTime)row.Cells[2].Value && dtpFin.Value >= (DateTime)row.Cells[1].Value) || dtpDebut.Value == (DateTime)row.Cells[1].Value)
                    {
                        test = true;
                    }
                }
            }
            return test;
        }
        /// <summary>
        /// Fermeture de la fenêtre de gestion des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermerAbsences_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
