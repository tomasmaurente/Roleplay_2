using Interfaces;

namespace RoleplayGame
{
    public class Helmet : IWeapons
    {
        public int GetAttackValue()
        {
            return 0;
        }

        public int defenseValue = 18;
        
        public int GetDefenseValue()
        {
            return defenseValue;
        }
    }
}