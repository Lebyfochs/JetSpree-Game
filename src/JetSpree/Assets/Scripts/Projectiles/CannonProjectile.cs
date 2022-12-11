using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonProjectile : ProjectileBase
{


    public CannonProjectile()
    {
        ProjectileSpeed = 25.0f;
        ProjectileDamage = 15;
    }


    private void Start()
    {
        
        StartCoroutine(IMove());
    }


    public override IEnumerator IMove()
    {

        //Attempting to get the projectile to move based on turret's rotation. Will probably need to call an object in this script.
        //That or find a way here to make it move forward, the cannon script instantiate it at the rotation?
        //transform.Translate(Vector3.up * ProjectileSpeed * Time.deltaTime);
        rb.AddForce(transform.localPosition * ProjectileSpeed * Time.deltaTime, ForceMode.VelocityChange);
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
        yield return null;
    }



}
