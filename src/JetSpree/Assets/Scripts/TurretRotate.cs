using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotate : MonoBehaviour
{

    //Used to control direction of the turret.

    [SerializeField] private float sensitivity;
    [SerializeField] private Transform player;
    private float mouseX;
    private float xRot;
    
    void Start()
    {
        sensitivity = 900.0f;
        xRot = 0.0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Takes mouse X value and clamps it to 90 degrees.
        //Turret can only move 90 degrees one way or the other.
        mouseX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
        xRot += mouseX;
        xRot = Mathf.Clamp(xRot, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(0.0f, xRot, 0.0f);
        player.Rotate(Vector3.up * mouseX);

        

    }


  
    
}
