using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : WeaponController
{
    public WeaponController weaponController;

    public MoveAllEnemies moveAllEnemies; //yeah naming here sucks too, let it be

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
        if (!moveAllEnemies.paused)
        {
            var newProjectile = Instantiate(projectileBody, transform.position, transform.rotation);

            newProjectile.velocity = cameraTransform.forward * shootSpeed;

            newProjectile.GetComponent<Projectile>().damage = (damage * weaponController.projectileDamage);
        }

        StartCoroutine(ShootingFrequency());
    }

    public new void UpgradeWeapon()
    {
        Debug.Log("test");
    }
}
