using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09
{
    public class Quadrado : Area
    {
        public double Lado { get; set; }
        public override double AreaX =>  Math.Pow(this.Lado,2);
        //a setinha significa return
    }
}
