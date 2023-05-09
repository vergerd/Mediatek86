using Mediatek86.modele;
using Mediatek86.dal;
using System.Collections.Generic;

namespace Mediatek86.contoleur
{
        /// <summary>
        /// Controlleur de FrmPersonnels
        /// </summary>
        public class FrmPersonnelsController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Absences
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmPersonnelsController()
        {
            personnelAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess();
        }
        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }
        /// <summary>
        /// Demande de suppression de toutes les absences d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel concerné</param>
        public void DelAllAbsence(Personnel personnel)
        {
            absenceAccess.DelAllAbsence(personnel);
        }
        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel concerné</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }
    }
}
