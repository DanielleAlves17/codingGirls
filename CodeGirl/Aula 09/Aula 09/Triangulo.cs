using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09
{
    public class Triangulo : Area
    {
        public double Bs { get; set; }
        public double Altura { get; set; }
        public override double AreaX => (this.Bs * this.Altura)/2;
    }
}
