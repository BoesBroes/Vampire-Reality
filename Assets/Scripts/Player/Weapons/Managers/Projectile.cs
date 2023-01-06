using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyStats>())
        {
            collision.gameObject.GetComponent<EnemyStats>().LoseHealth(damage);

            Destroy(this);
        }
        else
        {
            Destroy(this);
        }
    }
}
