using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace Mosh_project_1.Advanced
{

    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }


    public class Book : Product
    {
        public string Isbn { get; set; }
    }

    public class Utilities<T> where T : IComparable, new()
    {
        // where T : IComparable
        // where T : type
        // where T : value tyoe struct
        // where T : class
        // where T : new()

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)// where T: IComparable // added above
        {
            //  return a > b ? a : b; doesnt know the type of T
            return a.CompareTo(b) > 0 ? a : b; // assume a Icompareable 
        }
    }

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    public class Nullable<T> where T : struct // T is value type can not null and here we give them ability to be null
    {
        private object _value; // to make null able value

        public Nullable() // default value 
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue        // if has value > true
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault() // numbre 5 >> 5 or return 0
        {
            if (HasValue)
                return (T)_value; // value is object here we un boxing it to T 

            return default(T); //find default value for this operator 
        }
    }


    class AD05
    {
        public static void Run()
        {
            var book = new Book() {Isbn = "1111", Title = "C#"};

            var num = new GenericList<int>();
            num.Add(10);
            var b1 = new GenericList<Book>();
            b1.Add(book);

            var dic = new GenericDictionary<string, Book>();
            dic.Add("1234" , new Book());

            var num2 = new Nullable<int>(5);
            Console.WriteLine("has value ? " + num2.HasValue);
            Console.WriteLine("value: " + num2.GetValueOrDefault());

            var num2 = new Nullable<int>();
            Console.WriteLine("has value ? " + num2.HasValue);
            Console.WriteLine("value: " + num2.GetValueOrDefault()); // it exist already in system.Nullable

            }

        }

    }
}
