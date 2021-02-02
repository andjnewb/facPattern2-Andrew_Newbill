using System;

namespace facPattern2_Andrew_Newbill_
{
    public enum ShapeType 
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE,
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory newFactory = new ShapeFactory();

            foreach (ShapeType shapeType in (ShapeType[])Enum.GetValues(typeof(ShapeType)))
            {

                if (newFactory.getShape(shapeType) != null)
                {
                    IGeometricShape shape = newFactory.getShape(shapeType);
                    shape.draw();
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("Drawing function for ");
                    Console.Write(shapeType.ToString());
                    Console.Write(" has not been implemented.");
                }

            }


            Console.ReadLine();

        }
    }
}
