using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonProjectile : ProjectileBase
{


    public CannonProjectile()
    {
        ProjectileSpeed = 100.0f;
        ProjectileDamage = 15;
    }


    private void Start()
    {
        
        StartCoroutine(IMove());
    }


    public override IEnumerator IMove()
    {

       //UPDATE: Removed Time.DeltaTime from the rb.velocity command, seems to work now.
        //transform.Translate(Vector3.up * ProjectileSpeed * Time.deltaTime);
        rb.velocity = transform.TransformDirection(Vector3.forward * ProjectileSpeed);
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        yield return null;
    }



}
