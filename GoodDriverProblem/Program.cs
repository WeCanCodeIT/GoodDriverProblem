using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodDriverProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader record = new StreamReader("DrivingRecord.txt");
            Console.WriteLine(record.ReadToEnd());

        }
    }
}
