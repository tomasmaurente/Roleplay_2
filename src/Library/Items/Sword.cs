using Interfaces;

namespace RoleplayGame
{
    public class Sword : IWeapons
    {
        private int attackValue = 20;

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