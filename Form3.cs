using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace RegistroBiricchino
{
    public partial class Form3 : Form
    {
        private dynamic jo;
        public dynamic value;
        public Form3(dynamic json)
        {
            InitializeComponent();
            jo = json;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
        !string.IsNullOrWhiteSpace(textBox2.Text) &&
        !string.IsNullOrWhiteSpace(textBox3.Text) &&
        !string.IsNullOrWhiteSpace(textBox4.Text) &&
        !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                var nuovoStudente = new JObject
                {
                    ["matricola"] = Int32.Parse(textBox3.Text),
                    ["nome"] = textBox1.Text,
                    ["cognome"] = textBox2.Text,
                    ["data_nascita"] = dateTimePicker1.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                    ["luogo_nascita"] = textBox5.Text,
                    ["classe"] = textBox4.Text,
                    ["voti"] = new JObject()
                };

                if (jo is JArray listaStudenti)
                {
                    listaStudenti.Add(nuovoStudente);
                    value = jo;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Errore: il formato del JSON non è corretto.");
                }
            }
            else
            {
                MessageBox.Show("Per favore, riempi tutti i campi.");
            }
        }
    }
}
