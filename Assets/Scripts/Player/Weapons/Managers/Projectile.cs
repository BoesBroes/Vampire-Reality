using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage; //set by weapon

    private Rigidbody rb;


    public float timeToLive = 5f;
    private void Start()
    {
        Destroy(gameObject, timeToLive);
    }

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
