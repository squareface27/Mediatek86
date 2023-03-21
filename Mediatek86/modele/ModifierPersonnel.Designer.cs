
namespace Mediatek86.modele
{
    partial class ModifierPersonnel
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
            this.IdPersonnel = new System.Windows.Forms.Label();
            this.textBoxIdPersonnel = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.Telephone = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.Service = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdPersonnel
            // 
            this.IdPersonnel.AutoSize = true;
            this.IdPersonnel.Location = new System.Drawing.Point(74, 72);
            this.IdPersonnel.Name = "IdPersonnel";
            this.IdPersonnel.Size = new System.Drawing.Size(18, 13);
            this.IdPersonnel.TabIndex = 0;
            this.IdPersonnel.Text = "ID";
            // 
            // textBoxIdPersonnel
            // 
            this.textBoxIdPersonnel.Location = new System.Drawing.Point(158, 72);
            this.textBoxIdPersonnel.Name = "textBoxIdPersonnel";
            this.textBoxIdPersonnel.Size = new System.Drawing.Size(121, 20);
            this.textBoxIdPersonnel.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(74, 118);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 2;
            this.Nom.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(158, 118);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(121, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(77, 164);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 4;
            this.Prenom.Text = "Prénom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(158, 164);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrenom.TabIndex = 5;
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Location = new System.Drawing.Point(77, 206);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(58, 13);
            this.Telephone.TabIndex = 6;
            this.Telephone.Text = "Téléphone";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(158, 206);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(121, 20);
            this.textBoxTelephone.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(80, 254);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(158, 254);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // Service
            // 
            this.Service.AutoSize = true;
            this.Service.Location = new System.Drawing.Point(80, 312);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(43, 13);
            this.Service.TabIndex = 10;
            this.Service.Text = "Service";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(158, 312);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(121, 21);
            this.comboBoxService.TabIndex = 11;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Coral;
            this.buttonAnnuler.Location = new System.Drawing.Point(542, 402);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(99, 23);
            this.buttonAnnuler.TabIndex = 14;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonValider.Location = new System.Drawing.Point(680, 402);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(99, 23);
            this.buttonValider.TabIndex = 13;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // ModifierPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.textBoxIdPersonnel);
            this.Controls.Add(this.IdPersonnel);
            this.Name = "ModifierPersonnel";
            this.Text = "Modifier un personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdPersonnel;
        private System.Windows.Forms.TextBox textBoxIdPersonnel;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label Service;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
    }
}