using Mediatek86.dal;
using Mediatek86.modele;
using System;
/// <summary>
/// Package qui contient les classes qui servent d'intermédiaire entre la Vue et le Modèle
/// </summary>
namespace Mediatek86.contoleur
{
    /// <summary>
    /// Controleur de FrmAUthentification
    /// </summary>
    public class FrmAuthentificationController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            responsableAccess = new ResponsableAccess();
        }
        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns>vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }
    }
}
