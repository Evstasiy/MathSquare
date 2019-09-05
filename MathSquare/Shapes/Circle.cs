using System;

namespace MathSquare.Shapes {
    public class Circle : FundamentalShape {
        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Create circle
        /// </summary>
        /// <param name="radius">Double radius not be negetive</param>
        public Circle(double radius) {
            CheckNegetiveParameter(radius);
            Radius = radius;
        }

        protected override double FindSquare() {
            return Math.PI * (Radius * Radius);
        }
    }
}
