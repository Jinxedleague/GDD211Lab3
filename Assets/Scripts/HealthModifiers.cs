using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthModifiers : Pickups
{
    public int small = 0;
    public int large = 0;
    public int full = 0;
    public override void OnCollisionEnter(Collision collision)
    {
        base.healthPotMod(small, large, full);
        base.OnCollisionEnter(collision);
    }

    public virtual void setMods(int smallMod, int largeMod, int fullMod)
    {
        small = smallMod;
        large = largeMod;
        full = fullMod;
    }
}
