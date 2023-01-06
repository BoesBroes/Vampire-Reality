using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public WeaponController weaponController;

    public GameObject gunProjectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void StartShooting()
    {
        GameObject newProjectile = Instantiate(gunProjectile, transform.position, transform.rotation);
        //newProjectile.GetComponent<Rigidbody>().velocity = TransformDirection(Vector3(0, 0, weaponController.speed));
    }
}
