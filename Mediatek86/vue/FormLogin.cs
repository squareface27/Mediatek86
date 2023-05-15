using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Mediatek86.vue
{

    /// <summary>
    /// FormLogin
    /// </summary>
    public partial class FormLogin : Form
    {
        /// <summary>
        /// FormLogin()
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                MessageBox.Show("Merci d'indiquer le nom d'utilisateur");
            }
            else if(textPassword.Text == "")
            {
                MessageBox.Show("Merci d'indiquer un mot de passe");
            }
            else
            {



                string password = textPassword.Text;

                try
                {
                    var database = new Database();
                    database.connect_db();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM responsable WHERE login = @username and pwd = @password");
                    cmd.Parameters.AddWithValue("@username", textUsername.Text);

                    string hashedPassword = hashPassword(textPassword.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    cmd.Connection = database.mySqlConnection;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                     adapter.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        string storedPassword = dt.Rows[0]["pwd"].ToString(); // récupère le hash du mot de passe stocké dans la base de données
                        if (hashedPassword == storedPassword)
                        {
                            this.Hide();
                            Main mainForm = new Main();
                            mainForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur ou le mot de passe est incorrect", "Échec de l'authentification");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                    }
                }

        private string hashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hash = BitConverter.ToString(bytes).Replace("-", "").ToLower();
                return hash;


            }


        }

        private void lblEspace_Click(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Empêcher le redimensionnement de la fenêtre
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Désactiver le bouton "Agrandir"
            this.MaximizeBox = false;
        }



    }
}
