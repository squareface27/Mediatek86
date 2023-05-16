
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
            this.buttonSupprimerPersonnel = new System.Windows.Forms.Button();
            this.buttonModifierPersonnel = new System.Windows.Forms.Button();
            this.buttonAjouterPersonnel = new System.Windows.Forms.Button();
            this.listePersonnel = new System.Windows.Forms.DataGridView();
            this.btnAnnulerPersonnel = new System.Windows.Forms.Button();
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
            this.buttonAfficherAbsence = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEnregistrerAbsence = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSupprimerAbsence = new System.Windows.Forms.Button();
            this.buttonModifierAbsence = new System.Windows.Forms.Button();
            this.buttonAjouterAbsence = new System.Windows.Forms.Button();
            this.listeAbsence = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listePersonnel)).BeginInit();
            this.modifierPersonnel.SuspendLayout();
            this.grbLesDeveloppeurs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeAbsence)).BeginInit();
            this.SuspendLayout();
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
            // btnAnnulerPersonnel
            // 
            this.btnAnnulerPersonnel.Location = new System.Drawing.Point(87, 98);
            this.btnAnnulerPersonnel.Name = "btnAnnulerPersonnel";
            this.btnAnnulerPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerPersonnel.TabIndex = 10;
            this.btnAnnulerPersonnel.Text = "annuler";
            this.btnAnnulerPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulerPersonnel.Click += new System.EventHandler(this.btnAnnulerPersonnel_Click);
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
            this.modifierPersonnel.Controls.Add(this.btnAnnulerPersonnel);
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
            this.grbLesDeveloppeurs.Controls.Add(this.buttonAfficherAbsence);
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
            // buttonAfficherAbsence
            // 
            this.buttonAfficherAbsence.Location = new System.Drawing.Point(376, 231);
            this.buttonAfficherAbsence.Name = "buttonAfficherAbsence";
            this.buttonAfficherAbsence.Size = new System.Drawing.Size(111, 23);
            this.buttonAfficherAbsence.TabIndex = 4;
            this.buttonAfficherAbsence.Text = "afficher absences";
            this.buttonAfficherAbsence.UseVisualStyleBackColor = true;
            this.buttonAfficherAbsence.Click += new System.EventHandler(this.buttonAfficherAbsence_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.buttonEnregistrerAbsence);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(779, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "modifier une absence";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonEnregistrerAbsence
            // 
            this.buttonEnregistrerAbsence.Location = new System.Drawing.Point(6, 98);
            this.buttonEnregistrerAbsence.Name = "buttonEnregistrerAbsence";
            this.buttonEnregistrerAbsence.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrerAbsence.TabIndex = 9;
            this.buttonEnregistrerAbsence.Text = "enregistrer";
            this.buttonEnregistrerAbsence.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(354, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "tel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "prenom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 19);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 45);
            this.textBox2.MaxLength = 15;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 45);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "nom";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(54, 19);
            this.textBox4.MaxLength = 20;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 20);
            this.textBox4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSupprimerAbsence);
            this.groupBox2.Controls.Add(this.buttonModifierAbsence);
            this.groupBox2.Controls.Add(this.buttonAjouterAbsence);
            this.groupBox2.Controls.Add(this.listeAbsence);
            this.groupBox2.Location = new System.Drawing.Point(779, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 264);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Absences";
            // 
            // buttonSupprimerAbsence
            // 
            this.buttonSupprimerAbsence.Location = new System.Drawing.Point(168, 231);
            this.buttonSupprimerAbsence.Name = "buttonSupprimerAbsence";
            this.buttonSupprimerAbsence.Size = new System.Drawing.Size(85, 23);
            this.buttonSupprimerAbsence.TabIndex = 3;
            this.buttonSupprimerAbsence.Text = "supprimer";
            this.buttonSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // buttonModifierAbsence
            // 
            this.buttonModifierAbsence.Location = new System.Drawing.Point(87, 231);
            this.buttonModifierAbsence.Name = "buttonModifierAbsence";
            this.buttonModifierAbsence.Size = new System.Drawing.Size(75, 23);
            this.buttonModifierAbsence.TabIndex = 2;
            this.buttonModifierAbsence.Text = "modifier";
            this.buttonModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterAbsence
            // 
            this.buttonAjouterAbsence.Location = new System.Drawing.Point(6, 231);
            this.buttonAjouterAbsence.Name = "buttonAjouterAbsence";
            this.buttonAjouterAbsence.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterAbsence.TabIndex = 1;
            this.buttonAjouterAbsence.Text = "ajouter";
            this.buttonAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // listeAbsence
            // 
            this.listeAbsence.AllowUserToAddRows = false;
            this.listeAbsence.AllowUserToDeleteRows = false;
            this.listeAbsence.AllowUserToResizeRows = false;
            this.listeAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeAbsence.Location = new System.Drawing.Point(6, 19);
            this.listeAbsence.MultiSelect = false;
            this.listeAbsence.Name = "listeAbsence";
            this.listeAbsence.ReadOnly = true;
            this.listeAbsence.RowHeadersVisible = false;
            this.listeAbsence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.listeAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeAbsence.Size = new System.Drawing.Size(581, 206);
            this.listeAbsence.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modifierPersonnel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbLesDeveloppeurs);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listePersonnel)).EndInit();
            this.modifierPersonnel.ResumeLayout(false);
            this.modifierPersonnel.PerformLayout();
            this.grbLesDeveloppeurs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSupprimerPersonnel;
        private System.Windows.Forms.Button buttonModifierPersonnel;
        private System.Windows.Forms.Button buttonAjouterPersonnel;
        private System.Windows.Forms.DataGridView listePersonnel;
        private System.Windows.Forms.Button btnAnnulerPersonnel;
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
        private System.Windows.Forms.Button buttonAfficherAbsence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEnregistrerAbsence;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSupprimerAbsence;
        private System.Windows.Forms.Button buttonModifierAbsence;
        private System.Windows.Forms.Button buttonAjouterAbsence;
        private System.Windows.Forms.DataGridView listeAbsence;
    }
}