using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebElectral.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public double Salary { get; set; }
        public virtual Address Address { get; set; }
    }
}
