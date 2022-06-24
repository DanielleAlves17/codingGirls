using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09
{
    public class Losango : Area
    {
        public double DiagonalMaior { get; set; }
        public double DiagonalMenor { get; set; }

        public override double AreaX => (this.DiagonalMaior * this.DiagonalMenor)/2;
    }
}
