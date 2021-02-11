using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldfishClub.Models
{
    public interface IGoldfishRepository
    {
        IEnumerable<Goldfish> AllGoldfish { get; }
        Goldfish GetGoldfishById(int goldfishId);
    }
}
