using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    class DesignPatternFactoryMethod
    {
        public abstract class Shape
        {

            public abstract string shapeName { get; set; }
            public abstract List<object> parts { get; set; }
        }



        public class Rectangle : Shape
        {

            public override string shapeName { get; set; } 
            public override List<object> parts { get; set; } 

            public Rectangle()
            {
                this.parts = new List<object>();
                this.shapeName = "Rectangle";
                int item1 = 1;
                string item2 = "part2";
                int item3 = 5;
                string item4 = "part4";

                parts.Add(item1);
                parts.Add(item2);
                parts.Add(item3);
                parts.Add(item4);
            }

        }




        public class Circle : Shape
        {

            public override string shapeName { get; set; }
            public override List<object> parts { get; set; }

            public Circle()
            {
                this.parts = new List<object>();
                this.shapeName = "Circle";
                int item1 = 55;
                string item2 = "part5";
                int item3 = 77;
                string item4 = "part6";

                parts.Add(item1);
                parts.Add(item2);
                parts.Add(item3);
                parts.Add(item4);
            }
        }




        public class ShapeFactory
        {
            private string ShapeType;
            private Shape _shape;


            public ShapeFactory(string type)
            {
                this.ShapeType = type;
                if (type == "Rectangle")
                {
                    _shape = new Rectangle();
                }
                else
                {
                    _shape = new Circle();
                }

            }

            public string GetParts()
            {
                string result = this.ShapeType + " : ";
                foreach (object a in _shape.parts)
                    result += a + ", ";
                return result;
            }

        }


        public class testFactoryDesign
        {

            public string test()
            {
                string result = "";
                ShapeFactory sp1 = new ShapeFactory("Rectangle");
                result += sp1.GetParts();
                ShapeFactory sp2 = new ShapeFactory("Circle");
                result += sp2.GetParts();
                return result;
            }
        }



    }
}
    

