using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFloat : MonoBehaviour
{
    //Class allows player to float on water.

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float depthBeforeSubmerged = 1.0f;
    [SerializeField] private float displacement = 3.0f;
  
    private void FixedUpdate()
    {
       
        //Gets the height of the waves.
        float waveHeight = WaveManage.instance.getWaveHeight(transform.position.x);

        //Add force to bounce the boat back to the surface if under the wave height.
        //WAS WAVEHEIGHT, CHANGED BACK TO 0 SINCE THE WAVE PLANE DOES NOT MOVE.
        if (transform.position.y <= 0.0f)
        {
            float displaceMultiply = Mathf.Clamp01((waveHeight - transform.position.y) / depthBeforeSubmerged) * displacement;
            rb.AddForceAtPosition(new Vector3(0.0f, Mathf.Abs(Physics.gravity.y) * displaceMultiply, 0.0f), transform.position, ForceMode.Acceleration);
           
            
        }
    }
}
