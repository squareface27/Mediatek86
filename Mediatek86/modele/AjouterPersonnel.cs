using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Mediatek86.vue
{
    /// <summary>
    /// AjouterPersonnel
    /// </summary>
    public partial class AjouterPersonnel : Form
    {
        private DataGridView listePersonnel;


        /// <summary>
        /// AjouterPersonnel
        /// </summary>
        public AjouterPersonnel()
        {
            InitializeComponent();
            LoadServices();
        }

        // Bouton annuler l'ajout d'un nouveau personnel
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Obtention des services selon les IDs
        private int GetServiceId(string serviceName)
        {
            int serviceId;
            switch (serviceName)
            {
                case "Administratif":
                    serviceId = 1;
                    break;
                case "Médiation culturelle":
                    serviceId = 2;
                    break;
                case "Prêt":
                    serviceId = 3;
                    break;
                default:
                    throw new ArgumentException("Service inconnu : " + serviceName);
            }
            return serviceId;
        }


        private void LoadServices()
        {
            var database = new Database();
            database.connect_db();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM service");
            cmd.Connection = database.mySqlConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["nom"].ToString());
            }

        }

        /// <summary>
        /// ListePersonnel
        /// </summary>
        public DataGridView ListePersonnel { get; set; }


        // Bouton valider l'ajout d'un personnel
        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(textBoxNom.Text) ||
                    string.IsNullOrEmpty(textBoxPrenom.Text) ||
                    string.IsNullOrEmpty(textBoxTelephone.Text) ||
                    string.IsNullOrEmpty(textBoxMail.Text) ||
                    string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Merci de remplir tous les champs.");
                    return; 
                }


                var database = new Database();
                database.connect_db();

                int serviceId = GetServiceId(comboBox1.Text);
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Personnel (IDSERVICE, NOM, PRENOM, TEL, MAIL) VALUES (@idservice, @nom, @prenom, @tel, @mail)");
                cmd.Connection = database.mySqlConnection;
                cmd.Parameters.AddWithValue("@idservice", serviceId);
                cmd.Parameters.AddWithValue("@nom", textBoxNom.Text);
                cmd.Parameters.AddWithValue("@prenom", textBoxPrenom.Text);
                cmd.Parameters.AddWithValue("@tel", textBoxTelephone.Text);
                cmd.Parameters.AddWithValue("@mail", textBoxMail.Text);
                cmd.ExecuteNonQuery();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT Personnel.IDPERSONNEL, Personnel.NOM, Personnel.PRENOM, Personnel.TEL, Personnel.MAIL, Service.NOM AS SERVICE FROM Personnel INNER JOIN Service ON Personnel.IDSERVICE = Service.IDSERVICE", database.mySqlConnection);
                dataAdapter.Fill(dataTable);
                ListePersonnel.DataSource = dataTable;


                MessageBox.Show("Personnel ajouté avec succès !");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du personnel :\n\n" + ex.ToString());
            }


        }

    }
}
