using System.Collections.Generic;

namespace DwarvenVillage.Entities
{
    class Inventory
    {
        private float _money;
        private bool _hasEaten;
        List<IMaterial> _materials;

        public Inventory()
        {
            Money = 0;
            HasEaten = false;
            Materials = new List<IMaterial>();
        }

        public bool HasEaten { get => _hasEaten; set => _hasEaten = value; }
        public List<IMaterial> Materials { get => _materials; set => _materials = value; }
        public float Money { get => _money; set => _money = value; }
    }
}
