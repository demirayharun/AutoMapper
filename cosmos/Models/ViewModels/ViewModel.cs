using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cosmos.Models
{
    public class ViewModel
    {
        public IEnumerable<Products> products { get; set; }
        public IEnumerable<Orders> orders { get; set; }
    }
}