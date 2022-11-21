using Encapsulation.Model;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student
            {
                Name = Console.ReadLine(),
                Surname = Console.ReadLine(),
                AvgPoint = (Convert.ToSByte(Console.ReadLine()))
            };
            Group group = new Group
            {
                No = Console.ReadLine(),
                StudentLimit=Convert.ToSByte(Console.ReadLine()),
            };
            Console.WriteLine($"Name:{student.Name}\nSurname:{student.Surname}\nAvgPoint:{student.AvgPoint}\nNo:{group.No}\nStudentLimit:{group.StudentLimit}");
        }
    }
}