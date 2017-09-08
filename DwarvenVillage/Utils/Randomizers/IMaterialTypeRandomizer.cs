using DwarvenVillage.Enums;

namespace DwarvenVillage.Utils.Randomizers
{
    public interface IMaterialTypeRandomizer
    {
        MaterialTypes GetRandomMaterial();
    }
}
