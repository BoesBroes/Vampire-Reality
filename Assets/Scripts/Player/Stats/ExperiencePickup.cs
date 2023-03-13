using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperiencePickup : MonoBehaviour
{
    public ExperienceManager experienceManager;
    //put on playerobject
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "pickup")
        {
            //increase exp by amount set by pickup
            experienceManager.IncreaseExperience(collision.gameObject.GetComponent<Pickup>().experiencePickup);
            Destroy(collision.gameObject);
        }
    }
}
