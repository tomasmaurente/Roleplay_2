using Interfaces;

namespace RoleplayGame
{
    public class Shield : IWeapons
    {
        public int GetAttackValue()
        {
            return 0;
        }

        public int defenseValue = 14;
        
        public int GetDefenseValue()
        {
            return defenseValue;
        }
    }
}