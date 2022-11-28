using Advent2022.Runner;
using Advent2022.Runner.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2022.Runner.Days
{
    public class Day1 : IAdventProblem
    {
        public void A()
        {
            var numbers = FileSystem.MakeDataFilePath("day1")
                                    .Read(line => Int32.Parse(line));  
        }

        public void B()
        {
           
        }
    }
}
