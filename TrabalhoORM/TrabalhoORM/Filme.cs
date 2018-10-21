using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoORM
{
    public class Filme
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public double verba { get; set; }
        public DateTime dtGravacaoInicio { get; set; }
        public DateTime dtGravacaoFinal { get; set; }
        public int idAtorRoteirista { get; set; }
        public Ator ator { get; set; }
    }
}
