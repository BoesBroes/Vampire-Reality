using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public int maxEnemies;
    public int currentEnemiesTotal;

    public GameObject[] enemy;

    public Transform playerPosition;

    public int spawnFrequency;
    //TODO: add a way to spawn a certain type of enemy at certain points in time (maybe override maxEnemies?)

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(currentEnemiesTotal < maxEnemies)
        {
            //randomizer to not make all enemies spawn at once, needs some sensible update in the feature for balancing maybe? eg lower the number later in the game (see spawnfrequency)
            int random = Random.Range(1, 100);
            if(random > spawnFrequency)
            {
                SpawnEnemy();
            }
        }
    }

    //TODO: make this so x type of enemy can be spawned (seperate function for hordes tho)
    private void SpawnEnemy()
    {
        int spawnPointX = Random.Range(-50, 50);
        int spawnPointZ = Random.Range(-50, 50);
        if (spawnPointX <= 10 && spawnPointX >= -10)
        {
            return;
        }
        if (spawnPointZ <= 10 && spawnPointZ >= -10)
        {
            return;
        }

        else
        {
            //currently spawns the base enemy, array value needs to be assigned in the future based on (time) progression
            Vector3 spawnPosition = new Vector3(spawnPointX + playerPosition.position.x, 0, spawnPointZ + playerPosition.position.z);

            GameObject enemyInstantiated = Instantiate(enemy[0], spawnPosition, Quaternion.identity);
            enemyInstantiated.transform.parent = this.transform;

            enemyInstantiated.GetComponent<EnemyStats>().enemiesManager = this;
            enemyInstantiated.GetComponent<EnemyMovement>().playerPosition = playerPosition;

            currentEnemiesTotal++;
        }
    }
}
