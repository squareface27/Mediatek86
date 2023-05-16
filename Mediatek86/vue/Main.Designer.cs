
namespace Mediatek86.vue
{
    /// <summary>
    /// Main
    /// </summary>
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
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonSupprimerPersonnel = new System.Windows.Forms.Button();
            this.buttonModifierPersonnel = new System.Windows.Forms.Button();
            this.buttonAjouterPersonnel = new System.Windows.Forms.Button();
            this.listePersonnel = new System.Windows.Forms.DataGridView();
            this.btnAnnulDev = new System.Windows.Forms.Button();
            this.btnEnregisterPersonnel = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modifierPersonnel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grbLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.listePersonnel)).BeginInit();
            this.modifierPersonnel.SuspendLayout();
            this.grbLesDeveloppeurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Coral;
            this.buttonDisconnect.Location = new System.Drawing.Point(1455, 31);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Se déconnecter";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonSupprimerPersonnel
            // 
            this.buttonSupprimerPersonnel.Location = new System.Drawing.Point(168, 231);
            this.buttonSupprimerPersonnel.Name = "buttonSupprimerPersonnel";
            this.buttonSupprimerPersonnel.Size = new System.Drawing.Size(85, 23);
            this.buttonSupprimerPersonnel.TabIndex = 3;
            this.buttonSupprimerPersonnel.Text = "supprimer";
            this.buttonSupprimerPersonnel.UseVisualStyleBackColor = true;
            this.buttonSupprimerPersonnel.Click += new System.EventHandler(this.buttonSupprimerPersonnel_Click_1);
            // 
            // buttonModifierPersonnel
            // 
            this.buttonModifierPersonnel.Location = new System.Drawing.Point(87, 231);
            this.buttonModifierPersonnel.Name = "buttonModifierPersonnel";
            this.buttonModifierPersonnel.Size = new System.Drawing.Size(75, 23);
            this.buttonModifierPersonnel.TabIndex = 2;
            this.buttonModifierPersonnel.Text = "modifier";
            this.buttonModifierPersonnel.UseVisualStyleBackColor = true;
            this.buttonModifierPersonnel.Click += new System.EventHandler(this.buttonModifierPersonnel_Click_1);
            // 
            // buttonAjouterPersonnel
            // 
            this.buttonAjouterPersonnel.Location = new System.Drawing.Point(6, 231);
            this.buttonAjouterPersonnel.Name = "buttonAjouterPersonnel";
            this.buttonAjouterPersonnel.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterPersonnel.TabIndex = 1;
            this.buttonAjouterPersonnel.Text = "ajouter";
            this.buttonAjouterPersonnel.UseVisualStyleBackColor = true;
            this.buttonAjouterPersonnel.Click += new System.EventHandler(this.buttonAjouterPersonnel_Click_1);
            // 
            // listePersonnel
            // 
            this.listePersonnel.AllowUserToAddRows = false;
            this.listePersonnel.AllowUserToDeleteRows = false;
            this.listePersonnel.AllowUserToResizeRows = false;
            this.listePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listePersonnel.Location = new System.Drawing.Point(6, 19);
            this.listePersonnel.MultiSelect = false;
            this.listePersonnel.Name = "listePersonnel";
            this.listePersonnel.ReadOnly = true;
            this.listePersonnel.RowHeadersVisible = false;
            this.listePersonnel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.listePersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listePersonnel.Size = new System.Drawing.Size(581, 206);
            this.listePersonnel.TabIndex = 0;
            // 
            // btnAnnulDev
            // 
            this.btnAnnulDev.Location = new System.Drawing.Point(87, 98);
            this.btnAnnulDev.Name = "btnAnnulDev";
            this.btnAnnulDev.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulDev.TabIndex = 10;
            this.btnAnnulDev.Text = "annuler";
            this.btnAnnulDev.UseVisualStyleBackColor = true;
            this.btnAnnulDev.Click += new System.EventHandler(this.btnAnnulDev_Click);
            // 
            // btnEnregisterPersonnel
            // 
            this.btnEnregisterPersonnel.Location = new System.Drawing.Point(6, 98);
            this.btnEnregisterPersonnel.Name = "btnEnregisterPersonnel";
            this.btnEnregisterPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnEnregisterPersonnel.TabIndex = 9;
            this.btnEnregisterPersonnel.Text = "enregistrer";
            this.btnEnregisterPersonnel.UseVisualStyleBackColor = true;
            this.btnEnregisterPersonnel.Click += new System.EventHandler(this.btnEnregisterPersonnel_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(354, 71);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(161, 21);
            this.cboService.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tel";
            // 
            // modifierPersonnel
            // 
            this.modifierPersonnel.Controls.Add(this.btnAnnulDev);
            this.modifierPersonnel.Controls.Add(this.btnEnregisterPersonnel);
            this.modifierPersonnel.Controls.Add(this.cboService);
            this.modifierPersonnel.Controls.Add(this.label5);
            this.modifierPersonnel.Controls.Add(this.label4);
            this.modifierPersonnel.Controls.Add(this.label3);
            this.modifierPersonnel.Controls.Add(this.label2);
            this.modifierPersonnel.Controls.Add(this.txtMail);
            this.modifierPersonnel.Controls.Add(this.txtTel);
            this.modifierPersonnel.Controls.Add(this.txtPrenom);
            this.modifierPersonnel.Controls.Add(this.label1);
            this.modifierPersonnel.Controls.Add(this.txtNom);
            this.modifierPersonnel.Location = new System.Drawing.Point(23, 301);
            this.modifierPersonnel.Name = "modifierPersonnel";
            this.modifierPersonnel.Size = new System.Drawing.Size(605, 129);
            this.modifierPersonnel.TabIndex = 8;
            this.modifierPersonnel.TabStop = false;
            this.modifierPersonnel.Text = "modifier un personnel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "prenom";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(354, 19);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(245, 20);
            this.txtMail.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(354, 45);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(161, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(54, 45);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(245, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 19);
            this.txtNom.MaxLength = 20;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(245, 20);
            this.txtNom.TabIndex = 3;
            // 
            // grbLesDeveloppeurs
            // 
            this.grbLesDeveloppeurs.Controls.Add(this.buttonSupprimerPersonnel);
            this.grbLesDeveloppeurs.Controls.Add(this.buttonModifierPersonnel);
            this.grbLesDeveloppeurs.Controls.Add(this.buttonAjouterPersonnel);
            this.grbLesDeveloppeurs.Controls.Add(this.listePersonnel);
            this.grbLesDeveloppeurs.Location = new System.Drawing.Point(23, 31);
            this.grbLesDeveloppeurs.Name = "grbLesDeveloppeurs";
            this.grbLesDeveloppeurs.Size = new System.Drawing.Size(605, 264);
            this.grbLesDeveloppeurs.TabIndex = 7;
            this.grbLesDeveloppeurs.TabStop = false;
            this.grbLesDeveloppeurs.Text = "Personnels";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 454);
            this.Controls.Add(this.modifierPersonnel);
            this.Controls.Add(this.grbLesDeveloppeurs);
            this.Controls.Add(this.buttonDisconnect);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listePersonnel)).EndInit();
            this.modifierPersonnel.ResumeLayout(false);
            this.modifierPersonnel.PerformLayout();
            this.grbLesDeveloppeurs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonSupprimerPersonnel;
        private System.Windows.Forms.Button buttonModifierPersonnel;
        private System.Windows.Forms.Button buttonAjouterPersonnel;
        private System.Windows.Forms.DataGridView listePersonnel;
        private System.Windows.Forms.Button btnAnnulDev;
        private System.Windows.Forms.Button btnEnregisterPersonnel;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox modifierPersonnel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grbLesDeveloppeurs;
    }
}