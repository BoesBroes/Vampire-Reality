using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeOption : MonoBehaviour
{
    public MoveAllEnemies moveAllEnemies;
    public PlayerMovement playerMovement;


    public WeaponController weaponController;

    public GameObject upgradeObject;

    public Canvas upgradeCanvas;

    public void UpgradeWeapon()
    {
        Debug.Log("clicked");
        upgradeObject.GetComponent<WeaponController>().UpgradeWeapon();

        Cursor.visible = false;
        playerMovement.paused = false;
        moveAllEnemies.paused = false;

        upgradeCanvas.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
                                                