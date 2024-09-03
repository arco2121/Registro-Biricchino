using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroBiricchino
{
    public partial class Form5 : Form
    {
        private dynamic jo;
        public dynamic value;
        public Form5(dynamic json)
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
                    var studente = listaStudenti.FirstOrDefault(s => (int)s["matricola"] == Int32.Parse(textBox3.Text));

                    if (studente != null)
                    {
                        int[] votiArray = textBox1.Text.Split(',').Select(int.Parse).ToArray();

                        if (studente["voti"][textBox2.Text] != null && studente["voti"][textBox2.Text].HasValues)
                        {
                            foreach (var voto in votiArray)
                            {
                                ((JArray)studente["voti"][textBox2.Text]).Add(voto);
                            }
                        }
                        else
                        {
                            studente["voti"][textBox2.Text] = new JArray(votiArray);
                        }

                        value = jo;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Matricola non trovata");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (jo is JArray listaStudenti)
                {
                    var studente = listaStudenti.FirstOrDefault(s => (int)s["matricola"] == Int32.Parse(textBox3.Text));

                    if (studente != null)
                    {
                        int[] votiArray = textBox1.Text.Split(',').Select(int.Parse).ToArray();

                        studente["voti"][textBox2.Text] = new JArray(votiArray);

                        value = jo;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Matricola non trovata");
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
