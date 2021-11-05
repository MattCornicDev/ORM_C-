using TestEfCore.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestEfCore.DataAccess.DataObjects;
using TestEfCore.Views;

namespace TestEfCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxChoixAffichage.SelectedIndex = 0;
            BLLFormation B = new BLLFormation();
            this.dataGridView1.DataSource = B.getFormation();
        }


        private void comboBoxChoixAffichage_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLLFormation B = new BLLFormation();
            BLLStagiaire S = new BLLStagiaire();
            switch (comboBoxChoixAffichage.SelectedItem.ToString())
            {
                case "Formation":
                    dataGridView1.DataSource = B.getFormation();
                    break;

                case "Stagiaire":
                    dataGridView1.DataSource = S.getStagiaires();
                    break;
            }

        }

        private void buttonTestAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterFormation pageAjoutFormation = new FormAjouterFormation();
            pageAjoutFormation.Show();
            BLLFormation B = new BLLFormation();
            /*Formation maFormation = new Formation()
            {
                
               Nom = "TPTAI",
                Niveau = "BAC",
                NbStagiaires = 23,

            };
            // J'ajoute ma formation au contexte
          
            //je persiste en base
            B.ajouterFormation(maFormation);
            //j'actualise la dataGridView*/
            this.dataGridView1.DataSource = B.getFormation();

        }

        private void buttonTestSupprimer_Click(object sender, EventArgs e)
        {
            BLLFormation B = new BLLFormation();
            comboBoxChoixAffichage.SelectedIndex = 0;
            int PK = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            switch (comboBoxChoixAffichage.SelectedItem.ToString())
            {
                case "Formation":
                    BLLFormation F = new BLLFormation();
                    F.supprimerFormation(PK);
                    //j'actualise la dataGridView
                    this.dataGridView1.DataSource = B.getFormation();
                    break;

                case "Stagiaire":
                    BLLFormation S = new BLLFormation();
                    S.supprimerFormation(PK);
                    //j'actualise la dataGridView
                    this.dataGridView1.DataSource = B.getFormation();
                    break;

            }

        }
    }
}
