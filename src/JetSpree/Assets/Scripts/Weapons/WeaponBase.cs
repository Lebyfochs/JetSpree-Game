using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour
{

    //Base script for weapons to inherit from.

    //Point of fire and the bullet's prefab.
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject shotPrefab;


    private float coolDown;
    private float coolDownCounter;

    public virtual void Shoot()
    {

    }
}
