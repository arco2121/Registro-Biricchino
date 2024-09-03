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
    public partial class Form7 : Form
    {
        private dynamic jo;
        public string value;
        public Form7(dynamic json)
        {
            InitializeComponent();
            jo = json;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MatricolaEsiste(jo,textBox3.Text))
            {
                DialogResult = DialogResult.OK;
                value = textBox3.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Non esiste");
            }
        }

        private bool MatricolaEsiste(dynamic dynamicData, string matricola)
        {
            try
            {
                if (dynamicData is JArray listaStudenti)
                {
                    return listaStudenti.Any(studente => (int)studente["matricola"] == Int32.Parse(matricola));
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
