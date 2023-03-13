using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceManager : MonoBehaviour
{
    public Slider experienceSlider;
    public Text rankText;

    public int currentRank = 0;

    private float experienceMultiplier = 1; //while its called multiplier, it lowers pickups every rank up

    public void IncreaseExperience(float experiencePickup)
    {
        experienceSlider.value += (experiencePickup * experienceMultiplier);
        if(experienceSlider. value == 1)
        {
            //reset slider, increase rank, lower multiplier
            //TODO: upgrade stuff (or choose new weapons)
            experienceSlider.value = 0;
            currentRank++;
            experienceMultiplier = experienceMultiplier * .5f;

            rankText.text = "Rank: " + currentRank;
        }
    }
}
