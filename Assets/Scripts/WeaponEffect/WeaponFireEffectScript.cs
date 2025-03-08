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
        if (UnityEngine.Random.value < (PercentageChance / 100.0f))
        {
            ElementalEffect effect = new ElementalEffect(Time, StatSystem.DamageType.Electric, Damage, 1.0f);
            target.Stats.AddElementalEffect(effect);
            ElementalEffect(float Duration);
            float Duration = 10.0f;
        }
    }

    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        
    }
}
