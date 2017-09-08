using DwarvenVillage.Entities.Materials;
using DwarvenVillage.Enums;
using DwarvenVillage.Utils.Loggers;
using DwarvenVillage.Utils.Randomizers;
using System.Collections.Generic;
using System.Linq;

namespace DwarvenVillage.Entities.Mine
{
    class Shaft
    {
        private List<Dwarf> _dwarfs;
        private bool _isDestoryed;
        private int _daysToRestore;

        public bool IsDestoryed { get => _isDestoryed; set => _isDestoryed = value; }

        public Shaft()
        {
            IsDestoryed = false;
            _daysToRestore = 0;
        }

        public void DestroyShaft()
        {
            Logger.WriteLog("Shaft has been destroyed, all dwarfs in this shaft died =(");
            IsDestoryed = true;
            _dwarfs.Clear();
            _daysToRestore = 3;
        }

        public void RebuildShaft()
        {
            
            if (_daysToRestore > 0)
            {
                Logger.WriteLog("Shaft has been destroyed, " + _daysToRestore + " days has been left till restoration of shaft.");
                --_daysToRestore;
            }
                
            if (_daysToRestore == 0)
            {
                Logger.WriteLog("Shaft has been rebuilded");
                IsDestoryed = false;
            }
                
        }

        public void GoDownTheShaft(List<Dwarf> dwarfs)
        {
            Logger.WriteLog("Dwarfs are going in to the shaft.");
            _dwarfs = dwarfs;
        }

        public List<Dwarf> GoOutOfShaft()
        {
            Logger.WriteLog("Dwarfs are going out of shaft");
            return _dwarfs;
        }

        public void StartWorking()
        {
            Logger.WriteLog("Dwarfs are starting working.");
            foreach (Dwarf dwarf in _dwarfs.ToList())
            {
                if (_dwarfs.Count == 0) break;
                dwarf.Dig(this);
            }
        }

        public void WorkOnShaft(List<IMaterial> materials, int uid)
        {
            if (!IsDestoryed)
            {
                Dwarf dwarf = _dwarfs.Where(x => x.Uid == uid).First();

                IMaterialTypeRandomizer rand = new MaterialTypeRandomizer();
                MaterialTypes diggedMaterialType = rand.GetRandomMaterial();
                IMaterial diggedMaterial = null;
                switch (diggedMaterialType)
                {
                    case MaterialTypes.DirtyGold:
                        diggedMaterial = new DirtyGold();
                        break;
                    case MaterialTypes.Silver:
                        diggedMaterial = new Silver();
                        break;
                    case MaterialTypes.Gold:
                        diggedMaterial = new Gold();
                        break;
                    case MaterialTypes.Mithril:
                        diggedMaterial = new Mithril();
                        break;
                    case MaterialTypes.Nothing: break;
                    default: break;
                }
                if(diggedMaterial != null)
                {
                    materials.Add(diggedMaterial);
                    Logger.WriteLog("Dwarf which uid: " + uid + "digged " + diggedMaterial.MaterialType.ToString());
                }
                else
                {
                    Logger.WriteLog("Dwarf which uid: " + uid + "digged nothing.");
                }

                
            }
        }
    }
}
