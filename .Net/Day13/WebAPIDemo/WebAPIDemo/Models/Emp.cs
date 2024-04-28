using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Emp
    {
        public int Id { get; set; }
        public string? Ename { get; set; }
        public float? Salary { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
    }
}
