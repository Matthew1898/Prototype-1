using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed= 25.0f;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
    }

}
