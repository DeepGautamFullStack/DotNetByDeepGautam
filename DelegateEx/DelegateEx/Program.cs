using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessors();
            var filter = new PhotoFilters();

            PhotoProcessors.PhotoFilterhandler filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyCOntrast;

            processor.Process("phoyo.jpg", filterHandler);

            string mainstr = "This is main string and its too loong willl discard few words if required";

            string discarded = mainstr.Discard(7);

            Console.WriteLine(discarded);


            //Create list of employee
            List<Employee> listEmp = new List<Employee>();
            listEmp.Add(new Employee {Id=1,Name="Deep",Salary=2000000 });
            listEmp.Add(new Employee { Id = 2, Name = "Gauta", Salary = 3000000 });
            listEmp.Add(new Employee { Id = 3, Name = "Anju", Salary = 2000000 });
            listEmp.Add(new Employee { Id = 4, Name = "Akkiu", Salary = 500 });
            listEmp.Add(new Employee { Id = 5, Name = "Uppu", Salary = 600 });


            var secondHighest = listEmp.OrderByDescending(x => x.Salary)
                .Skip(2)
                .FirstOrDefault();

            var seondwithgrp = listEmp.GroupBy(x => x.Salary)
                .OrderByDescending(x => x.Key)
                .Skip(2)
                .First();
                
                

            Console.WriteLine("Name is {0}, Salary is {1}", secondHighest.Name, secondHighest.Salary.ToString());
            Console.WriteLine("Salary is {0}", seondwithgrp.Key);



        }
    }
}
