
namespace TestEfCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTestAjouter = new System.Windows.Forms.Button();
            this.buttonTestSupprimer = new System.Windows.Forms.Button();
            this.buttonTestModifer = new System.Windows.Forms.Button();
            this.buttonTestFiltre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChoixAffichage = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltre = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTestAjouter
            // 
            this.buttonTestAjouter.Location = new System.Drawing.Point(27, 396);
            this.buttonTestAjouter.Name = "buttonTestAjouter";
            this.buttonTestAjouter.Size = new System.Drawing.Size(102, 23);
            this.buttonTestAjouter.TabIndex = 0;
            this.buttonTestAjouter.Text = "Test Ajouter";
            this.buttonTestAjouter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTestAjouter.UseVisualStyleBackColor = true;
            this.buttonTestAjouter.Click += new System.EventHandler(this.buttonTestAjouter_Click);
            // 
            // buttonTestSupprimer
            // 
            this.buttonTestSupprimer.Location = new System.Drawing.Point(240, 396);
            this.buttonTestSupprimer.Name = "buttonTestSupprimer";
            this.buttonTestSupprimer.Size = new System.Drawing.Size(104, 23);
            this.buttonTestSupprimer.TabIndex = 1;
            this.buttonTestSupprimer.Text = "Test Supprimer";
            this.buttonTestSupprimer.UseVisualStyleBackColor = true;
            this.buttonTestSupprimer.Click += new System.EventHandler(this.buttonTestSupprimer_Click);
            // 
            // buttonTestModifer
            // 
            this.buttonTestModifer.Location = new System.Drawing.Point(406, 396);
            this.buttonTestModifer.Name = "buttonTestModifer";
            this.buttonTestModifer.Size = new System.Drawing.Size(140, 23);
            this.buttonTestModifer.TabIndex = 2;
            this.buttonTestModifer.Text = "Test modifier";
            this.buttonTestModifer.UseVisualStyleBackColor = true;
            // 
            // buttonTestFiltre
            // 
            this.buttonTestFiltre.Location = new System.Drawing.Point(621, 396);
            this.buttonTestFiltre.Name = "buttonTestFiltre";
            this.buttonTestFiltre.Size = new System.Drawing.Size(75, 23);
            this.buttonTestFiltre.TabIndex = 3;
            this.buttonTestFiltre.Text = "Test Filtre";
            this.buttonTestFiltre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choix affichage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtre";
            // 
            // comboBoxChoixAffichage
            // 
            this.comboBoxChoixAffichage.FormattingEnabled = true;
            this.comboBoxChoixAffichage.Items.AddRange(new object[] {
            "Formation",
            "Stagiaire"});
            this.comboBoxChoixAffichage.Location = new System.Drawing.Point(158, 41);
            this.comboBoxChoixAffichage.Name = "comboBoxChoixAffichage";
            this.comboBoxChoixAffichage.Size = new System.Drawing.Size(121, 23);
            this.comboBoxChoixAffichage.TabIndex = 9;
            this.comboBoxChoixAffichage.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoixAffichage_SelectedIndexChanged);
            // 
            // comboBoxFiltre
            // 
            this.comboBoxFiltre.FormattingEnabled = true;
            this.comboBoxFiltre.Location = new System.Drawing.Point(507, 38);
            this.comboBoxFiltre.Name = "comboBoxFiltre";
            this.comboBoxFiltre.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFiltre.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(669, 294);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxFiltre);
            this.Controls.Add(this.comboBoxChoixAffichage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTestFiltre);
            this.Controls.Add(this.buttonTestModifer);
            this.Controls.Add(this.buttonTestSupprimer);
            this.Controls.Add(this.buttonTestAjouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTestAjouter;
        private System.Windows.Forms.Button buttonTestSupprimer;
        private System.Windows.Forms.Button buttonTestModifer;
        private System.Windows.Forms.Button buttonTestFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxChoixAffichage;
        private System.Windows.Forms.ComboBox comboBoxFiltre;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

