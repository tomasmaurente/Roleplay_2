using Interfaces;

namespace RoleplayGame
{
    public class Armor : IWeapons
    {
        public int GetAttackValue()
        {
            return 0;
        }

        private int defenseValue = 25;
        public int GetDefenseValue()
        {
            return defenseValue;
        }
    }
}