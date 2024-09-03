using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroBiricchino
{
    public partial class Form6 : Form
    {
        private string matricolaSelezionata;
        private dynamic json;
        public Form6(dynamic json,string m)
        {
            InitializeComponent();
            this.json = json;
            this.matricolaSelezionata = m;
            this.Uploaddata();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Uploaddata()
        {
            DataTable dataTable = ConvertDynamicToDataTable(this.json, matricolaSelezionata);
            this.dataGridView1.DataSource = dataTable;
        }

        private DataTable ConvertDynamicToDataTable(dynamic dynamicData, string matricola)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("Matricola");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Cognome");
            dataTable.Columns.Add("Data di Nascita");
            dataTable.Columns.Add("Luogo di Nascita");
            dataTable.Columns.Add("Classe");

            var studenti = (JArray)dynamicData;
            var studente = studenti
                .OfType<JObject>()
                .FirstOrDefault(s => (int)s["matricola"] == Int32.Parse(matricola));

            if (studente != null)
            {
                var voti = studente["voti"] as JObject;
                if (voti != null)
                {
                    foreach (var materia in voti.Properties())
                    {
                        dataTable.Columns.Add(materia.Name);
                    }
                }

                var row = dataTable.NewRow();
                row["Matricola"] = studente["matricola"];
                row["Nome"] = studente["nome"];
                row["Cognome"] = studente["cognome"];
                row["Data di Nascita"] = studente["data_nascita"];
                row["Luogo di Nascita"] = studente["luogo_nascita"];
                row["Classe"] = studente["classe"];

                if (voti != null)
                {
                    foreach (var materia in voti.Properties())
                    {
                        var materiaName = materia.Name;
                        var votiArray = materia.Value.ToObject<JArray>();
                        var votiString = string.Join(", ", votiArray);
                        row[materiaName] = votiString;
                    }
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

    }
}
