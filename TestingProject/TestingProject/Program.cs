using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    class Program
    {
        static void Main(string[] args)
        {


            CustomList<string> testList = new CustomList<string>();
            string expected = "Trombone";
            testList.Add("Tro");
            testList.Add("mbo");
            testList.Add("ne");
            string actual = testList.ToString();
            Console.ReadKey();



        }
    }
}
