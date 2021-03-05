using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(int id, string name, int age,int phone)
        {
            Id = id;
            Name = name;
            Age = age;
            Phone = phone;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
    }
}