using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Parviz","Alizada");
            Console.WriteLine("********* Student 1 *********");

            Console.WriteLine(student1.Name+" "+student1.SurName);

            Console.WriteLine("********* Student 2 *********");
            
            Student student2 = new Student("Vefa", "Farzaliyeva", 683, 87.5, true);

            Console.WriteLine(student2.Name + " " + student2.SurName + " "+student2.Group+" "+student2.Point+" "+student2.Gruated()+" "+student2.JoinExam());

        }
    }
}
