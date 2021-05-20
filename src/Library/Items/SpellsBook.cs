using Interfaces;

namespace RoleplayGame
{
    public class SpellsBook : IWeapons
    {
        public Spell[] Spells { get; set; }

        public int GetAttackValue()
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.GetAttackValue();
            }
            return value;
        }

        public int GetDefenseValue()
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.GetDefenseValue();
            }
            return value;
        }
    }
}