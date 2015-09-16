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
using AgendaDesign.model;
using AgendaDesign.dao;

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
            InfoContato infoContato = new InfoContato(this);
            infoContato.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        //Metodo que atualiza as informações da grid
        public void atualizaGrid()
        {
            this.contatosDgv.Rows.Clear();
            ContatoDao contatoDao = new ContatoDao();
            foreach (Contato contato in contatoDao.retornaContatos())
            {
                int index = contatosDgv.Rows.Add();
                DataGridViewRow linha = contatosDgv.Rows[index];
                linha.Cells["id"].Value = contato.Id;
                linha.Cells["nome"].Value = contato.Nome;
                linha.Cells["telefone"].Value = contato.Telefone;
            }
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            int quantGrid = contatosDgv.GetCellCount(DataGridViewElementStates.Selected);
            int selectGrid = contatosDgv.CurrentRow.Index;
            if (quantGrid == 3)
            {
                ContatoDao contatoDao = new ContatoDao();
                InfoContato infoContato = new InfoContato();
                infoContato.Show(contatoDao.retornaContato(selectGrid));
            }
            else if(selectGrid > 3)
            {
                MessageBox.Show("Você selecionou mais de uma linha");
            }


        }


    }
}
