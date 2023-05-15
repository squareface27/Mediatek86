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

namespace Mediatek86.modele
{
    /// <summary>
    /// Absence
    /// </summary>
    public partial class Absence : Form
    {
        private int personnelId;

        /// <summary>
        /// Asence
        /// </summary>
        public Absence(int personnelId)
        {
            InitializeComponent();
            LoadAbsences(personnelId);
            this.personnelId = personnelId;
            loadData();

        }


        /// <summary>
        /// loadData
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
                string query = "SELECT * FROM absence";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadAbsences(int personnelId)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM absence WHERE IDPERSONNEL=@personnelId";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                mySqlCommand.Parameters.AddWithValue("@personnelId", personnelId);
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

    }
}
