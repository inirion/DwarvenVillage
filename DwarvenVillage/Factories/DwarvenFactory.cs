using DwarvenVillage.Entities;
using DwarvenVillage.Utils.Randomizers;
using System.Collections.Generic;

namespace DwarvenVillage.Factories
{
    class DwarvenFactory
    {
        private static int uid = 0;
        public static List<Dwarf> Create10Dwarfs()
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            IDwarfTypeRandomizer rand = new DwarfTypeRandomizer();
            for (int i = 0; i < 10; i++)
            {
                dwarfs.Add(new Dwarf(rand.GetRandomDwarf(), uid++));
            }
            return dwarfs;
        }
    }
}
