using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    //the stats are in another class!
    public NavMeshAgent agent;
    public Transform playerPosition;


    private void FixedUpdate()
    {
        GoToPlayer();
    }

    void GoToPlayer()
    {
        agent.destination = playerPosition.position;
    }
}
