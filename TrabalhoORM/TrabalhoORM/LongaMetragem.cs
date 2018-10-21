using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoORM
{
    [Table("Longas")]
    public class LongaMetragem : Filme
    {
        public string categoria { get; set; }
    }
}
