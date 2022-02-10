using System;

namespace GenericCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog<string, Car> cars = new Catalog<string, Car>();
            Car c1 = new Car("AB 12 345", 80000);
            Car c2 = new Car("CD 34 456", 65000);
            Car c3 = new Car("EF 56 567", 28000);
            cars.Insert(c1.LicensePlate, c1);
            cars.Insert(c2.LicensePlate, c2);
            cars.Insert(c3.LicensePlate, c3);
            cars.PrintAll();

            Catalog<string, Employee> employees = new Catalog<string, Employee>();
            Employee e1 = new Employee("Allan", 1962);
            Employee e2 = new Employee("Bente", 1975);
            Employee e3 = new Employee("Carlo", 1973);
            employees.Insert(c1.LicensePlate, e1);
            employees.Insert(c2.LicensePlate, e2);
            employees.Insert(c3.LicensePlate, e3);
            employees.PrintAll();

            Catalog<string, Computer> computers = new Catalog<string, Computer>();
            Computer pc1 = new Computer("1", "12");
            Computer pc2 = new Computer("12", "123");
            Computer pc3 = new Computer("123", "1234");
            computers.Insert(pc1.SerialNo, pc1);
            computers.Insert(pc2.SerialNo, pc2);
            computers.Insert(pc3.SerialNo, pc3);
            computers.PrintAll();

            Catalog<int, Student> students = new Catalog<int, Student>();
            Student s1 = new Student("a");
            Student s2 = new Student("b");
            Student s3 = new Student("c");
            students.Insert(s1.Id, s1);
            students.Insert(s2.Id, s2);
            students.Insert(s3.Id, s3);
            students.PrintAll();

            KeepConsoleWindowOpen();
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }
    }
}
