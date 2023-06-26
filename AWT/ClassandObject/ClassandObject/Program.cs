using System;

namespace ClassandObject
{
    public class Student
    {

        // Instance Variables
        String name;
        int rollNo;
        int std;
        String div;

        // Constructor Declaration of Class
        public Student(String name, int rollNo,
                      int std, String div)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.std = std;
            this.div = div;
        }

        // Property 1
        public String GetName()
        {
            return name;
        }

        // Property 2
        public int GetRollNo()
        {
            return rollNo;
        }

        // Property 3
        public int GetStd()
        {
            return std;
        }

        // Property 4
        public String GetDiv()
        {
            return div;
        }

        // Method 1
        public String ToString()
        {
            return ("Hi my name is " + this.GetName()
                    + ".\nMy Roll no is " + this.GetRollNo()
                    + ", \nI am in Standard " + this.GetStd() + ",And I am in " + this.GetDiv() + " Division.");
        }

        // Main Method
        public static void Main(String[] args)
        {

            // Creating object
            Student rupesh = new Student("Rupesh", 22095, 5, "B");
            Console.WriteLine(rupesh.ToString());
        }
    }
}
