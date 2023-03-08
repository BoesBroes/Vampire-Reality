using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public WeaponController weaponController;

    public Rigidbody projectileBody; 

    [Header("Weapon stats")]
    public float shootSpeed = 100f;
    public int damage = 2;
    public float knockBack = 1f;

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

        newProjectile.velocity = cameraTransform.forward * shootSpeed;

        newProjectile.GetComponent<Projectile>().damage = (damage * weaponController.projectileDamage);

        StartCoroutine(ShootingFrequency());
    }
}
