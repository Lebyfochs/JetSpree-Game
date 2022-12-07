using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotate : MonoBehaviour
{

    //Used to control direction of the turret.

    [SerializeField] private float sensitivity;
    [SerializeField] private Transform player;
    private float mouseX;
    
    void Start()
    {
        sensitivity = 900.0f;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
        player.Rotate(Vector3.up * mouseX);
        

    }


  
    
}
