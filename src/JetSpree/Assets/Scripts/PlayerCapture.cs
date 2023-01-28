using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCapture : PlayerMain
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "CaptureCollider")
        {
            //CHANGE TO 'CAPTURING' STATE.
            currentState = PlayerMain.States.CAPTURING;
            Debug.Log(currentState);
        }
    }
}
