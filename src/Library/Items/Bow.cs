using Interfaces;

namespace RoleplayGame 
{
    public class Bow : IWeapons
    {
        private int AttackValue;

        public int GetAttackValue()
        {
            return AttackValue;
        }

        public int GetDefenseValue()
        {
            return 0;
        }
    }
}