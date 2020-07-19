using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test1.Models;

namespace Test1.ViewModel
{
    public class RandomViewModel
    {
        public Movie Movie { get; set; }
        //public List<Customer> customers { get; set; }
        public List<Customer> Customer { get; internal set; }
    }
}