using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mediatek86.modele;
using Mediatek86.vue;

namespace Mediatek86.modele
{
    public partial class ModifierPersonnel : Form
    {
        private readonly int personnelId;
        private readonly Main formMain;

        /// <summary>
        /// ModifierPersonnel
        /// </summary>
        public ModifierPersonnel(int personnelId, Main formMain)
        {
            InitializeComponent();
            this.personnelId = personnelId;
            this.formMain = formMain;
        }

        private void ModifierPersonnel_Load(object sender, EventArgs e)
        {
            // Charger les données du personnel à modifier
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM personnel WHERE IDPERSONNEL = @personnelId";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Parameters.AddWithValue("@personnelId", personnelId);
                mySqlCommand.Connection = database.mySqlConnection;

                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxNom.Text = reader["NOM"].ToString();
                        textBoxPrenom.Text = reader["PRENOM"].ToString();
                        textBoxTelephone.Text = reader["TEL"].ToString();
                        textBoxEmail.Text = reader["MAIL"].ToString();
                        comboBoxService.SelectedItem = reader["SERVICE"].ToString();
                    }
                }

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir modifier ce personnel ?", "Confirmation de modification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Modifier les données du personnel dans la base de données
                var database = new Database();
                if (database.connect_db())
                {
                    string query = "UPDATE personnel SET NOM = @nom, PRENOM = @prenom, TEL = @tel, MAIL = @mail, SERVICE = @service WHERE IDPERSONNEL = @personnelId";
                    MySqlCommand mySqlCommand = new MySqlCommand(query);
                    mySqlCommand.Parameters.AddWithValue("@nom", textBoxNom.Text);
                    mySqlCommand.Parameters.AddWithValue("@prenom", textBoxPrenom.Text);
                    mySqlCommand.Parameters.AddWithValue("@tel", textBoxTelephone.Text);
                    mySqlCommand.Parameters.AddWithValue("@mail", textBoxEmail.Text);
                    mySqlCommand.Parameters.AddWithValue("@service", comboBoxService.SelectedItem.ToString());
                    mySqlCommand.Parameters.AddWithValue("@personnelId", personnelId);
                    mySqlCommand.Connection = database.mySqlConnection;
                    mySqlCommand.ExecuteNonQuery();

                    database.close_db();

                    // Rafraîchir les données dans le DataGridView de la fenêtre principale
                    formMain.loadData();

                    MessageBox.Show("Le personnel a été modifié avec succès.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Database error");
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            // Fermer la fenêtre
            this.Close();
        }
    }
}
