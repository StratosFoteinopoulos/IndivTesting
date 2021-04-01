using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivTesting
{
    enum TrainerNames
    {
        Aristeidis, Diamantis, Orfeas, Orestis, Andronikos, Aristotelis, Iasonas

    }
    enum TrainerLastNames
    {
        Xaritos, Panagiotopoulos, Papapostolis, Andeadis, Aristomenis, Xaralampous
    }
    class Trainer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string subject { get; set; }

        public override string ToString()
        {
            return this.firstName + " " + lastName;


        }
    }

}
