using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTeorico
{
    public partial class PruebasEnCaliente : Form
    {
        client nuevoCliente = new client();
        public PruebasEnCaliente()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            nuevoCliente.mandarsendxdddd("hola viejon");
            txtBox.Text = nuevoCliente.getString();
        }
    }
}
