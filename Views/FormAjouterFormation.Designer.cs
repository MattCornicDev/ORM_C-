
namespace TestEfCore.Views
{
    partial class FormAjouterFormation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomFormation = new System.Windows.Forms.Label();
            this.Niveau = new System.Windows.Forms.Label();
            this.NbStagiaire = new System.Windows.Forms.Label();
            this.textBoxNomFormation = new System.Windows.Forms.TextBox();
            this.textBoxNiveau = new System.Windows.Forms.TextBox();
            this.textBoxNbStagiaire = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomFormation
            // 
            this.NomFormation.AutoSize = true;
            this.NomFormation.Location = new System.Drawing.Point(124, 71);
            this.NomFormation.Name = "NomFormation";
            this.NomFormation.Size = new System.Drawing.Size(92, 15);
            this.NomFormation.TabIndex = 0;
            this.NomFormation.Text = "Nom Formation";
            // 
            // Niveau
            // 
            this.Niveau.AutoSize = true;
            this.Niveau.Location = new System.Drawing.Point(124, 134);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(44, 15);
            this.Niveau.TabIndex = 1;
            this.Niveau.Text = "Niveau";
            // 
            // NbStagiaire
            // 
            this.NbStagiaire.AutoSize = true;
            this.NbStagiaire.Location = new System.Drawing.Point(124, 207);
            this.NbStagiaire.Name = "NbStagiaire";
            this.NbStagiaire.Size = new System.Drawing.Size(114, 15);
            this.NbStagiaire.TabIndex = 2;
            this.NbStagiaire.Text = "Nombre de stagiaire";
            // 
            // textBoxNomFormation
            // 
            this.textBoxNomFormation.Location = new System.Drawing.Point(314, 71);
            this.textBoxNomFormation.Name = "textBoxNomFormation";
            this.textBoxNomFormation.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomFormation.TabIndex = 3;
            // 
            // textBoxNiveau
            // 
            this.textBoxNiveau.Location = new System.Drawing.Point(314, 134);
            this.textBoxNiveau.Name = "textBoxNiveau";
            this.textBoxNiveau.Size = new System.Drawing.Size(100, 23);
            this.textBoxNiveau.TabIndex = 4;
            // 
            // textBoxNbStagiaire
            // 
            this.textBoxNbStagiaire.Location = new System.Drawing.Point(314, 207);
            this.textBoxNbStagiaire.Name = "textBoxNbStagiaire";
            this.textBoxNbStagiaire.Size = new System.Drawing.Size(100, 23);
            this.textBoxNbStagiaire.TabIndex = 5;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(314, 323);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(100, 29);
            this.buttonValider.TabIndex = 6;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // FormAjouterFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxNbStagiaire);
            this.Controls.Add(this.textBoxNiveau);
            this.Controls.Add(this.textBoxNomFormation);
            this.Controls.Add(this.NbStagiaire);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.NomFormation);
            this.Name = "FormAjouterFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjouterFormation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomFormation;
        private System.Windows.Forms.Label Niveau;
        private System.Windows.Forms.Label NbStagiaire;
        private System.Windows.Forms.TextBox textBoxNomFormation;
        private System.Windows.Forms.TextBox textBoxNiveau;
        private System.Windows.Forms.TextBox textBoxNbStagiaire;
        private System.Windows.Forms.Button buttonValider;
    }
}