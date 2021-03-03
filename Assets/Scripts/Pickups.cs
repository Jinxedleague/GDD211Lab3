using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public Player player;
    public virtual void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }

    public virtual void healthPotMod(int sp, int lp, int fp)
    {
        player.modifyPotionCount(sp, lp, fp);
    }

    public virtual void damagePlayer(int damage)
    {
        player.takeDamage(damage);
    }
}
