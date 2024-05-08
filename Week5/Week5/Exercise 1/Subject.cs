using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Subject
    {
        public string Name { get; set; }
        public float Grade { get; set; }
        
        public Subject (string name)
        {
            Name = name;
        }
    }
}
