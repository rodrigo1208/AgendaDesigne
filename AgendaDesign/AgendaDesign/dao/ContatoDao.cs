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

            Stream sair = File.Open(@"Arquivo\" + contato.Id + ".txt", FileMode.Create);
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
            linha[x] = Convert.ToString(contato.Id);
            for (int i = 0; i <= x; i++)
            {
                salvar.WriteLine(linha[i]);
            }
            salvar.Close();
            sair.Close();
            //Salva o nome do contato em uma lista utilizando o array anterior
        }

        public List<Contato> retornaContatos()
        {
            Stream entrar = File.Open(@"arquivo/contatos.txt", FileMode.Open);
            StreamReader ler = new StreamReader(entrar);
            List<Contato> contatos = new List<Contato>();
            string[] linha = new string[100];
            int x = 0;
            while((linha[x] = ler.ReadLine()) != null)
            {
                Stream entrarContato = File.Open(@"arquivo/" + linha[x] + ".txt", FileMode.Open);
                StreamReader lerContato = new StreamReader(entrarContato);
                Contato contato = new Contato();
                contato.Id = Int32.Parse(lerContato.ReadLine());
                contato.Nome = lerContato.ReadLine();
                contato.Telefone = lerContato.ReadLine();
                contato.Email = lerContato.ReadLine();
                contato.Nota = lerContato.ReadLine();
                x++;
                contatos.Add(contato);
                lerContato.Close();
                entrarContato.Close();
            }
            ler.Close();
            entrar.Close();
            return contatos;
        }

        public int retornaId()
        {
            Stream entrar = File.Open(@"arquivo/contatos.txt", FileMode.Open);
            StreamReader ler = new StreamReader(entrar);
            int x = 0;
            string[] linha = new string[100];
            while((linha[x] = ler.ReadLine()) != null)
            {
                x++;
            }
            ler.Close();
            entrar.Close();
            if(linha[x] == null)
            {
                return x + 1;
            }
            return Int32.Parse(linha[x]) + 1;
        }

        public Contato retornaContato(int id)
        {
            Stream abrir = File.Open(@"arquivo\" + id + ".txt", FileMode.Open);
            StreamReader ler = new StreamReader(abrir);

            Contato contato = new Contato();
            contato.Id = Int32.Parse(ler.ReadLine());
            contato.Nome = ler.ReadLine();
            contato.Telefone = ler.ReadLine();
            contato.Email = ler.ReadLine();
            contato.Nota = ler.ReadLine();
            return contato;
        }
    }
}
