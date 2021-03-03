using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RareEnemy : DamagingObjects
{
    public override void OnCollisionEnter(Collision collision)
    {
        base.damagePlayer(40);
        Destroy(this.gameObject);
    }
}
