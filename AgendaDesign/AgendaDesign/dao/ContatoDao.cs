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
            Stream entrar = File.Open(@"Arquivo\contatos.txt", FileMode.Open);
            StreamReader ler = new StreamReader(entrar);
            string[] linha = new string[100];
            int x = 0;
            while ((linha[x] = ler.ReadLine()) != null)
            {
                x++;
            }
            entrar.Close();
            ler.Close();
            //Abre o arquivo e salva cada linha em um array

            Stream sair = File.Open(@"Arquivo\" + contato.Nome + ".txt", FileMode.Create);
            StreamWriter salvar = new StreamWriter(sair);
            salvar.WriteLine(contato.Id);
            salvar.WriteLine(contato.Nome);
            salvar.WriteLine(contato.Telefone);
            salvar.WriteLine(contato.Email);
            salvar.WriteLine(contato.Nota);
            salvar.Close();
            sair.Close();
            //Cria um arquivo com o nome do contato e salva os dados

            sair = File.Open(@"Arquivo\contatos.txt", FileMode.Create);
            salvar = new StreamWriter(sair);
            linha[x] = contato.Nome;
            for (int i = 0; i <= x; i++)
            {
                salvar.WriteLine(linha[i]);
            }
            salvar.Close();
            sair.Close();
            //Salva o nome do contato em uma lista utilizando o array anterior
        }

    }
}
