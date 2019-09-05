using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSquare.Shapes {
    public abstract class FundamentalShape : IShape {

        double dinamicSquare;
        public double Square;

        public double GetSquare() {
            return FindSquare();
        }
        /// <summary>
        /// Calculate shape square
        /// </summary>
        /// <returns></returns>
        protected abstract double FindSquare();

        protected void CheckNegetiveParameter(double[] parameters) {
            foreach (double i in parameters) {
                CheckNegetiveParameter(i);
            }
        }
        protected void CheckNegetiveParameter(double parameter) {
            if (parameter < 0)
                throw new ArgumentOutOfRangeException("Parameter cannot be negetive");
        }
    }
}
