using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    //more like enemyManager, but oh well

    public int health = 10;
    public float agentSpeed = 2;

    public EnemiesManager enemiesManager;

    public GameObject pickupDrop;
    private void Start()
    {
        this.GetComponent<EnemyMovement>().agent.speed = agentSpeed;
    }

    public void LoseHealth(int hitPoints)
    {
        //deal damage and kill enemy if < 0
        //TODO: add points if kill
        health -= hitPoints;
        if(health <= 0)
        {
            enemiesManager.currentEnemiesTotal--;

            Instantiate(pickupDrop, gameObject.transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
