using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pickup : MonoBehaviour
{
    public float experiencePickup; //how much experience this pickup has (drop is a better name but too late now)

    public bool closeToPlayer = false;

    public Collider sphereCollider; //for future reference when upgrades happen and the radius increases (currently its 5)

    public NavMeshAgent agent;
    public Transform playerPosition; //set when spawning by enemyStats

    private void FixedUpdate()
    {
        if(closeToPlayer)
        {
            GoToPlayer();
        }
    }

    void GoToPlayer()
    {
        agent.destination = playerPosition.position;
    }
}
