using DwarvenVillage.Entities.Mine;
using DwarvenVillage.Enums;

namespace DwarvenVillage.Entities
{
    class Dwarf
    {
        private DwarfTypes _dwarfType;
        private Inventory _inventory;
        private int _uid;
        private IDwarfStrategy _dwarfWorkingStrategy;
        

        public Dwarf(DwarfTypes type, int uid)
        {
            _inventory = new Inventory();
            _dwarfType = type;
            _uid = uid;
            if (type != DwarfTypes.Kamikaze)
                _dwarfWorkingStrategy = new WorkingDwarf();
            else
                _dwarfWorkingStrategy = new KamikazeDwarf();
        }

        public DwarfTypes DwarfType { get => _dwarfType; }
        public int Uid { get => _uid; }
        public Inventory Inventory { get => _inventory; }
        public IDwarfStrategy DwarfWorkingStrategy { get => _dwarfWorkingStrategy; }

        public void Dig(Shaft shaft)
        {
            _dwarfWorkingStrategy.Dig(shaft, _inventory.Materials, _uid);
        }

        public override string ToString()
        {
            return _dwarfType.ToString();
        }
    }
}
