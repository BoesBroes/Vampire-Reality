using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int health = 10;
    public float agentSpeed = 2;

    public EnemiesManager enemiesManager;
    private void Start()
    {
        this.GetComponent<EnemyMovement>().agent.speed = agentSpeed;
    }

    public void LoseHealth(int hitPoints)
    {
        //deal damage and kill enemy if < 0
        //TODO: add points if kill
        health = -hitPoints;
        if(health <= 0)
        {
            enemiesManager.currentEnemiesTotal--;
            Destroy(this);
        }
    }
}
