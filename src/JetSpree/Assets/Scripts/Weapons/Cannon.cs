using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : WeaponBase
{
    //Main default weapon of choice.
    public Cannon()
    {
        CoolDown = 2.0f;
    }


    public override void Fire()
    {
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);

        base.Fire();
    }
}
