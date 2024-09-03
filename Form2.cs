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

namespace RegistroBiricchino
{
    public partial class Visu : Form
    {
        private string Stringa;
        private string path;
        public Visu(string h,string j)
        {
            this.Stringa = h;
            this.path = j;
            InitializeComponent();
        }

        private void Prof_Click(object sender, EventArgs e)
        {
            Visualizzazione viu = new Visualizzazione(this.Stringa,this.path);
            viu.Show();
            this.Hide();
        }

        private void Visu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Studente_Click(object sender, EventArgs e)
        {
            var tie = JsonConvert.DeserializeObject<dynamic>(Stringa);
            using (Form7 h = new Form7(tie))
            {
                h.ShowDialog();
                if(h.DialogResult == DialogResult.OK)
                {
                    Form6 hj = new Form6(tie,h.value);
                    hj.Show();
                    this.Hide();
                }
            }
        }
    }
}
