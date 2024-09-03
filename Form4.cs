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
    public partial class Form4 : Form
    {
        private dynamic jo;
        public dynamic value;
        public Form4(dynamic json)
        {
            InitializeComponent();
            jo = json;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (jo is JArray listaStudenti)
                {
                    var studenteDaRimuovere = listaStudenti.FirstOrDefault(studente =>
                        (int)studente["matricola"] == Int32.Parse(textBox3.Text));

                    if (studenteDaRimuovere != null)
                    {
                        listaStudenti.Remove(studenteDaRimuovere);
                        value = jo;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Studente non trovato.");
                    }
                }
                else
                {
                    MessageBox.Show("Errore: il formato del JSON non è corretto.");
                }
            }
            catch
            {

            }
        }
    }
}
