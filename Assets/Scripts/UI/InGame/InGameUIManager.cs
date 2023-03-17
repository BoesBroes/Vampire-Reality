using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InGameUIManager : MonoBehaviour
{
    public HealthManager healthManager; 
    public ExperienceManager experienceManager; 
    public EnemiesManager enemiesManager; //for changing difficulty based on time
    public MoveAllEnemies moveAllEnemies; //should be called pausemanager by now:(

    [Header("UI Texts")]
    public Text timeText;
    private float timer;
    private int minutes = 0;

    [Header("Weapon Icons")]
    public Image[] weapons;

    [Header("Ability Icons")]
    public Image[] abilities;

    [Header("Current stats")] 
    public Slider healthSlider;
    public Slider experience;

    [Header("Waves)")]
    public int[] waveEmenies; //x minute will spawn x emenies
    //TODO: add/unlock new enemies to spawn

    private void Start()
    {
        timeText.text = "00:00";
    }

    private void Update()
    {
        if (!moveAllEnemies.paused)
        {
            //count time
            timer += Time.deltaTime;

            //add minutes
            if (timer >= 60)
            {
                minutes++;
                timer = 0;
                UpdateDifficulty(minutes); //update difficulty every minute (for now?)
            }

            //remove or set a "0" before the minute & seconds
            //hast thou heared of switch statements?
            if (minutes >= 10 && timer >= 10)
            {
                timeText.text = minutes + ":" + Mathf.RoundToInt(timer);
            }
            else if (minutes < 10 && timer >= 10)
            {
                timeText.text = "0" + minutes + ":" + Mathf.RoundToInt(timer);
            }
            else if (minutes < 10 && timer < 10)
            {
                timeText.text = "0" + minutes + ":0" + Mathf.RoundToInt(timer);
            }
            else if (minutes >= 10 && timer < 10)
            {
                timeText.text = minutes + ":0" + Mathf.RoundToInt(timer);
            }
        }

    }

    private void UpdateDifficulty(float currentTime)
    {
        enemiesManager.maxEnemies = waveEmenies[minutes];
        //if minutes > waveEnemies.length, die
    }

}
