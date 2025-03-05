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
            enemyHealth = 0;
        }
        else
        {
            enemyHealth -= 2;
        }
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        
    }
}
