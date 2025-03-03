using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class StrengthPotion : UsableItem.UsageEffect
{
        public int StrengthAmount;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(StrengthAmount);
        return true;
    }
}
