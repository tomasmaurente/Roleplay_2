using Interfaces;

namespace RoleplayGame
{
    public class Axe : IWeapons
    {
        private int attackValue = 25;

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