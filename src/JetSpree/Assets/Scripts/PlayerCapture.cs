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


    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("CaptureZone"))
        {
            //CHANGE TO 'CAPTURING' STATE.
            changeState(States.CAPTURING);
            Debug.Log(currentState);
        }
    }

   
}
