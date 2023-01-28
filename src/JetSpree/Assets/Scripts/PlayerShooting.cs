using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : PlayerMain
{

    //Script handles the firing of weapons for the player.

    Cannon cannon;
    [SerializeField] private float cooldownCounter;

    private void awake()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        cannon = gameObject.GetComponent<Cannon>();
        //Use this to test if object is set to null.
        //Debug.Log(GameObject.Find("cannon"));

        cooldownCounter = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Local cooldown. if cooldown of object is less than this fire weapon, then reset counter and start again.
        cooldownCounter += 0.01f;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Shoot!");

            if(cannon != null && cooldownCounter >= cannon.CoolDown)
            {
                cannon.Fire();
                cooldownCounter = 0.0f;
            }
            
        }
    }
}
