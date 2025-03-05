using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
public class ArmorScript : EquipmentItem.EquippedEffect
{
    StatSystem.StatModifier globalModifier;
    public override void Equipped(CharacterData user)
    {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.Stats.defense = 3;
        user.Stats.AddModifier(modifier);
        globalModifier = modifier;
        
    }
   
    public override void Removed(CharacterData user)
    {
        
        user.Stats.RemoveModifier(globalModifier);
       

    }
    
}