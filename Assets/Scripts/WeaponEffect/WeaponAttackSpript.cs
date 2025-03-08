using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class WeaponAttackSpript : Weapon.WeaponAttackEffect
{
   
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
       int enemyHealth = target.Stats.CurrentHealth;
        if (enemyHealth < 5)
        {
            enemyHealth = -5;
        }
        else
        {
            enemyHealth = -2;
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
