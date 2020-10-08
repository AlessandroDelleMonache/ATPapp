using ATPappWinForms.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATPappWinForms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            Utilities.GetAgenti("http://atpapirest.azurewebsites.net/api/Agentis", dgvAgenti);
        }
    }
}
