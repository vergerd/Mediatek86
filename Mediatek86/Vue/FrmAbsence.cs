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
            RemplirListeAbsences(personnel);
            RemplirListeMotifs();
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
    }
}
