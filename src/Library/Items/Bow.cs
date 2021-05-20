using Interfaces;

namespace RoleplayGame 
{
    public class Bow : IWeapons
    {
        private int attackValue = 30;

        public int GetAttackValue()
        {
            return attackValue;
        }

        public int GetDefenseValue()
        {
            return 0;
        }
    }
}