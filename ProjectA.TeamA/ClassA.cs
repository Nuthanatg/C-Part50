using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.TeamA
//part-50
    //namespace AssemblyOne
{
    //public class ClassA
    //part-50
    public class AssemblyOneClass1
    {
        //public static void Print()
        //{
        //    Console.WriteLine("Team A Print Method");
        //    Console.ReadLine();
        //}

        //part-50
        //internal int ID = 101;
        protected internal int ID = 101;
    }
    public class AssemblyOneClass2
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            Console.WriteLine(A1.ID);
        }
    }
}
