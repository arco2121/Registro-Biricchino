using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RegistroBiricchino
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Carica_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "File JSON (*.json)|*.json";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        string json = File.ReadAllText(filePath);
                        dynamic dati = JsonConvert.DeserializeObject<dynamic>(json);
                        Visu visu = new Visu(json,filePath);
                        visu.Show();
                        this.Hide();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Errore");
            }
        }

        private void Crea_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            Visualizzazione gh = new Visualizzazione("", Path.Combine(downloadPath, "Classe" + r.Next() + ".json"));
            gh.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
