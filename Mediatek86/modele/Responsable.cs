
namespace Mediatek86.modele
{
    /// <summary>
    /// Classe métier liée à la table Responsable
    /// </summary>
    class Responsable
    {
        public string Identifiant { get; }
        public string Mdp { get; }

        public Responsable(string identifiant, string mdp)
        {
            this.Identifiant = identifiant;
            this.Mdp = mdp;
        }
    }
}
