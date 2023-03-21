
namespace Mediatek86.vue
{
    partial class Main
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
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonAjouterPersonnel = new System.Windows.Forms.Button();
            this.buttonModifierPersonnel = new System.Windows.Forms.Button();
            this.buttonSupprimerPersonnel = new System.Windows.Forms.Button();
            this.buttonAfficherAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(986, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Coral;
            this.buttonDisconnect.Location = new System.Drawing.Point(910, 411);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(123, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Se déconnecter";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonAjouterPersonnel
            // 
            this.buttonAjouterPersonnel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAjouterPersonnel.Location = new System.Drawing.Point(69, 411);
            this.buttonAjouterPersonnel.Name = "buttonAjouterPersonnel";
            this.buttonAjouterPersonnel.Size = new System.Drawing.Size(126, 23);
            this.buttonAjouterPersonnel.TabIndex = 2;
            this.buttonAjouterPersonnel.Text = "Ajouter un personnel";
            this.buttonAjouterPersonnel.UseVisualStyleBackColor = false;
            this.buttonAjouterPersonnel.Click += new System.EventHandler(this.buttonAjouterPersonnel_Click);
            // 
            // buttonModifierPersonnel
            // 
            this.buttonModifierPersonnel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonModifierPersonnel.Location = new System.Drawing.Point(245, 411);
            this.buttonModifierPersonnel.Name = "buttonModifierPersonnel";
            this.buttonModifierPersonnel.Size = new System.Drawing.Size(134, 23);
            this.buttonModifierPersonnel.TabIndex = 3;
            this.buttonModifierPersonnel.Text = "Modifier un personnel";
            this.buttonModifierPersonnel.UseVisualStyleBackColor = false;
            this.buttonModifierPersonnel.Click += new System.EventHandler(this.buttonModifierPersonnel_Click);
            // 
            // buttonSupprimerPersonnel
            // 
            this.buttonSupprimerPersonnel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSupprimerPersonnel.Location = new System.Drawing.Point(424, 411);
            this.buttonSupprimerPersonnel.Name = "buttonSupprimerPersonnel";
            this.buttonSupprimerPersonnel.Size = new System.Drawing.Size(142, 23);
            this.buttonSupprimerPersonnel.TabIndex = 4;
            this.buttonSupprimerPersonnel.Text = "Supprimer un personnel";
            this.buttonSupprimerPersonnel.UseVisualStyleBackColor = false;
            this.buttonSupprimerPersonnel.Click += new System.EventHandler(this.buttonSupprimerPersonnel_Click);
            // 
            // buttonAfficherAbsence
            // 
            this.buttonAfficherAbsence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAfficherAbsence.Location = new System.Drawing.Point(606, 411);
            this.buttonAfficherAbsence.Name = "buttonAfficherAbsence";
            this.buttonAfficherAbsence.Size = new System.Drawing.Size(142, 23);
            this.buttonAfficherAbsence.TabIndex = 5;
            this.buttonAfficherAbsence.Text = "Afficher les absences";
            this.buttonAfficherAbsence.UseVisualStyleBackColor = false;
            this.buttonAfficherAbsence.Click += new System.EventHandler(this.buttonAfficherAbsence_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 550);
            this.Controls.Add(this.buttonAfficherAbsence);
            this.Controls.Add(this.buttonSupprimerPersonnel);
            this.Controls.Add(this.buttonModifierPersonnel);
            this.Controls.Add(this.buttonAjouterPersonnel);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonAjouterPersonnel;
        private System.Windows.Forms.Button buttonModifierPersonnel;
        private System.Windows.Forms.Button buttonSupprimerPersonnel;
        private System.Windows.Forms.Button buttonAfficherAbsence;
    }
}