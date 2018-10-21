using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoORM
{
    class Program
    {
        static void Main(string[] args)
        {
            EstudioContext context = new EstudioContext();

            Adiciona(context);
            Remove(context);
            Edita(context);
            Lista(context);

            Console.ReadKey();
        }

        private static void Lista(EstudioContext context)
        {
            IList<Ator> lista = context.Atores.ToList();
            context.SaveChanges();
        }

        private static void Edita(EstudioContext context)
        {
            Ator ator = new Ator();
            context.Atores.Update(ator);
            context.SaveChanges();
        }

        private static void Remove(EstudioContext context)
        {
            Ator ator = new Ator();
            context.Atores.Remove(ator);
            context.SaveChanges();
        }

        private static void Adiciona(EstudioContext context)
        {
            Ator ator = new Ator();
            context.Atores.Add(ator);
            context.SaveChanges();
        }
    }
}
