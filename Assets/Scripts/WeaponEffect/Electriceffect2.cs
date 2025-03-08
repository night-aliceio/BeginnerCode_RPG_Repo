using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Electriceffect2 : Weapon.WeaponAttackEffect
{
    public float PercentageChance;
    public int Damage;
    public float Time;
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        int enemyHealth = target.Stats.CurrentHealth;
        if (enemyHealth > 5)
        {
            ElementalEffect effect = new ElementalEffect(Time, StatSystem.DamageType.Electric, Damage, 2.0f);
            target.Stats.AddElementalEffect(effect);

        }
    }
    public int PercentageHealthStolen;
    public override string GetDescription()
    {
         
        return $"Convert {PercentageHealthStolen}% of physical damage into Health";
    }
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        int amount = Mathf.FloorToInt(data.GetDamage(StatSystem.DamageType.Physical) * (PercentageHealthStolen / 100.0f));
        user.Stats.ChangeHealth(amount);
    }
 
}
