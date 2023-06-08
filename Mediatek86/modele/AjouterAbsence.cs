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
using Mediatek86.vue;

namespace Mediatek86.modele
{
    /// <summary>
    /// AjouterAbsence
    /// </summary>
    public partial class AjouterAbsence : Form
    {
        private int personnelId;
        private DataGridView listeAbsence;
        private Main mainForm;


        public AjouterAbsence(int idPersonnel, Main formPrincipal, DataGridView listeAbsence)
        {
            InitializeComponent();
            personnelId = idPersonnel;
            this.formPrincipal = formPrincipal;
            this.listeAbsence = listeAbsence;

            comboBoxMotif.Items.Add(new MotifItem(1, "Vacances"));
            comboBoxMotif.Items.Add(new MotifItem(2, "Maladie"));
            comboBoxMotif.Items.Add(new MotifItem(3, "Motif familial"));
            comboBoxMotif.Items.Add(new MotifItem(4, "Congé parental"));
            comboBoxMotif.DisplayMember = "Name";
        }

        /// <summary>
        /// MotifItem
        /// </summary>
        public class MotifItem
        {
            /// <summary>
            /// Id
            /// </summary>
            public int Id { get; set; }
            /// <summary>
            /// Name
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// MotifItem
            /// </summary>
            public MotifItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            /// <summary>
            /// string
            /// </summary>
            public override string ToString()
            {
                return Name;
            }
        }

        private Main formPrincipal;

        /// <summary>
        /// ListeAbsence
        /// </summary>
        public DataGridView ListeAbsence { get; set; }

        /// <summary>
        /// AjouterAbsence
        /// </summary>



        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs saisies par l'utilisateur
                DateTime dateDebut = dateTimePickerDebut.Value.Date;
                DateTime dateFin = dateTimePickerFin.Value.Date;
                MotifItem selectedMotif = (MotifItem)comboBoxMotif.SelectedItem;
                int motifId = selectedMotif.Id;

                // Vérifier les conditions nécessaires pour l'enregistrement de l'absence
                if (dateFin < dateDebut)
                {
                    MessageBox.Show("La date de fin doit être postérieure à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Quitter la méthode sans enregistrer l'absence
                }

                // Enregistrer l'absence dans la base de données
                var database = new Database();
                database.connect_db();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Absence (IDPERSONNEL, DATEDEBUT, DATEFIN, IDMOTIF) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif)");
                cmd.Connection = database.mySqlConnection;
                cmd.Parameters.AddWithValue("@idpersonnel", personnelId); // Utiliser l'idpersonnel sélectionné
                cmd.Parameters.AddWithValue("@datedebut", dateDebut);
                cmd.Parameters.AddWithValue("@datefin", dateFin);
                cmd.Parameters.AddWithValue("@idmotif", motifId);
                cmd.ExecuteNonQuery();


                // Recharger les données du DataGridView
                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Absence WHERE IDPERSONNEL = @idpersonnel", database.mySqlConnection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@idpersonnel", personnelId);
                dataAdapter.Fill(dataTable);
                listeAbsence.DataSource = dataTable;

                MessageBox.Show("Absence enregistrée avec succès !");


                this.Close(); // Fermer le formulaire d'ajout d'absence
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement de l'absence : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {
            // Fermer le formulaire AjouterAbsence
            this.Close();
        }
    }

}
