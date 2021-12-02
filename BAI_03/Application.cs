using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_03;
namespace App
{
    internal class Application
    {
       
        static List<Student> students = null;
        static List<Teacher> teachers = null;
        static List<Employee> employees = null;

        public static void Create()
        {
            
            students = new List<Student>();

            students.Add(new Student(1, "Le Tuan Anh", 18, "A", "GTA"));
            students.Add(new Student(2, "Le Tuan Anh", 17, "A", "GTA"));
            students.Add(new Student(3, "Le Tuan Anh", 16, "A", "GTA"));
            students.Add(new Student(4, "Le Tuan Anh", 21, "A", "GTA"));
            students.Add(new Student(5, "Le Tuan Anh", 21, "A", "GTA"));
            students.Add(new Student(6, "Le Tuan Anh", 21, "A", "GTA"));

            foreach (Student student in students)
            {
                if (student.Equal())
                {
                    TaxData.Init().persons.Add(student);
                }
            }

            teachers = new List<Teacher>();
            teachers.Add(new Teacher(1, "Nguyen Thi Thu", 18, 9000000, "GTA"));
            teachers.Add(new Teacher(2, "Nguyen Thi Thu", 18, 9000000, "GTA"));
            teachers.Add(new Teacher(3, "Nguyen Thi Thu", 22, 9000000, "GTA"));
            teachers.Add(new Teacher(4, "Nguyen Thi Thu", 27, 9000000, "GTA"));
            teachers.Add(new Teacher(5, "Nguyen Thi Thu", 18, 9000000, "GTA"));
            teachers.Add(new Teacher(6, "Nguyen Thi Thu", 30, 9000000, "GTA"));


            foreach (Teacher teacher in teachers)
            {
                if (teacher.Equal())
                {
                    TaxData.Init().persons.Add(teacher);
                }
            }

            employees = new List<Employee>();
            employees.Add(new Employee(1, "Man Van Truong", 20, 10000000, "HAT", "Web"));
            employees.Add(new Employee(2, "Man Van Truong", 20, 10000000, "HAT", "Web"));
            employees.Add(new Employee(3, "Man Van Truong", 14, 10000000, "HAT", "Web"));
            employees.Add(new Employee(4, "Man Van Truong", 20, 20000000, "HAT", "Web"));
            employees.Add(new Employee(5, "Man Van Truong", 20, 40000000, "HAT", "Web"));
            employees.Add(new Employee(6, "Man Van Truong", 20, 10000000, "HAT", "Web"));
            foreach (Employee employee in employees)
            {
                if (employee.Equal())
                {
                    TaxData.Init().persons.Add(employee);
                }
            }

        }
    }
}
