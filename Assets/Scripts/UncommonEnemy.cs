using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncommonEnemy : DamagingObjects
{
    public override void OnCollisionEnter(Collision collision)
    {
        base.damagePlayer(20);
        Destroy(this.gameObject);
    }
}
