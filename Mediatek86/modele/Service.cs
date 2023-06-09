﻿/// <summary>
/// Package contenant les classes métiers
/// </summary>
namespace Mediatek86.modele
{
    /// <summary>
    /// Classe métier liée à la table Service
    /// </summary>
    public class Service
    {
        public int IdService { get; }
        public string Nom { get; }
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idprofil"></param>
        /// <param name="nom"></param>
        public Service(int idprofil, string nom)
        {
            this.IdService = idprofil;
            this.Nom = nom;
        }
        /// <summary>
        /// Définit l'information à afficher (nom)
        /// </summary>
        /// <returns>Nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
