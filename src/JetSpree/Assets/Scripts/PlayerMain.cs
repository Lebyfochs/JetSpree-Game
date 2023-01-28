using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{

    //Used as de-facto 'state machine'
    //NORMAL is anything that does not involve capturing islands, may be changed later.
    //Written like this for testing purposes.
    public enum States{NORMAL, CAPTURING, LOADING, LOADED}
    public States currentState;

    //Change State function?

    void Start()
    {
        

        currentState = States.NORMAL;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
    }
}
