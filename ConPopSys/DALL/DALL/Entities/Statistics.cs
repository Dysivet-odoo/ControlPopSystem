using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Entities
{
    internal class Statistics
    {
        public int IdStatistic { get; set; }
        public int CountPopulation { get; set; }
        public int Year { get; set; }
        public float AverageAges { get; set; }
        public Locality LocalitySt { get; set; }

    }
}
