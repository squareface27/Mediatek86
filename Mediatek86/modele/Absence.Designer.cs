
namespace Mediatek86.modele
{
    partial class Absence
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonAjouterAbsence = new System.Windows.Forms.Button();
            this.buttonModifierAbsence = new System.Windows.Forms.Button();
            this.buttonSupprimerAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(918, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRetour.Location = new System.Drawing.Point(949, 526);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(119, 23);
            this.buttonRetour.TabIndex = 1;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterAbsence
            // 
            this.buttonAjouterAbsence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAjouterAbsence.Location = new System.Drawing.Point(76, 526);
            this.buttonAjouterAbsence.Name = "buttonAjouterAbsence";
            this.buttonAjouterAbsence.Size = new System.Drawing.Size(135, 23);
            this.buttonAjouterAbsence.TabIndex = 2;
            this.buttonAjouterAbsence.Text = "Ajouter absence";
            this.buttonAjouterAbsence.UseVisualStyleBackColor = false;
            // 
            // buttonModifierAbsence
            // 
            this.buttonModifierAbsence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonModifierAbsence.Location = new System.Drawing.Point(311, 526);
            this.buttonModifierAbsence.Name = "buttonModifierAbsence";
            this.buttonModifierAbsence.Size = new System.Drawing.Size(135, 23);
            this.buttonModifierAbsence.TabIndex = 3;
            this.buttonModifierAbsence.Text = "Modifier absence";
            this.buttonModifierAbsence.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimerAbsence
            // 
            this.buttonSupprimerAbsence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSupprimerAbsence.Location = new System.Drawing.Point(543, 526);
            this.buttonSupprimerAbsence.Name = "buttonSupprimerAbsence";
            this.buttonSupprimerAbsence.Size = new System.Drawing.Size(135, 23);
            this.buttonSupprimerAbsence.TabIndex = 4;
            this.buttonSupprimerAbsence.Text = "Supprimer absence";
            this.buttonSupprimerAbsence.UseVisualStyleBackColor = false;
            // 
            // Absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 621);
            this.Controls.Add(this.buttonSupprimerAbsence);
            this.Controls.Add(this.buttonModifierAbsence);
            this.Controls.Add(this.buttonAjouterAbsence);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Absence";
            this.Text = "Absence";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonAjouterAbsence;
        private System.Windows.Forms.Button buttonModifierAbsence;
        private System.Windows.Forms.Button buttonSupprimerAbsence;
    }
}