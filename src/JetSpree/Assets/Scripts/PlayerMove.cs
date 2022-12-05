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
        playerSpeed = 90.0f;
        playerRotation = 0.35f;
        rb = GetComponent<Rigidbody>();
    }

    

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * playerRotation * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            //This moves it forward in the direction of the rotation.
            rb.AddForce(transform.forward * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            rb.AddForce(playerSpeed * Time.deltaTime * -transform.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(0.0f, -playerRotation * Time.deltaTime, 0.0f, Space.World);

            //Using torque to make the turning feel more 'weighty' and less instant.
            rb.AddTorque(0.0f, -playerRotation, 0.0f, ForceMode.Acceleration);



        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Rotate(0.0f, playerRotation * Time.deltaTime, 0.0f, Space.World);
            rb.AddTorque(0.0f, playerRotation, 0.0f, ForceMode.Acceleration);

        }




    }
}
