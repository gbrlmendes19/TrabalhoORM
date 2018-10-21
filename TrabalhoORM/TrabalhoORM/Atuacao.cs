using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoORM
{
    public class Atuacao
    {
        public int Id { get; set; }
        public string papel { get; set; }
        public int idAtor { get; set; }
        public Ator ator { get; set; }
        public int idFilme { get; set; }
        public Filme filme { get; set; }
    }
}
