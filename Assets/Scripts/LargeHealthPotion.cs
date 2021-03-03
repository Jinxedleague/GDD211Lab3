using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeHealthPotion : HealthModifiers
{
    public override void OnCollisionEnter(Collision collision)
    {
        base.healthPotMod(0, 1, 0);
        base.OnCollisionEnter(collision);
    }
}
