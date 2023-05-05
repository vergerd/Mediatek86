using Mediatek86.dal;
using Mediatek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.contoleur
{
    /// <summary>
    /// Controleur de FrmAjoutModifPersonnel
    /// </summary>
    public class FrmAjoutModifPersonnelController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmAjoutModifPersonnelController()
        {
            serviceAccess = new ServiceAccess();
            personnelAccess = new PersonnelAccess();

        }
        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }
        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }
      
        
    }
}
