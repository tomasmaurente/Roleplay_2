using Interfaces;

namespace RoleplayGame
{
    public class Staff : IWeapons
    {
        private int attackValue = 100;
        
        public int GetAttackValue()
        {
            return attackValue;
        }

        private int defenseValue = 100;
        
        public int GetDefenseValue()
        {
            return defenseValue;
        }
    }
}