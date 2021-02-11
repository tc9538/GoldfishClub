using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldfishClub.Models
{
    public class Goldfish
    {
        public const double AmoniaNumber= 0;
        public const double NitriteNumber = 0;

        public const double NitrateLowEndNum = 0;
        public const double NitrateHighEndNum = 50;

        public const double PHLowEndNum = 7.2;
        public const double PHHighEndNum = 7.6;

        public int GoldfishId { get; set; }
        public string Name { get; }
        public string Color { get; }
        public string CountryOfOrigin { get;}

        public List<string> food = new List<string> { "spinach", "egg", "cucumber", "broccoli", "pea"};
        public int TankSize { get; }
        public int Temperature { get; }

        public double AmoniaLevel { get; }
        public double NitrateLevel { get; }
        public double NitriteLevel { get; }

        public double PHLevel { get; }

        
        
        


        
    }
}
