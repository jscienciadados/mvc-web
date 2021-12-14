using E_Jogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace E_Jogos.Models
{
    public class Equipe : EJogosBase,IEquipe
    {
        private const string path = "Database/equipe.csv";
        // cto -> cria o constructor
        public Equipe()
        {

            CreateFolderAndFile(path);
        }
        public int IdEquipe { get; set; }
        public string Name { get; set; }
        public string imagem { get; set; }

        

        

        public void Create(Equipe nova_equipe)
        {
            string[] linha = { $"{nova_equipe.IdEquipe};{nova_equipe.Name};{nova_equipe.imagem}" };            
            File.AppendAllLines(path, linha); 
           
        }

        public void Delete(int IdEquipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(path);

            foreach (string item in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(item.Split(';')[0]);
                equipe.Name = item.Split(';')[1];
                equipe.imagem = item.Split(";")[2];
            }
            return equipes;
        }

        public void Update(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
