using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            // um.MaleStudents();
            // um.FemaleStudents();
            //  um.SortStudentsByAge();
            //um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityCollection();

            Console.ReadKey();
        }



    }
}
