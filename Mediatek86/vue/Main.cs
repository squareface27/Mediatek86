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
            return listePersonnel;
        }

        private DataGridView dataGridViewAbsences;

        public DataGridView DataGridViewAbsences
        {
            get { return dataGridViewAbsences; }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadData();
        }
        /// <summary>
        /// Insertion des données dans dataGridView
        /// </summary>
        public void loadData()
        {
            GetService();

            // Empêcher le redimensionnement de la fenêtre
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Désactiver le bouton "Agrandir"
            this.MaximizeBox = false;

            // Désactiver les zones de texte de modification Personnel
            txtMail.Enabled = false;
            txtPrenom.Enabled = false;
            txtNom.Enabled = false;
            txtTel.Enabled = false;
            cboService.Enabled = false;

            // Désactiver les zones de texte de modification Absence
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox1.Enabled = false;

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

                listePersonnel.DataSource = bindingSource;


                // Redimensionner automatiquement les colonnes pour remplir complètement le DataGridView (Liste Personnel) + désactiver le redimmensionnement mannuel + définition de la hauteur à 50px
                listePersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                listePersonnel.RowTemplate.Height = 50;
                listePersonnel.AllowUserToResizeColumns = false;
                listePersonnel.AllowUserToResizeRows = false;

                // Redimensionner automatiquement les colonnes pour remplir complètement le DataGridView (Absence) + désactiver le redimmensionnement mannuel + définition de la hauteur à 50px
                listeAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                listeAbsence.RowTemplate.Height = 50;
                listeAbsence.AllowUserToResizeColumns = false;
                listeAbsence.AllowUserToResizeRows = false;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }


        private void buttonAjouterPersonnel_Click(object sender, EventArgs e)
        {
            AjouterPersonnel formAjouterPersonnel = new AjouterPersonnel();
            DialogResult result = formAjouterPersonnel.ShowDialog(this);



        }


        private void buttonSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (listePersonnel.SelectedRows.Count == 1)
            {
                int personnelId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDPERSONNEL"].Value);

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
                    listePersonnel.DataSource = dataTable;
                }
                catch (Exception)
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression du personnel");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour supprimer un personnel.");
            }
        }



        private void buttonAjouterPersonnel_Click_1(object sender, EventArgs e)
        {
            AjouterPersonnel formAjouterPersonnel = new AjouterPersonnel();
            DialogResult result = formAjouterPersonnel.ShowDialog(this);

        }

        /// <summary>
        /// ServiceName
        /// </summary>
        public class ServiceName
        {
            /// <summary>
            /// Name
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// Id
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// ServiceName
            /// </summary>
            public ServiceName(string name, int id)
            {
                Name = name;
                Id = id;
            }

            /// <summary>
            /// ToString()
            /// </summary>
            public override string ToString()
            {
                return Name;
            }
        }

        private List<ServiceName> services;
        private void GetService()
        {
            services = new List<ServiceName>();

            // Parcourez les lignes du DataGridView et ajoutez les services à la liste
            foreach (DataGridViewRow row in listePersonnel.Rows)
            {
                string service = row.Cells["IDSERVICE"].Value.ToString();
                int serviceId = Convert.ToInt32(row.Cells["IDSERVICE"].Value);
                if (!services.Any(s => s.Id == serviceId))
                {
                    services.Add(new ServiceName(service, serviceId));
                }
            }

            // Ajoutez les autres services disponibles à la liste
            services.Add(new ServiceName("Administratif", 1));
            services.Add(new ServiceName("Médiation culturelle", 2));
            services.Add(new ServiceName("Prêt", 3));

            // Liez la liste à la ComboBox
            cboService.DataSource = services;
        }


        private void buttonModifierPersonnel_Click_1(object sender, EventArgs e)
        {
            if (listePersonnel.SelectedRows.Count == 1)
            {
                // Récupérer les valeurs de la ligne sélectionnée
                DataGridViewRow selectedRow = listePersonnel.SelectedRows[0];
                string email = selectedRow.Cells["MAIL"].Value.ToString();
                string prenom = selectedRow.Cells["PRENOM"].Value.ToString();
                string nom = selectedRow.Cells["NOM"].Value.ToString();
                string telephone = selectedRow.Cells["TEL"].Value.ToString();

                int serviceId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDSERVICE"].Value);
                ServiceName selectedService = services.Find(s => s.Id == serviceId);
                cboService.SelectedItem = selectedService;



                // ...

                // Assigner les valeurs aux zones de texte
                txtMail.Text = email;
                txtPrenom.Text = prenom;
                txtNom.Text = nom;
                txtTel.Text = telephone;

                // Activer les zones de texte pour modification
                txtMail.Enabled = true;
                txtPrenom.Enabled = true;
                txtNom.Enabled = true;
                txtTel.Enabled = true;
                cboService.Enabled = true;


                // ...
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour modifier.");
            }
        }

        private void buttonSupprimerPersonnel_Click_1(object sender, EventArgs e)
        {
            {
                if (listePersonnel.SelectedRows.Count == 1)
                {
                    int personnelId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDPERSONNEL"].Value);

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
                        listePersonnel.DataSource = dataTable;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression du personnel");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une seule ligne pour supprimer un personnel.");
                }
            }

        }

        private void btnAnnulerPersonnel_Click(object sender, EventArgs e)
        {
            // Désactiver les zones de texte de modification
            txtMail.Enabled = false;
            txtPrenom.Enabled = false;
            txtNom.Enabled = false;
            txtTel.Enabled = false;
            cboService.Enabled = false;
        }

        private void btnEnregisterPersonnel_Click(object sender, EventArgs e)
        {

            // Récupérer l'ID du personnel sélectionné
            int personnelId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDPERSONNEL"].Value);

            // Récupérer les nouvelles valeurs des zones de texte
            string email = txtMail.Text;
            string prenom = txtPrenom.Text;
            string nom = txtNom.Text;
            string telephone = txtTel.Text;

            // Récupérer la valeur sélectionnée dans la ComboBox
            ServiceName selectedService = (ServiceName)cboService.SelectedItem;
            int serviceId = selectedService.Id;

            try
            {
                var database = new Database();
                database.connect_db();

                // Construire la requête de mise à jour
                string query = "UPDATE Personnel SET MAIL = @mail, PRENOM = @prenom, NOM = @nom, TEL = @tel, IDSERVICE = @idservice WHERE IDPERSONNEL = @personnelId";

                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = database.mySqlConnection;
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@tel", telephone);
                cmd.Parameters.AddWithValue("@idservice", serviceId);
                cmd.Parameters.AddWithValue("@personnelId", personnelId);

                // Exécuter la requête de mise à jour
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Personnel mis à jour avec succès !");

                    // Recharger les données du DataGridView
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Personnel", database.mySqlConnection);
                    dataAdapter.Fill(dataTable);
                    listePersonnel.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la mise à jour du personnel : " + ex.Message);
            }

        }

        private void buttonAfficherAbsence_Click(object sender, EventArgs e)
        {
            if (listePersonnel.SelectedRows.Count == 1)
            {
                // Récupérer l'ID du personnel sélectionné
                int personnelId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDPERSONNEL"].Value);

                try
                {
                    var database = new Database();
                    database.connect_db();

                    // Construire la requête pour récupérer les absences du personnel sélectionné
                    string query = "SELECT * FROM Absence WHERE IDPERSONNEL = @personnelId";
                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Connection = database.mySqlConnection;
                    cmd.Parameters.AddWithValue("@personnelId", personnelId);

                    // Exécuter la requête et récupérer les résultats dans un DataTable
                    DataTable absencesTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(absencesTable);
                    }

                    // Afficher les résultats dans le deuxième DataGridView
                    listeAbsence.DataSource = absencesTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la récupération des absences : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour afficher les absences.");
            }
        }


        private void buttonAjouterAbsence_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (listePersonnel.SelectedRows.Count == 1)
            {
                // Récupérer l'ID du personnel sélectionné
                int personnelId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDPERSONNEL"].Value);

                // Ouvrir le formulaire AjouterAbsence en passant l'ID du personnel sélectionné
                AjouterAbsence ajouterAbsence = new AjouterAbsence(personnelId, this);
                ajouterAbsence.ShowDialog();


            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour ajouter une absence.");
            }
        }

        public DataTable GetAbsences()
        {
            DataTable absencesTable = new DataTable();

            try
            {
                var database = new Database();
                database.connect_db();

                // Construire la requête pour récupérer les absences du personnel sélectionné
                string query = "SELECT * FROM Absence";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = database.mySqlConnection;

                // Exécuter la requête et récupérer les résultats dans un DataTable
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(absencesTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des absences : " + ex.Message);
            }

            return absencesTable;
        }


        private void buttonSupprimerAbsence_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (listeAbsence.SelectedRows.Count > 0)
            {
                // Récupérer les valeurs des colonnes nécessaires pour la ligne sélectionnée
                int selectedPersonnelID = (int)listeAbsence.SelectedRows[0].Cells["IDPERSONNEL"].Value;
                DateTime selectedDateDebut = (DateTime)listeAbsence.SelectedRows[0].Cells["DATEDEBUT"].Value;
                int selectedMotifID = (int)listeAbsence.SelectedRows[0].Cells["IDMOTIF"].Value;
                DateTime selectedDateFin = (DateTime)listeAbsence.SelectedRows[0].Cells["DATEFIN"].Value;

                try
                {
                    var database = new Database();
                    database.connect_db();

                    // Créer une commande SQL pour supprimer la ligne en utilisant les valeurs récupérées
                    string query = "DELETE FROM Absence WHERE IDPERSONNEL = @PersonnelID AND DATEDEBUT = @DateDebut AND IDMOTIF = @MotifID AND DATEFIN = @DateFin";
                    MySqlCommand cmd = new MySqlCommand(query);

                    // Ajouter les paramètres pour les valeurs récupérées
                    cmd.Parameters.AddWithValue("@PersonnelID", selectedPersonnelID);
                    cmd.Parameters.AddWithValue("@DateDebut", selectedDateDebut);
                    cmd.Parameters.AddWithValue("@MotifID", selectedMotifID);
                    cmd.Parameters.AddWithValue("@DateFin", selectedDateFin);
                    cmd.Connection = database.mySqlConnection;

                    // Exécuter la commande
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Absence supprimée avec succès !");

                    // Recharger les données du DataGridView
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Absence", database.mySqlConnection);
                    dataAdapter.Fill(dataTable);
                    listeAbsence.DataSource = dataTable;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression de l'absence" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour supprimer une absence.");
            }
        }


        public class MotifItem
        {
            public int MotifId { get; set; }
            public string Libelle { get; set; }

            public MotifItem(int motifId, string libelle)
            {
                MotifId = motifId;
                Libelle = libelle;
            }

            public override string ToString()
            {
                return Libelle;
            }
        }

        private int selectedPersonnelID;
        private DateTime ancienneDateDebut;
        private int ancienMotifID;
        private DateTime ancienneDateFin;


        private void buttonModifierAbsence_Click(object sender, EventArgs e)
        {
            // Active les zones de texte de modification Absence
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            comboBox1.Enabled = true;

            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (listeAbsence.SelectedRows.Count > 0)
            {
                // Récupérer les valeurs des colonnes nécessaires pour la ligne sélectionnée
                selectedPersonnelID = (int)listeAbsence.SelectedRows[0].Cells["IDPERSONNEL"].Value;
                ancienneDateDebut = (DateTime)listeAbsence.SelectedRows[0].Cells["DATEDEBUT"].Value;
                int selectedMotifID = (int)listeAbsence.SelectedRows[0].Cells["IDMOTIF"].Value;
                DateTime selectedDateFin = (DateTime)listeAbsence.SelectedRows[0].Cells["DATEFIN"].Value;

                // Utiliser les valeurs pour définir les propriétés des contrôles appropriés
                // DateTimePicker pour les dates
                dateTimePicker1.Value = ancienneDateDebut;
                dateTimePicker2.Value = selectedDateFin;



                var database = new Database();
                database.connect_db();

                
                string query = "SELECT IDMOTIF, LIBELLE FROM motif";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = database.mySqlConnection;

                MySqlDataReader reader = cmd.ExecuteReader();

                comboBox1.Items.Clear();

                while (reader.Read())
                {
                    int motifId = (int)reader["IDMOTIF"];
                    string libelle = (string)reader["LIBELLE"];

                    comboBox1.Items.Add(new MotifItem(motifId, libelle));

                }

                foreach (MotifItem item in comboBox1.Items)
                {
                    if (item.MotifId == selectedMotifID)
                    {
                        comboBox1.SelectedItem = item;
                        break;
                    }
                }



            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour modifier une absence.");
            }
        }




        private void buttonEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            DateTime nouvelleDateDebut = dateTimePicker1.Value;
            DateTime nouvelleDateFin = dateTimePicker2.Value;
            MotifItem motifSelectionne = (MotifItem)comboBox1.SelectedItem;
            int newMotifID = motifSelectionne.MotifId;

            try
            {
                var database = new Database();
                database.connect_db();

                string query = "UPDATE Absence SET DATEDEBUT = @nouvelleDateDebut, DATEFIN = @nouvelleDateFin, IDMOTIF = @nouvelMotifID WHERE IDPERSONNEL = @personnelId AND (DATEDEBUT = @ancienneDateDebut OR DATEFIN = @ancienneDateFin OR IDMOTIF = @ancienMotifID)";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = database.mySqlConnection;
                cmd.Parameters.AddWithValue("@nouvelleDateDebut", nouvelleDateDebut);
                cmd.Parameters.AddWithValue("@nouvelleDateFin", nouvelleDateFin);
                cmd.Parameters.AddWithValue("@nouvelMotifID", newMotifID);
                cmd.Parameters.AddWithValue("@personnelId", selectedPersonnelID);
                cmd.Parameters.AddWithValue("@ancienneDateDebut", ancienneDateDebut);
                cmd.Parameters.AddWithValue("@ancienneDateFin", ancienneDateFin);
                cmd.Parameters.AddWithValue("@ancienMotifID", ancienMotifID);

                // Exécuter la requête de mise à jour
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Absence mise à jour avec succès !");

                    // Recharger les données du DataGridView
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Absence", database.mySqlConnection);
                    dataAdapter.Fill(dataTable);
                    listeAbsence.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Aucune modification n'a été effectuée.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la mise à jour de l'absence : " + ex.Message);
            }
        }






        private void button2_Click(object sender, EventArgs e)
        {
            // Désactiver les zones de texte de modification
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox1.Enabled = false;
        }

        
    }
}
