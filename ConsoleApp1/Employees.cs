using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace ConsoleApp1
{
    public class Employees
    {
        
        public int EmpId { get; set; }
        public int Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Lazy<IList<Address>> EmployeeAddresses => new Lazy<IList<Address>>(() => GetAddresses(this.EmpId));

        private IList<Address> GetAddresses(int empId)
        {
            return AllAddress().Where(x => x.EmpId == empId).ToList();
        }

        private List<Address> AllAddress()
        {
            return new List<Address>()
            {
                new Address
                {
                    EmpId=1,
                    State="Delhi",
                    Country="IN",
                    City="Delhi",
                    Zip="110096"
                },
                new Address
                {
                    EmpId=1,
                    State="Delhi",
                    Country="IN",
                    City="Delhi",
                    Zip="110095"
                },new Address
                {
                    EmpId=2,
                    State="UP",
                    Country="IN",
                    City="Auraiya",
                    Zip="200290"
                },new Address
                {
                    EmpId=2,
                    State="Bihar",
                    Country="IN",
                    City="Patna",
                    Zip="451452"
                }
                ,new Address
                {
                    EmpId=3,
                    State="Delhi",
                    Country="IN",
                    City="Delhi",
                    Zip="110096"
                },new Address
                {
                    EmpId=4,
                    State="Delhi",
                    Country="IN",
                    City="Delhi",
                    Zip="110096"
                }
            };
        }

    }
}
