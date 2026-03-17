using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMaui.Model
{
    public class Macaco
    {
        public Macaco() { }

        [Key]
        private int id;
        private string nome;
        private string especie;
        private string doenca;
        private string imagem;
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Doenca { get => doenca; set => doenca = value; }
        public string Imagem { get => imagem; set => imagem = value; }
    }
}
