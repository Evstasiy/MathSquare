using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSquare.Shapes {
    class AnotherShape : FundamentalShape {
        IShape shape;

        public AnotherShape(IShape shape) {
            this.shape = shape;
        }

        protected override double FindSquare() {
            throw new NotImplementedException();
        }
    }
}
