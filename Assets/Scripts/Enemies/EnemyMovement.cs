using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    public MoveAllEnemies moveAllEnemies;

    //the stats are in another class!
    public NavMeshAgent agent;
    public Transform playerPosition;


    private void FixedUpdate()
    {
        if(!moveAllEnemies.paused)
        {
            GoToPlayer();
        }
        else
        {
            NoDestination();
        }
    }

    private void GoToPlayer()
    {
        agent.destination = playerPosition.position;
    }

    private void NoDestination()
    {
        //not deactivate, just stay at position
        agent.destination = gameObject.transform.position;
    }
}
