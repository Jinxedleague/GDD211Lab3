using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallHealthPotion : HealthModifiers
{
    public override void OnCollisionEnter(Collision collision)
    {
        base.healthPotMod(1, 0, 0);
        base.OnCollisionEnter(collision);
    }
}
