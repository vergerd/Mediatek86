using Mediatek86.modele;
using Mediatek86.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.contoleur
{
        /// <summary>
        /// Controlleur de FrmPersonnels
        /// </summary>
        public class FrmPersonnelsController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// récupère l'accès aux données
        /// </summary>
        public FrmPersonnelsController()
        {
            personnelAccess = new PersonnelAccess();
        }
        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }
    }
}
