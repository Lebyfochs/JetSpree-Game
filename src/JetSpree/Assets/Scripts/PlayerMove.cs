using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerRotation;
    [SerializeField] private Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 80.0f;
        playerRotation = 40.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //This moves it forward in the direction of the rotation.
            rb.AddForce(transform.forward * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Despite saying forward it does move it back thanks to minus.
            rb.AddForce(playerSpeed * Time.deltaTime * -transform.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, -playerRotation * Time.deltaTime, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, playerRotation * Time.deltaTime, 0.0f, Space.World);
        }

        
    }
}
