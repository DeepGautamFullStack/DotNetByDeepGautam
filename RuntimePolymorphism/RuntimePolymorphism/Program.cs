using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is runtime polymorphism
            Employee obj1 = new PermanentEmployee();
            Employee obj2 = new ContractEmployee();
            Employee obj3 = new OutsourcedEmployee();
            Console.WriteLine(obj1.PrintIdCard(10,"Deep"));
            Console.WriteLine(obj1.PrintIdCard(20, "Atul"));
            Console.WriteLine(obj1.PrintIdCard(30, "Rajnish"));
            //Runtime poly ends.

           // PermanentEmployee obj = new Employee();//This is not valid
            //means from child to parent can not be initilaized.BUt as you can see in above case 
            //from parent to child can be initilzed easly.

            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string PrintIdCard(int id,string name)
        {
            return "Employee Id-" + id + "Name-" + name;
        }
    }
    public class PermanentEmployee:Employee
    {
        public override string PrintIdCard(int id, string name)
        {
            return "You are a permanent Employee and your Id-" + id + " and Name-" + name;
        }
    }
    public class ContractEmployee : Employee
    {
        public override string PrintIdCard(int id, string name)
        {
            return "You are a contract Employee and your Id-" + id + " and Name-" + name;
        }
    }

    public class OutsourcedEmployee : Employee
    {
        public override string PrintIdCard(int id, string name)
        {
            return "You are a Out sourced Employee and your Id-" + id + " and Name-" + name;
        }
    }

}
