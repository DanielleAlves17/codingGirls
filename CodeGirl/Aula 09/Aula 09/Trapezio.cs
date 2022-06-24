using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09
{
    public class Trapezio : Area
    {
        public double BsMaior { get; set; }
        public double BsMenor { get; set; }
        public double Altura { get; set; }
        public override double AreaX => ((this.BsMaior + this.BsMenor) * this.Altura)/2;
    }
}
