using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    //this is just some boilerplate stuff
    //need to add these kind of variables per type of weapon/ability to upgrade multiple at once
    //multipliers is what these will be

    [Header("Projectile Based Weapons Multiplier")]
    public float projectileSpeed;
    public float projectileInterval; //how many it shoots a second
    public int projectileDamage;
    public float projectileKnockback; 
    //TODO; add public float projectileCriticalHit multiplier in the future

}
