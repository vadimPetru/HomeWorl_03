using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserializationExample
{   [Serializable]
    public  class Shape
    {
        private Point _shapePoint;
        private float _length;
        private float _height;
        private string _name;

        public Shape(Point shapePoint , float length,float height , string name)
        {
            _shapePoint = shapePoint;
            _length = length;
            _height = height;
            _name = name;
        }
        public Shape()
        {

        }
        public Point ShapePoint { 
            get => _shapePoint;
            set => _shapePoint = value; 
        }

        public float Length
        {
            get => _length;
            set => _length = value;
        }

        public float Height
        {
            get => _height;
            set => _height = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

    }
}
//Создать класс Shape со свойствами Point ShapePoint, float Length, float Height, string Name.