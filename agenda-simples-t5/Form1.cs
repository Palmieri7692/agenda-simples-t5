using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_simples_t5
{
    public partial class txtSobrenome : Form
    {
        public txtSobrenome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonbntAddContato_Click(object sender, EventArgs e)
        {
            Contato objetoContato = new Contato();
            LstContatos.Items. Add(objetoContato.ToString());
        }
    }
}
