using DwarvenVillage.Entities.Mine;
using System.Collections.Generic;

namespace DwarvenVillage.Entities
{
    interface IDwarfStrategy
    {
        void Dig(Shaft shaft, List<IMaterial> materials, int uid);
    }
}
