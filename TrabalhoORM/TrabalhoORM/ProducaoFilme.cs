using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoORM
{
    public class ProducaoFilme
    {
        public int Id { get; set; }
        public int idFilme { get; set; }
        public Filme filme { get; set; }
        public int idProdutor { get; set; }
        public Produtor produtor { get; set; }
    }
}
