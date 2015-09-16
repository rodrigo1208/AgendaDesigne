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
using AgendaDesign.model;

namespace AgendaDesign.view
{
    public partial class InfoContato : Form
    {
        Form1 form1;
        public InfoContato(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        

        private void InfoContato_Load(object sender, EventArgs e)
        {
            ContatoDao contatoDao = new ContatoDao();
        }


        private void salvarBtn_Click(object sender, EventArgs e)
        {
            ContatoDao contatoDao = new ContatoDao();
            Contato contato = new Contato();
            contato.Id = contatoDao.retornaId();
            contato.Nome = nomeTbx.Text;
            contato.Telefone = telefoneTbx.Text;
            contato.Email = emailTbx.Text;
            contato.Nota = notaTbx.Text;
            contatoDao.salvarContato(contato);

            idTbx.Text = Convert.ToString(contatoDao.retornaId()); ;
            nomeTbx.Text = "";
            telefoneTbx.Text = "";
            emailTbx.Text = "";
            notaTbx.Text = "";

            this.Show();
            form1.atualizaGrid();

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
