using System;

namespace MathSquare.Shapes {
    public class Triangle : FundamentalShape {

        double a,b,c;

        /// <summary>
        /// True if triangle is rectangular
        /// </summary>
        public bool isRectangular { get; }

        /// <summary>
        /// Create triangle
        /// </summary>
        /// <param name="a">Double A not be negetive</param>
        /// <param name="b">Double B not be negetive</param>
        /// <param name="c">Double C not be negetive</param>
        public Triangle(double a, double b, double c) {
            CheckNegetiveParameter(new double[] { a, b, c });
            this.a = a;
            this.b = b;
            this.c = c;
            isRectangular = isRectangularTriangle();
        }

        protected override double FindSquare() {
            return a + b + c;
        }

        protected bool isRectangularTriangle() {
            return (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2)) || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)) 
                || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }

    }
}
