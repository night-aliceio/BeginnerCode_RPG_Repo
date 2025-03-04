using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
public class ArmorScript : EquipmentItem.EquippedEffect
{
    public int DefenseAmount;
    public override void Equipped(CharacterData user)
    {
        int DefenseChange = 3;
        Sprite EffectSprite;
    }
    public bool Use(CharacterData user)
    {
        //Effect Adds Defense
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        modifier.Stats.defense = DefenseAmount;

        VFXManager.PlayVFX(VFXType.Stronger, user.transform.position);

        return true;
    }
     public override void Removed(CharacterData user)
     {
        int DefenseChange = -3;
        Sprite EffectSprite;

    }
}