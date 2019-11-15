﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propellor : MonoBehaviour
{
    public float verticalInput;
    public float rotationspeed = 300.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationspeed * Time.deltaTime * verticalInput);
    }
}
