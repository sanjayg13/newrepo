using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWpfApp.Models
{
    public enum Category { Salaried, Contract, Temporory }
    public class EmployeeClass
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress1 { get; set; }
        public string EmpAddress2 { get; set; }
        public long EmpContact { get; set; }
        public string EmpEmail { get; set; }
        public string EmpImage { get; set; }
        public Category Category { get; set; }
    }

    public class EmployeeStatus
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
    public class EmployeeRepository
    {
        List<EmployeeClass> _empObjects = new List<EmployeeClass>();

        public EmployeeRepository()
        {
            _empObjects.Add(new EmployeeClass
            {
                EmpName = "santosh",
                EmpAddress1 = "Bangalore",
                EmpAddress2 = "kanpur",
                EmpID = 2,
                EmpEmail = "x.com",
                EmpImage = @"Images\Guess.jpg",
                Category = Category.Contract
            });
            _empObjects.Add(new EmployeeClass
            {
                EmpName = "sanjay",
                EmpAddress1 = "Bangalore",
                EmpAddress2 = "kanpur",
                EmpID = 1,
                EmpEmail = "x.com",
                EmpImage = @"Images\Guess.jpg",
                Category = Category.Salaried
            });
            _empObjects.Add(new EmployeeClass
            {
                EmpName = "jay",
                EmpAddress1 = "Bangalore",
                EmpAddress2 = "kanpur",
                EmpID = 3,
                EmpEmail = "x.com",
                EmpImage = @"Images\Guess.jpg",
                Category = Category.Temporory });
            _empObjects.Add(new EmployeeClass
            {
                EmpName = "sanjay",
                EmpAddress1 = "Bangalore",
                EmpAddress2 = "kanpur",
                EmpID = 1,
                EmpEmail = "x.com",
                EmpImage = @"Images\Guess.jpg",
                Category = Category.Temporory });
            _empObjects.Add(new EmployeeClass
            {
                EmpName = "sanjay",
                EmpAddress1 = "Bangalore",
                EmpAddress2 = "kanpur",
                EmpID = 1,
                EmpEmail = "x.com",
                EmpImage = @"Images\Gucci.jpg",
                Category = Category.Salaried });
            _empObjects.Add(new EmployeeClass
            {
                EmpName = "sanjay",
                EmpAddress1 = "Bangalore",
                EmpAddress2 = "kanpur",
                EmpID = 1,
                EmpEmail = "x.com",
                EmpImage = @"Images\Guess.jpg",
                Category = Category.Temporory });
            _empObjects.Add(new EmployeeClass
            {
                EmpName = "sanjay",
                EmpAddress1 = "Bangalore",
                EmpAddress2 = "kanpur",
                EmpID = 1,
                EmpEmail = "x.com",
                EmpImage = @"Images\Guess.jpg",
                Category = Category.Contract });
        }

        public List<EmployeeStatus> AllCategories
        {
            get
            {
                return fillCategories();
            }
        }

        private List<EmployeeStatus> fillCategories()
        {
            var all = new List<EmployeeStatus>();
            all.Add(new EmployeeStatus { Name = "All", Count = _empObjects.Count });
            Dictionary<string, int> contents = new Dictionary<string, int>();
            foreach (var emp in _empObjects)
            {
                if (contents.ContainsKey(emp.Category.ToString()))
                    contents[emp.Category.ToString()] += 1;
                else
                    contents[emp.Category.ToString()] = 1;
            }
            foreach (var pair in contents)
            {
                var cat = new EmployeeStatus
                {
                    Name = pair.Key,
                    Count = pair.Value
                };
                all.Add(cat);
            }
            return all;
        }

        public List<EmployeeClass> AllEmployees => _empObjects;

        //Add other CRUD operations along with XML Serialization...
    }
}