using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoORM
{
    [Table("Documentarios")]
    public class Documentario : Filme
    {
        public string assunto { get; set; }
    }
}
