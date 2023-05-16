using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mediatek86.modele;

namespace Mediatek86.vue
{
    public partial class Main : Form
    {
        /// <summary>
        /// Main()
        /// </summary>
        public Main()
        {
            InitializeComponent();

        }

        /// <summary>
        /// GetDataGridView()
        /// </summary>
        public DataGridView GetDataGridView()
        {
            return dataGridView1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadData();
        }
        /// <summary>
        /// loadData()
        /// </summary>
        public void loadData()
        {
            // Empêcher le redimensionnement de la fenêtre
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Désactiver le bouton "Agrandir"
            this.MaximizeBox = false;

            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM personnel";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                // Redimensionner automatiquement les colonnes pour remplir complètement le DataGridView + désactiver le redimmensionnement mannuel + définition de la hauteur à 50px
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.AllowUserToResizeRows = false;


                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation de déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
        }


        private void buttonAjouterPersonnel_Click(object sender, EventArgs e)
        {
            AjouterPersonnel formAjouterPersonnel = new AjouterPersonnel();
            DialogResult result = formAjouterPersonnel.ShowDialog(this);


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                buttonSupprimerPersonnel1.Enabled = true;
            }
            else
            {
                buttonSupprimerPersonnel1.Enabled = false;
            }
        }


        private void buttonSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int personnelId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDPERSONNEL"].Value);

                try
                {
                    var database = new Database();
                    database.connect_db();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Personnel WHERE IDPERSONNEL = @PersonnelId");
                    cmd.Parameters.AddWithValue("@PersonnelId", personnelId);
                    cmd.Connection = database.mySqlConnection;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personnel supprimé avec succès !");

                    // Recharger les données du DataGridView
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Personnel", database.mySqlConnection);
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception)
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression du personnel");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour modifier un personnel.");
            }
        }

        private void buttonAfficherAbsence_Click(object sender, EventArgs e)
        {
            // Vérifier si une seule ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Récupérer l'ID du personnel sélectionné
                int personnelId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDPERSONNEL"].Value);

                // Passer l'ID du personnel sélectionné au formulaire Absences
                Absence Absence = new Absence(personnelId);
                Absence.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour voir les absences.");
            }
        }

        private void buttonModifierPersonnel_Click(object sender, EventArgs e)
        {
            // Vérifier si une seule ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Récupérer l'ID du personnel sélectionné
                int personnelId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDPERSONNEL"].Value);

                // Afficher le formulaire ModifierPersonnel
                ModifierPersonnel formModifierPersonnel = new ModifierPersonnel(personnelId, this);
                formModifierPersonnel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour modifier un personnel.");
            }
        }

        private void buttonAjouterPersonnel_Click_1(object sender, EventArgs e)
        {
                AjouterPersonnel formAjouterPersonnel = new AjouterPersonnel();
                DialogResult result = formAjouterPersonnel.ShowDialog(this);

        }

        private void buttonModifierPersonnel_Click_1(object sender, EventArgs e)
        {
            // Vérifier si une seule ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Récupérer l'ID du personnel sélectionné
                int personnelId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDPERSONNEL"].Value);

                // Afficher le formulaire ModifierPersonnel
                ModifierPersonnel formModifierPersonnel = new ModifierPersonnel(personnelId, this);
                formModifierPersonnel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour modifier un personnel.");
            }
        }

        private void buttonSupprimerPersonnel_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}
