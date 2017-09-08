using DwarvenVillage.Enums;
using System;

namespace DwarvenVillage.Utils.Randomizers
{
    class MaterialTypeRandomizer : IRandomizer, IMaterialTypeRandomizer
    {
        private int DirtyGold = 20;
        private int Silver = 15;
        private int Gold = 10;
        private int Mithril = 5;
        private static Random _random = new Random();

        public MaterialTypes GetRandomMaterial()
        {
            int value = Roll();
            MaterialTypes material;

            if (value < DirtyGold)
            {
                material = MaterialTypes.DirtyGold;
            }
            else if (value < DirtyGold + Silver)
            {
                material = MaterialTypes.Silver;
            }
            else if (value < DirtyGold + Silver + Gold)
            {
                material = MaterialTypes.Gold;
            }
            else if (value < DirtyGold + Silver + Gold + Mithril) 
            {
                material = MaterialTypes.Mithril;
            }
            else
            {
                material = MaterialTypes.Nothing;
            }

            return material;
        }

        public int Roll()
        {
            return _random.Next(100);
        }
    }
}
