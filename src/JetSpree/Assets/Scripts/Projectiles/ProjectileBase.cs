using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectileBase : MonoBehaviour
{

    [SerializeField] private float projectileSpeed;
    [SerializeField] private int projectileDamage;
    public Rigidbody rb;



    public float ProjectileSpeed { get; set; }
    public float ProjectileDamage { get; set; }


    //Moves the projectile.
    public virtual IEnumerator IMove()
    {
        yield return null;
    }
    
}
