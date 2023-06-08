using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        /// <summary>
        /// DataGridViewAbsences
        /// </summary>
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

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            txtMail.Enabled = false;
            txtPrenom.Enabled = false;
            txtNom.Enabled = false;
            txtTel.Enabled = false;
            cboService.Enabled = false;

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

                listePersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                listePersonnel.RowTemplate.Height = 50;
                listePersonnel.AllowUserToResizeColumns = false;
                listePersonnel.AllowUserToResizeRows = false;

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


        // Bouton supprimer un personnel
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


        // Bouton ajouter un personnel

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

            foreach (DataGridViewRow row in listePersonnel.Rows)
            {
                string service = row.Cells["IDSERVICE"].Value.ToString();
                int serviceId = Convert.ToInt32(row.Cells["IDSERVICE"].Value);
                if (!services.Any(s => s.Id == serviceId))
                {
                    services.Add(new ServiceName(service, serviceId));
                }
            }

            services.Add(new ServiceName("Administratif", 1));
            services.Add(new ServiceName("Médiation culturelle", 2));
            services.Add(new ServiceName("Prêt", 3));

            cboService.DataSource = services;
        }


        private void buttonModifierPersonnel_Click_1(object sender, EventArgs e)
        {
            if (listePersonnel.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = listePersonnel.SelectedRows[0];
                string email = selectedRow.Cells["MAIL"].Value.ToString();
                string prenom = selectedRow.Cells["PRENOM"].Value.ToString();
                string nom = selectedRow.Cells["NOM"].Value.ToString();
                string telephone = selectedRow.Cells["TEL"].Value.ToString();

                int serviceId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDSERVICE"].Value);
                ServiceName selectedService = services.Find(s => s.Id == serviceId);
                cboService.SelectedItem = selectedService;


                txtMail.Text = email;
                txtPrenom.Text = prenom;
                txtNom.Text = nom;
                txtTel.Text = telephone;

                txtMail.Enabled = true;
                txtPrenom.Enabled = true;
                txtNom.Enabled = true;
                txtTel.Enabled = true;
                cboService.Enabled = true;


            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour modifier.");
            }
        }

        // Bouton supprimer un personnel
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

        // Bouton annuler modification personnel
        private void btnAnnulerPersonnel_Click(object sender, EventArgs e)
        {
            txtMail.Enabled = false;
            txtPrenom.Enabled = false;
            txtNom.Enabled = false;
            txtTel.Enabled = false;
            cboService.Enabled = false;
        }

        // Bouton enregistrer le personnel modifié
        private void btnEnregisterPersonnel_Click(object sender, EventArgs e)
        {

            int personnelId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDPERSONNEL"].Value);

            string email = txtMail.Text;
            string prenom = txtPrenom.Text;
            string nom = txtNom.Text;
            string telephone = txtTel.Text;

            ServiceName selectedService = (ServiceName)cboService.SelectedItem;
            int serviceId = selectedService.Id;

            try
            {
                var database = new Database();
                database.connect_db();

                string query = "UPDATE Personnel SET MAIL = @mail, PRENOM = @prenom, NOM = @nom, TEL = @tel, IDSERVICE = @idservice WHERE IDPERSONNEL = @personnelId";

                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = database.mySqlConnection;
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@tel", telephone);
                cmd.Parameters.AddWithValue("@idservice", serviceId);
                cmd.Parameters.AddWithValue("@personnelId", personnelId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Personnel mis à jour avec succès !");

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

        // Bouton afficher les absences d'un personnel
        private void buttonAfficherAbsence_Click(object sender, EventArgs e)
        {
            if (listePersonnel.SelectedRows.Count == 1)
            {
                int personnelId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDPERSONNEL"].Value);

                try
                {
                    var database = new Database();
                    database.connect_db();

                    string query = "SELECT * FROM Absence WHERE IDPERSONNEL = @personnelId";
                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Connection = database.mySqlConnection;
                    cmd.Parameters.AddWithValue("@personnelId", personnelId);

                    DataTable absencesTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(absencesTable);
                    }

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

        // Bouton ajouter une absence
        private void buttonAjouterAbsence_Click(object sender, EventArgs e)
        {
            if (listePersonnel.SelectedRows.Count == 1)
            {
                int personnelId = Convert.ToInt32(listePersonnel.SelectedRows[0].Cells["IDPERSONNEL"].Value);
                AjouterAbsence ajouterAbsence = new AjouterAbsence(personnelId, this, listeAbsence);
                ajouterAbsence.ShowDialog();


            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne pour ajouter une absence.");
            }
        }

        /// <summary>
        /// GetAbsence()
        /// </summary>
        public DataTable GetAbsences()
        {
            DataTable absencesTable = new DataTable();

            try
            {
                var database = new Database();
                database.connect_db();

                string query = "SELECT * FROM Absence";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = database.mySqlConnection;

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

        // Bouton supprimer une absence
        private void buttonSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (listeAbsence.SelectedRows.Count > 0)
            {
                int selectedPersonnelID = (int)listeAbsence.SelectedRows[0].Cells["IDPERSONNEL"].Value;
                DateTime selectedDateDebut = (DateTime)listeAbsence.SelectedRows[0].Cells["DATEDEBUT"].Value;
                int selectedMotifID = (int)listeAbsence.SelectedRows[0].Cells["IDMOTIF"].Value;
                DateTime selectedDateFin = (DateTime)listeAbsence.SelectedRows[0].Cells["DATEFIN"].Value;

                try
                {
                    var database = new Database();
                    database.connect_db();

                    string query = "DELETE FROM Absence WHERE IDPERSONNEL = @PersonnelID AND DATEDEBUT = @DateDebut AND IDMOTIF = @MotifID AND DATEFIN = @DateFin";
                    MySqlCommand cmd = new MySqlCommand(query);

                    cmd.Parameters.AddWithValue("@PersonnelID", selectedPersonnelID);
                    cmd.Parameters.AddWithValue("@DateDebut", selectedDateDebut);
                    cmd.Parameters.AddWithValue("@MotifID", selectedMotifID);
                    cmd.Parameters.AddWithValue("@DateFin", selectedDateFin);
                    cmd.Connection = database.mySqlConnection;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Absence supprimée avec succès !");

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Absence WHERE IDPERSONNEL = @PersonnelID", database.mySqlConnection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@PersonnelID", selectedPersonnelID);
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

        /// <summary>
        /// MotifItem
        /// </summary>
        public class MotifItem
        {
            /// <summary>
            /// MotifId
            /// </summary>
            public int MotifId { get; set; }
            /// <summary>
            /// Libelle
            /// </summary>
            public string Libelle { get; set; }

            /// <summary>
            /// MotifItem
            /// </summary>
            public MotifItem(int motifId, string libelle)
            {
                MotifId = motifId;
                Libelle = libelle;
            }

            /// <summary>
            /// string
            /// </summary>
            public override string ToString()
            {
                return Libelle;
            }
        }

        private int selectedPersonnelID;
        private DateTime ancienneDateDebut;
        private int ancienMotifID;
        private DateTime ancienneDateFin;

        // Bouton modifier une absence
        private void buttonModifierAbsence_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            comboBox1.Enabled = true;

            if (listeAbsence.SelectedRows.Count > 0)
            {
                selectedPersonnelID = (int)listeAbsence.SelectedRows[0].Cells["IDPERSONNEL"].Value;
                ancienneDateDebut = (DateTime)listeAbsence.SelectedRows[0].Cells["DATEDEBUT"].Value;
                int selectedMotifID = (int)listeAbsence.SelectedRows[0].Cells["IDMOTIF"].Value;
                DateTime selectedDateFin = (DateTime)listeAbsence.SelectedRows[0].Cells["DATEFIN"].Value;

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


        // Bouton enregistrer l'absence

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

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Absence mise à jour avec succès !");

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Absence WHERE IDPERSONNEL = @personnelId", database.mySqlConnection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@personnelId", selectedPersonnelID);
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


        // Bouton annuler la modification de l'absence

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox1.Enabled = false;
        }

    }
}
