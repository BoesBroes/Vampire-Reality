using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAgentCollider : MonoBehaviour
{
    public Pickup pickup;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            pickup.GetComponent<Pickup>().agent.enabled = true;
            pickup.GetComponent<Pickup>().closeToPlayer = true;
        }
    }
}
