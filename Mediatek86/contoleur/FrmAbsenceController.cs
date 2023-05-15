using Mediatek86.dal;
using Mediatek86.modele;
using System;
using System.Collections.Generic;
/// <summary>
/// Package qui contient les classes qui servent d'intermédiaire entre la Vue et le Modèle
/// </summary>
namespace Mediatek86.contoleur
{
    /// <summary>
    /// Controleur de FrmAbsence
    /// </summary>
    public class FrmAbsenceController
    {      
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// Objet d'accès aux opération possibles sur Motif
        /// </summary>
        private readonly MotifAccess motifAccess;
        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmAbsenceController()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }
        /// <summary>
        /// Récupère et retourne les infos des développeurs
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel);
        }
        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }
        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }
        /// <summary>
        /// Demande de suppresion d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence (Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }        
        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        /// <param name="personnel">personnel concerné</param>
        /// <param name="dateDebut">datedebut originelle</param>
        public void UpdateAbsence(Absence absence, Personnel personnel, DateTime dateDebut)
        {
            absenceAccess.UpdateAbsence(absence, personnel, dateDebut);
        }

    }
}
