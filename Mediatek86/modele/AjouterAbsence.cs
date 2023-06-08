using System;
using System.Data;
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


        /// <summary>
        /// AjouterAbsence
        /// </summary>
        /// 

        // Ajout des motifs d'absence dans la comboBox
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



        // Clic sur le bouton pour enregistrer l'absence

        private void buttonValider_Click(object sender, EventArgs e)
        {
            
                
                DateTime dateDebut = dateTimePickerDebut.Value.Date;
                DateTime dateFin = dateTimePickerFin.Value.Date;
            MotifItem selectedMotif = (MotifItem)comboBoxMotif.SelectedItem;
            if (selectedMotif == null)
            {
                MessageBox.Show("Veuillez sélectionner un motif d'absence.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            int motifId = selectedMotif.Id;


            
            if (dateFin < dateDebut)
                {
                    MessageBox.Show("La date de fin doit être postérieure à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }


                
                var database = new Database();
                database.connect_db();


            MySqlCommand checkCommand = new MySqlCommand("SELECT COUNT(*) FROM Absence WHERE IDPERSONNEL = @idpersonnel AND DATEDEBUT = @datedebut AND DATEFIN = @datefin", database.mySqlConnection);
            checkCommand.Parameters.AddWithValue("@idpersonnel", personnelId);
            checkCommand.Parameters.AddWithValue("@datedebut", dateDebut);
            checkCommand.Parameters.AddWithValue("@datefin", dateFin);

            int existingAbsenceCount = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (existingAbsenceCount > 0)
            {
                MessageBox.Show("Une absence avec la même date de début et de fin pour ce personnel existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Quitter la méthode sans enregistrer l'absence
            }

            MySqlCommand cmd = new MySqlCommand("INSERT INTO Absence (IDPERSONNEL, DATEDEBUT, DATEFIN, IDMOTIF) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif)");
                cmd.Connection = database.mySqlConnection;
                cmd.Parameters.AddWithValue("@idpersonnel", personnelId); 
                cmd.Parameters.AddWithValue("@datedebut", dateDebut);
                cmd.Parameters.AddWithValue("@datefin", dateFin);
                cmd.Parameters.AddWithValue("@idmotif", motifId);
                cmd.ExecuteNonQuery();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Absence WHERE IDPERSONNEL = @idpersonnel", database.mySqlConnection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@idpersonnel", personnelId);
                dataAdapter.Fill(dataTable);
                listeAbsence.DataSource = dataTable;

                MessageBox.Show("Absence enregistrée avec succès !");


                this.Close(); 
            }

            

        // Clic sur le bouton annuler dans le formulaire d'ajout d'absence

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }

}
