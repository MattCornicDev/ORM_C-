using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TestEfCore.DataAccess.DataObjects;
using TestEfCore.BLL;

namespace TestEfCore.Views
{
    public partial class FormAjouterFormation : Form
    {
        public FormAjouterFormation()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            BLLFormation bLLFormation = new BLLFormation();
            bLLFormation.ajouterFormation(textBoxNomFormation.Text, textBoxNiveau.Text, Convert.ToInt16(textBoxNbStagiaire.Text));
        }
    }
}
