using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatek86.vue
{
    public partial class AjouterPersonnel : Form
    {
        public AjouterPersonnel()
        {
            InitializeComponent();
            LoadServices();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AjouterPersonnel_Load(object sender, EventArgs e)
        {

        }

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

            Main main = (Main)Application.OpenForms["Main"];
            DataGridView dataGridView1 = main.GetDataGridView();
        }



        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show("Personnel ajouté avec succès !");
                this.Hide();

                Main mainForm = (Main)this.Owner;
                mainForm.loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Merci de remplir tout les champs");
            }

        }

    }
}
