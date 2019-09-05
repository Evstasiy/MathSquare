using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSquare.Shapes {
    //Пример создания новой фигуры
    public class Rectangle : FundamentalShape {
        double a, b, c, d;
        public Rectangle(double a, double b, double c, double d) {
            CheckNegetiveParameter(new double[] { a, b, c, d });
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        protected override double FindSquare() {
            return a * b * c * d;
        }
    }
}
