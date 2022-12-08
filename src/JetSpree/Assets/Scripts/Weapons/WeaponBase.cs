using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{

    //Base script for weapons to inherit from.


    //Point of fire and the bullet's prefab.
    //Kept public for now, may change later.
     public Transform firePoint;
     public GameObject shotPrefab;


    private float coolDown;
    private float coolDownCounter;

    public virtual void Shoot()
    {

    }

    //Properties.
    //Getter and Setter for allowing access to private variable.
    public float CoolDown
    {
        get
        {
            return coolDown;
        }

        set
        {
            coolDown = value;
        }
    }
}
