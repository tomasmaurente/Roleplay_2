using Interfaces;

namespace RoleplayGame
{
    public class Spell : IWeapons
    {
        private int attackValue = 70;
        public int GetAttackValue()
        {
            return attackValue;
        }
        
        private int defenseValue = 70;
        public int GetDefenseValue()
        {
            return defenseValue;
        }
    }
}