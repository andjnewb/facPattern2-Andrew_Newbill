using System;
using System.Collections.Generic;
using System.Text;

namespace facPattern2_Andrew_Newbill_
{
    class ShapeFactory
    {

        public IGeometricShape getShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.CIRCLE:
                    return new Circle();
                    break;

                case ShapeType.LINE:
                    return new Line();
                    break;
                case ShapeType.RECTANGLE:
                    return new Rectangle();
                    break;

                default:
                    return null;


            }
        }


    }
}
