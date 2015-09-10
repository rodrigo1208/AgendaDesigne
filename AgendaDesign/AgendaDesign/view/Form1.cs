using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaDesign.view;

namespace AgendaDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            InfoContato infoContato = new InfoContato();
            infoContato.ShowDialog();
        }


    }
}
