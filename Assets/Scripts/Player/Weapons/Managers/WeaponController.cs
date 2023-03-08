using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    //need to add these kind of variables per type of weapon/ability to upgrade multiple at once
    //TODO: think about whether everything is gonna be here (weapons/abilities/hidden upgrades eg movespeed) or seperate (its the first one)

    [Header("Projectile Based Weapons Multiplier")]
    public float projectileSpeed = 1f;
    public float projectileFrequency = 1f; //how many it shoots a second
    public int projectileDamage = 1;
    public float projectileKnockback = 1f; 
    //TODO; add public float projectileCriticalHit multiplier in the future

}
