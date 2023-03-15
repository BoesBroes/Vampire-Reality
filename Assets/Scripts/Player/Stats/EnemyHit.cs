using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    //simple script for taking damage

    public HealthManager healthManager;
    //put on playerobject
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            //increase exp by amount set by pickup
            healthManager.TakeDamage(collision.gameObject.GetComponent<EnemyStats>().damage);
        }
    }
}
