using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoORM
{
    public class DirecaoFilme
    {
        public int Id { get; set; }
        public int idFilme { get; set; }
        public Filme filme { get; set; }
        public int idDiretor { get; set; }
        public Diretor diretor { get; set; }
    }
}
