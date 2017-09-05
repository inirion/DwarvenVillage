using DwarvenVillage.Enums;
using System;

namespace DwarvenVillage.Utils.Randomizers
{
    class DwarfTypeRandomizer : IRandomizer, IDwarfTypeRandomizer
    {
        private int Father = 35;
        private int Single = 30;
        private int LazyBastard = 25;
        private Random _random = new Random();

        public int Roll()
        {
            return _random.Next(100);
        }

        public DwarfTypes GetRandomDwarf()
        {
            int value = Roll();
            DwarfTypes dwarf;

            if (value < Father)
            {
                dwarf = DwarfTypes.Father;
            }
            else if (value < Single + Father)
            {
                dwarf = DwarfTypes.Single;
            }
            else if (value < LazyBastard + Single + Father)
            {
                dwarf = DwarfTypes.LazyBastard;
            }
            else
            {
                dwarf = DwarfTypes.Kamikaze;
            }
            return dwarf;
        }
    }
}
