using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Program
    {
        int id, age;
        string name, email, gender;
        public Program()
        {
            Console.WriteLine("enter id: ");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            this.email = Console.ReadLine();
            Console.WriteLine("Enter Gender : ");
            this.gender = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            this.age = int.Parse(Console.ReadLine());
        }
        public Program(Program program)
        {
            this.id = program.id;
            this.name = program.name;
            this.email = program.email;
            this.gender = program.gender;
            this.age = program.age;
        }
        public void display()
        {
            Console.WriteLine("Id is: " + id + "\nName is: " + "\nEmail : " + email + "\nGender: " + gender + "\nAge: " + age);
        } }
    public class Test { 
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.display();

            Program ob1 = new Program(ob);
            ob1.display();
            Console.ReadLine();


        }
    }
}
