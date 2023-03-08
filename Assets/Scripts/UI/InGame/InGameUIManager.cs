using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InGameUIManager : MonoBehaviour
{
    //boilerplating right here for future reference(tomorrow?)
    public StatsManager statsManager; //obtain future information from here

    public EnemiesManager enemiesManager; //for changing difficulty based on time

    [Header("UI Texts")]
    public Text timeText;
    private float timer;
    private int minutes = 0;

    [Header("Weapon Icons")]
    public Image firstWeapon;

    [Header("Ability Icons")]
    public Image firstAbility;

    [Header("Current stats")] //for now I can only think of health (at least whats useful for the player to see onscreen)
    public Slider healthSlider;


    private void Start()
    {
        timeText.text = "00:00";
    }

    private void Update()
    {
        //count time
        timer += Time.deltaTime;

        //add minutes
        if(timer >= 60)
        {
            minutes++;
            timer = 0;
        }

        //remove or set a "0" before the minute & seconds
        //hast thou heared of switch statements?
        if (minutes >= 10 && timer >= 10)
        {
            timeText.text = minutes + ":" + Mathf.RoundToInt(timer);
        }
        else if(minutes <= 10 && timer >=10)
        {
            timeText.text = "0" + minutes + ":" + Mathf.RoundToInt(timer);
        }
        else if (minutes <= 10 && timer <= 10)
        {
            timeText.text = "0" + minutes + ":0" + Mathf.RoundToInt(timer);
        }
        else if (minutes >= 10 && timer <= 10)
        {
            timeText.text = minutes + ":0" + Mathf.RoundToInt(timer);
        }

        UpdateDifficulty(timer);
    }

    private void UpdateDifficulty(float currentTime)
    {
        if(currentTime >= 1 && minutes <= 2)
        {
            enemiesManager.maxEnemies = 20;
        }
    }

}
