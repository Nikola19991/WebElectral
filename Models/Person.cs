using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebElectral.Models
{
    public enum PersonTypes { Customer, Staff }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PersonTypes Type { get; set; }
        public virtual Address Address { get; set; }
    }
}
