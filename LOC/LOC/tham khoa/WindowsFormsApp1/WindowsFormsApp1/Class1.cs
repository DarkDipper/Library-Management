using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
        [Serializable]
        public class Ptb2
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }
            private double Delta
            {
                get
                {
                    return B * B - 4 * A * C;
                }
            }
            public String Giai()
            {
                if (Delta < 0)
                {
                    return "Vô nghiệm !";
                }
                if (Delta == 0)
                {
                    return String.Format("Nghiệm kép xo = {0}", (-B / (2 * A)));
                }
                double x1 = (-B + Math.Sqrt(Delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(Delta)) / (2 * A);
                return String.Format("2 nghiệm phân biệt: x1={0}, x2={1}", x1, x2);
            }
        }
}
