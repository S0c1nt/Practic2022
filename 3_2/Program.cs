using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    struct MyStruct
    {
        public string Change { get; set; }
    }

    class MyClass
    {
        public string Change { get; set; }
    }

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "Изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Change = "Изменено";
        }
        static void Main(string[] args)
        {
            MyStruct str = new MyStruct();
            MyClass cl = new MyClass();
            str.Change = "Не изменено";
            cl.Change = "Не изменено";
            StruktTaker(str);
            ClassTaker(cl);
            Console.WriteLine(str.Change);
            Console.WriteLine(cl.Change);

            Console.ReadKey();
        }
    }
}
