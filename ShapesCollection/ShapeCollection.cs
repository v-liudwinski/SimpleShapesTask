using System;
using System.Collections.Generic;
using System.Linq;
using OOPShapesTask.Interface;

namespace OOPShapesTask.ShapesCollection
{
    public class ShapeCollection
    {
        private readonly List<IShape> _shapeList;

        public ShapeCollection()
        {
            _shapeList = new List<IShape>();
        }

        public void AddShape(IShape shape)
        {
            _shapeList.Add(shape);
        }

        public void RemoveShape(IShape shape)
        {
            _shapeList.Remove(shape);
        }

        public void ShowAllShapes()
        {
            foreach (var shape in _shapeList)
            {
                Console.WriteLine(shape.ToString());
            }
        }

        public double GetBiggestSquare() => _shapeList.Max(shape => shape.GetSquare());
    }
}