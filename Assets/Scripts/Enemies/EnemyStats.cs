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

    public int damage;
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

            GameObject pickup = Instantiate(pickupDrop, gameObject.transform.position, Quaternion.identity);

            //set position after spawn (correct y position)
            pickup.transform.position = new Vector3(transform.position.x, 0.4410394f, transform.position.z);//y position obtained from when agent is activated (not the cleanest I know)

            pickup.GetComponent<Pickup>().playerPosition = this.GetComponent<EnemyMovement>().playerPosition;

            Destroy(gameObject);
        }
    }
}
