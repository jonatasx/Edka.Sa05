using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa05
{
    internal class Disciplina
    {
        public string Descricao { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Termino { get; set; }

        //Polimorfismo
        //Override
        //Método no pai que é sobrescrito pelo filho

        public override string ToString() =>
             $"{Descricao,-10}- - - - - - - - {Inicio:dd/MM/yyyy} - - - - - - - -{Termino:dd/MM/yyyy)}";
    }
}
