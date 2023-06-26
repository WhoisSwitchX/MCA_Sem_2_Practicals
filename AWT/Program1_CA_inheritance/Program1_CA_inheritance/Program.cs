using System;

namespace Program1_CA_inheritance
{
    class Department
    {
        public string dname;
        public string location;
        public Department(string dname,string location)
        {
            dname = this.dname;
            location = this.location;

        }
        public void display()
        {
            Console.WriteLine("Name of the Department: " + dname);
            Console.WriteLine("Location of the Department: " + location);
        }

    }
    class Employee:Department
    {


        public string eid;
        public Employee(string eid)
        {
            eid = this.eid;
        }
        public void display()
        {
            base.display();
            Console.WriteLine("Id: " + eid);
        }

    }


     class Program 
    {
        
        static void Main(string[] args)
        {
            Department d = new Department("Sales", "Mumbai");
            d.display();
            Employee e = new Employee("101");
            e.display();
            

            
        }
    }
}
