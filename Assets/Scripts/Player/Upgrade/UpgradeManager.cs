using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpgradeManager : MonoBehaviour
{
    public MoveAllEnemies moveAllEnemies;
    public PlayerMovement playerMovement;


    public WeaponController weaponController;

    public GameObject[] currentWeapons;
    public GameObject[] currentAbilities; //TODO: create abilities

    public GameObject[] allWeapons;
    public GameObject[] allAbilities; //See TODO of current abilities

    public Image[] upgradeOptions;
    //TODO: add text about what the upgrade is

    public Canvas upgradeCanvas;

    public void StartUpgrade()
    {
        //pause enemy and player movement
        playerMovement.paused = true;
        moveAllEnemies.paused = true;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        upgradeCanvas.gameObject.SetActive(true);

        if(currentWeapons.Length >= 4 && currentAbilities.Length >= 4)
        {
            //only upgrade weapons & abilities
        }
        else if(currentWeapons.Length < 4 && currentAbilities.Length < 4)
        {
            //upgrade and obtain new weapons/abilities
        }
        else if(currentWeapons.Length >= 4 && currentAbilities.Length < 4)
        {
            //upgrade both, only get new abilities
        }
        else if(currentWeapons.Length < 4 && currentAbilities.Length >= 4)
        {
            //upgrade both, only new weapons
        }
    }

    private void  FillUpgrades()
    {
        for(int i = 0; i < upgradeOptions.Length; i++)
        {

        }
    }
}
