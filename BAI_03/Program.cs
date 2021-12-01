using BAI_03;
using System;
using System.Collections.Generic;
namespace Example1
{
    public class Program
    {
        static List<IPerson> person = null;
        static List<Student> students = null;
        static List<Teacher> teachers = null;
        static List<Employee> employees = null;

        public static void Output()
        {
            Console.WriteLine("List Student");
            Console.WriteLine(person.OfType<Student>().Count<Student>());            
            foreach(Student student in person.OfType<Student>())
            {
                student.GetInfo();
            }
            Console.WriteLine("====================================");
            Console.WriteLine("List Teacher");
            Console.WriteLine(person.OfType<Teacher>().Count<Teacher>());
            foreach(Teacher teacher in person.OfType<Teacher>())
            {
                teacher.GetInfo();
            }
            Console.WriteLine("====================================");
            Console.WriteLine("List Employee");
            Console.WriteLine(person.OfType<Employee>().Count<Employee>());
            foreach (Employee employee in person.OfType<Employee>())
            {
                employee.GetInfo();
            }
        }
        static void Main(string[] args)
        {
            person = new List<IPerson>();
            students = new List<Student>();

            students.Add(new Student(1, "Le Tuan Anh", 18, "A", "GTA"));
            students.Add(new Student(2, "Le Tuan Anh", 17, "A", "GTA"));
            students.Add(new Student(3, "Le Tuan Anh", 16, "A", "GTA"));
            students.Add(new Student(4, "Le Tuan Anh", 21, "A", "GTA"));
            students.Add(new Student(5, "Le Tuan Anh", 21, "A", "GTA"));
            students.Add(new Student(6, "Le Tuan Anh", 21, "A", "GTA"));

            foreach(Student student in students)
            {
                if (student.Equal())
                {
                    person.Add(student);
                }
            }

            teachers = new List<Teacher>();
            teachers.Add(new Teacher(1, "Nguyen Thi Thu", 18, 9000000, "GTA"));
            teachers.Add(new Teacher(2, "Nguyen Thi Thu", 18, 9000000, "GTA"));
            teachers.Add(new Teacher(3, "Nguyen Thi Thu", 22, 9000000, "GTA"));
            teachers.Add(new Teacher(4, "Nguyen Thi Thu", 27, 9000000, "GTA"));
            teachers.Add(new Teacher(5, "Nguyen Thi Thu", 18, 9000000, "GTA"));
            teachers.Add(new Teacher(6, "Nguyen Thi Thu", 30, 9000000, "GTA"));


            foreach(Teacher teacher in teachers)
            {
                if (teacher.Equal())
                {
                    person.Add(teacher);
                }
            }

            employees = new List<Employee>();
            employees.Add(new Employee(1, "Man Van Truong", 20, 10000000, "HAT", "Web"));
            employees.Add(new Employee(2, "Man Van Truong", 20, 10000000, "HAT", "Web"));
            employees.Add(new Employee(3, "Man Van Truong", 14, 10000000, "HAT", "Web"));
            employees.Add(new Employee(4, "Man Van Truong", 20, 20000000, "HAT", "Web"));
            employees.Add(new Employee(5, "Man Van Truong", 20, 40000000, "HAT", "Web"));
            employees.Add(new Employee(6, "Man Van Truong", 20, 10000000, "HAT", "Web"));
            foreach(Employee employee in employees)
            {
                if (employee.Equal())
                {
                    person.Add(employee);
                }
            }

            Output();

            Console.ReadKey();
        }
    }
}

