using OOPShapesTask.Entity;
using OOPShapesTask.ShapesCollection;

namespace Shapes
{
    class ShapesTest
    {
        static void Main()
        {
            var shapesList = new ShapeCollection();
            
            var square = new Square(5);
            shapesList.AddShape(square);

            var rectangle = new Rectangle(10, 5);
            shapesList.AddShape(rectangle);

            var circle = new Circle(7);
            shapesList.AddShape(circle);

            var triangle = new Triangle(3, 4, 5);
            shapesList.AddShape(triangle);
            
            shapesList.ShowAllShapes();
        }
    }
}