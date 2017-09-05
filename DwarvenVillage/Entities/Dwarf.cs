using DwarvenVillage.Enums;

namespace DwarvenVillage.Entities
{
    class Dwarf
    {
        private DwarfTypes _dwarfType;
        public Dwarf(DwarfTypes type)
        {
            DwarfType = type;
        }

        public DwarfTypes DwarfType { get => _dwarfType; set => _dwarfType = value; }

        public override string ToString()
        {
            return _dwarfType.ToString();
        }
    }
}
