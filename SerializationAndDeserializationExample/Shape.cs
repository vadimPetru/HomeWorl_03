namespace SerializationAndDeserializationExample
{   [Serializable]
    public  class Shape
    {
       
        public Point ShapePoint { get; set; }
        public float Length{ get; set; }
      
        public float Height { get; set; }
        public string Name { get; set; }

        public Shape(Point shapePoint , float length,float height , string name)
        {
            ShapePoint = shapePoint;
            Length = length;
            Height = height;
           Name = name;
        }
        public Shape()
        {

        }
       
        public override string ToString()
        {
         return $"ShapePoint.X:{this.ShapePoint.X}\n" +
                $"   ShapePoint.Y:{this.ShapePoint.Y}\n" +
                $"   Length:{this.Length}\n" +
                $"   Height:{this.Height}\n" +
                $"   Name:{this.Name}\n";
        }

    }
}
//Создать класс Shape со свойствами Point ShapePoint, float Length, float Height, string Name.