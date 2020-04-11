using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("hehe",18);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("richman",30,696969,"github","Dosen@teacher.amikom.ac.id");
            teacher.GetNameAndAge();
            
            Student student = new Student("awan",18,2686,"bagus.17@student.amikom.ac.id");
            student.GetNameAndAge();
        }
    }
}
