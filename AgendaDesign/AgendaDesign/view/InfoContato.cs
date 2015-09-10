using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaDesign.dao;

namespace AgendaDesign.view
{
    public partial class InfoContato : Form
    {
        public InfoContato()
        {
            InitializeComponent();
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            ContatoDao contatoDao = new ContatoDao();
        }
    }
}
