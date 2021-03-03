using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealthPotion : HealthModifiers
{
    public override void OnCollisionEnter(Collision collision)
    {
        base.healthPotMod(0, 0, 1);
        base.OnCollisionEnter(collision);
    }
}
