using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AgendaDesign.model;

namespace AgendaDesign.dao
{
    class ContatoDao
    {
        public void salvarContato(Contato contato)
        {
            Stream conexao = File.Open(@"C:\Users\RodrigoFelipe\Documents\repositorios\GitHub\AgendaDesigne\arquivos\" + contato.Nome + ".txt", FileMode.Create);
            StreamWriter salvar = new StreamWriter(conexao);
            salvar.WriteLine(contato.Id);
            salvar.WriteLine(contato.Nome);
            salvar.WriteLine(contato.Telefone);
            salvar.WriteLine(contato.Email);
            salvar.WriteLine(contato.Nota);
        }

    }
}
