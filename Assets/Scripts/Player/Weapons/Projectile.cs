using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 1; //set by weapon

    private Rigidbody rb;


    public float timeToLive = 5f;
    private void Start()
    {
        Destroy(gameObject, timeToLive);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "enemy")
        {
            collision.gameObject.GetComponent<EnemyStats>().LoseHealth(damage);

            Destroy(gameObject);
        }
    }
}
