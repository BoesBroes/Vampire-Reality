using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public WeaponController weaponController;

    //public GameObject gunProjectile;
    public Rigidbody projectileBody; //to save cpu time not having to getcomponent all the time

    public float shootSpeed = 100;

    public Transform cameraTransform;


    int frequency = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartShooting();
    }

    IEnumerator ShootingFrequency()
    {
        yield return new WaitForSeconds(frequency);

        StartShooting();
    }

    private void StartShooting()
    {
        var newProjectile = Instantiate(projectileBody, transform.position, transform.rotation);

        //newProjectile.AddForce(cameraTransform.forward * shootSpeed);

        newProjectile.velocity = cameraTransform.forward * shootSpeed;

        StartCoroutine(ShootingFrequency());
    }
}
