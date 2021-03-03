using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingObjects : Pickups
{
    public int damageHolder;
    public override void OnCollisionEnter(Collision collision)
    {
        base.damagePlayer(damageHolder);
        Destroy(this.gameObject);
    }
}
