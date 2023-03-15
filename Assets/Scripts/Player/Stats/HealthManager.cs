using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthManager : MonoBehaviour
{
    //just a simple script to keep track of health (and kill the player!)

    public Slider healthSlider;

    public Image sliderFill; //the part of the slider that fills the slider

    private int damageMultiplier = 100; //to make adding damage easier 
    public void TakeDamage(float damage)
    {
        float actualDamage = (damage/damageMultiplier);

        healthSlider.value -= actualDamage;

        ChangeColor(healthSlider.value);

        if (healthSlider.value == 0)
        {
            //kill
        }
    }

    private void ChangeColor(float value)
    {
        //change color: red = 1 - value (value starts at 1 so rising) green is value (declining) if hit
        Color statsColor = new Color(1 - value,value, 0, 1);

        sliderFill.color = statsColor;
    }
}
