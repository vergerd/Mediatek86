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
    /// Fenêtre d'authentification (seul le responsable peut accéder à l'application)
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
        }
    }
}
