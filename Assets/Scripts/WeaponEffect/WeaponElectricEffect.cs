using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using System;
using static CreatorKitCode.StatSystem;

public class WeaponFireEffectScript : Weapon.WeaponAttackEffect
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
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        
    }
}
