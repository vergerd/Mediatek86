
namespace Mediatek86.modele
{
    /// <summary>
    /// Classe métier liée à la table Responsable
    /// </summary>
    public class Responsable
    {
        public string Identifiant { get; }
        public string Mdp { get; }
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="identifiant"></param>
        /// <param name="mdp"></param>
        public Responsable(string identifiant, string mdp)
        {
            this.Identifiant = identifiant;
            this.Mdp = mdp;
        }
    }
}
