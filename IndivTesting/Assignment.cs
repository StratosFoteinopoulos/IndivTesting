using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivTesting
{


    class Assignment
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime subDateTime { get; set; }
        public int oralMark { get; set; }
        public int totalMark { get; set; }

        public override string ToString()
        {
            return this.title + " with Sub Date" + subDateTime;


        }
    }
}
