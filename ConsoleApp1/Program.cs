using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ques 1

            var employee = new Employees { EmpId = 1, FirstName = "Durg", LastName = "Singh" };
            foreach(var address in employee.EmployeeAddresses.Value)// Lazy Loading
            {
                Console.WriteLine(address.City);
            }
           // Ques 2

            Product product = new Product { Qty = 2, Rate = 5 };
            var serializeObject= JsonSerializer.Serialize(product);

            var oldProduct = JsonSerializer.Deserialize<Product>(serializeObject);

            // Ques 3
            string name = "durg vijay singh";
            var wordsCount = name.WordCount();

            Console.ReadKey();
        }

        
    }

}
