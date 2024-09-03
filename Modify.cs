using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace RegistroBiricchino
{
    public partial class Visualizzazione : Form
    {
        private string path;
        private dynamic json;
        public Visualizzazione(string file, string path)
        {
            if(file == "")
            {
                JArray enti = new JArray();
                this.json = enti;
            }
            else
            {
                this.json = JsonConvert.DeserializeObject<dynamic>(file);
            }
            this.path = path;
            InitializeComponent();
            this.Uploaddata();
        }

        private void Uploaddata()
        {
            DataTable dataTable = ConvertDynamicToDataTable(this.json);
            this.dataGridView1.DataSource = dataTable;
        }

        private DataTable ConvertDynamicToDataTable(dynamic dynamicData)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("Matricola");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Cognome");
            dataTable.Columns.Add("Data di Nascita");
            dataTable.Columns.Add("Luogo di Nascita");
            dataTable.Columns.Add("Classe");
            var firstItem = dynamicData.First;
            if (firstItem != null && firstItem.voti != null)
            {
                var votiMaterie = firstItem.voti;
                foreach (var materia in votiMaterie)
                {
                    dataTable.Columns.Add(materia.Name.ToString());
                }
            }

            foreach (var item in dynamicData)
            {
                var row = dataTable.NewRow();
                row["Matricola"] = item.matricola;
                row["Nome"] = item.nome;
                row["Cognome"] = item.cognome;
                row["Data di Nascita"] = item.data_nascita;
                row["Luogo di Nascita"] = item.luogo_nascita;
                row["Classe"] = item.classe;

                if (item.voti != null)
                {
                    var votiMaterie = item.voti;
                    foreach (var materia in votiMaterie)
                    {
                        var materiaName = materia.Name.ToString();
                        var voti = string.Join(", ", materia.Value);
                        row[materiaName] = voti;
                    }
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void ConfiguraDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Matricola",
                HeaderText = "Matricola"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cognome",
                HeaderText = "Cognome"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data di Nascita",
                HeaderText = "Data di Nascita"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Luogo di Nascita",
                HeaderText = "Luogo di Nascita"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Classe",
                HeaderText = "Classe"
            });

            var dataTable = (DataTable)dataGridView1.DataSource;
            var votiColonne = dataTable.Columns.Cast<DataColumn>()
                .Where(c => !new[] { "Matricola", "Nome", "Cognome", "Data di Nascita", "Luogo di Nascita", "Classe" }.Contains(c.ColumnName))
                .ToList();

            foreach (var col in votiColonne)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = col.ColumnName,
                    HeaderText = col.ColumnName
                });
            }
        }

        private void Visualizzazione_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string jsona = JsonConvert.SerializeObject(this.json, Formatting.Indented);
            File.WriteAllText(this.path, jsona);
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(Form3 f = new Form3(json))
            {
                f.ShowDialog();
                if(f.DialogResult == DialogResult.OK)
                {
                    this.json = f.value;
                    this.Uploaddata();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form4 f = new Form4(json))
            {
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    this.json = f.value;
                    this.Uploaddata();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form5 f = new Form5(json))
            {
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    this.json = f.value;
                    this.Uploaddata();
                }
            }
        }
    }
}
