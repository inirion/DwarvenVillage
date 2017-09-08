using DwarvenVillage.Entities.Mine;
using System.Collections.Generic;

namespace DwarvenVillage.Entities
{
    class WorkingDwarf : IDwarfStrategy
    {
        public void Dig(Shaft shaft, List<IMaterial> materials, int uid)
        {
            shaft.WorkOnShaft(materials, uid);
        }
    }
}
