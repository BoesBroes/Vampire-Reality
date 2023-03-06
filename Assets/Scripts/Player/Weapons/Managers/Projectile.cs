using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage; //set by weapon

    public Transform orientation;

    private Rigidbody rb;

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

    //Delete projectile if too far away
    //Im guessing this is more efficient than waiting for x time or x distance?
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "ProjectileSphere")
        {
            Destroy(this);
        }
    }
}
