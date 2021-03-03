using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonEnemy : DamagingObjects
{
    public override void OnCollisionEnter(Collision collision)
    {
        base.damagePlayer(10);
        Destroy(this.gameObject);
    }
}
