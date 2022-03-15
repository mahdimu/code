using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    class DesignPatternBuilder
    {

        // the Builder interface specicifics methods for creating the different parts of the prodovt objects.
        public interface IBuilder
        {
            void BuildPartA();
            void BuildPartB();
            void BuildPartC();
        }

        public class ConcreteBuilder : IBuilder
        {

            private Product _product = new Product();

            public ConcreteBuilder()
            {
                this.Reset();
            }

            public void Reset()
            {
                this._product = new Product();
            }

            public void BuildPartA()
            {
                this._product.Add("partA");
            }


            public void BuildPartB()
            {
                this._product.Add("partB");
            }

            public void BuildPartC()
            {
                this._product.Add("partC");
            }


            public string GetProducts()
            {

                string result = this._product.ListParts();
                this.Reset();
                return result;
            }
        }


        // the director is onbly responsible for executing the building steps in a particular sequence.
        // it is helpful when producting products according to a specific order or configuration
        // the director class is optional

        public class Director
        {

            private IBuilder _builder;
            public IBuilder Builder { set { _builder = value; } }
            public void BuildMinimalVisibleProduct()
            {
                this._builder.BuildPartA();
            }

            public void BuildFullProduct()
            {
                this._builder.BuildPartA();
                this._builder.BuildPartB();
                this._builder.BuildPartC();
            }
        }



        public class Product
        {
            private List<object> _parts = new List<object>();

            public void Add(string part)
            {
                _parts.Add(part);
            }
            public string ListParts()
            {
                string str = string.Empty;
                for (int i = 0; i < _parts.Count - 1; i++)
                    str += _parts[i] + ", ";
                str += _parts[_parts.Count - 1];
                return "product Parts:" + str;
            }


        }




        public class testBuilder
        {
            
            public string test()
            {
            Director director = new Director();
            ConcreteBuilder builder = new ConcreteBuilder();
            director.Builder = builder;

                string result ="";
                


                result += "\n Standared Basic procucts:";
                director.BuildMinimalVisibleProduct();
                result += builder.GetProducts();

                result += "\n Standared full procucts:";
                director.BuildFullProduct();
                result += builder.GetProducts();

                result += "\n custome procucts:";
                builder.BuildPartA();
                builder.BuildPartC();
                result += builder.GetProducts();


                return result;
            }
            
         }



    }
}
