using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09
{
    public class Circulo : Area
    {
        public double Raio { get; set; }
        public const double pi = 3.14d;
        public override double AreaX => Math.Pow(this.Raio,2) * pi;
    }
}
